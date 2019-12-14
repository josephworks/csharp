using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sudoku
{
    internal class Sudoku
    {
        #region Class Decelerations

        public int[,] s; // sudoku numbers

        private int[,] a; // aids

        private int[,] f; // facts

        private int[,] e; // errors

        private Random R;

        private float realx;

        private float realy;

        private float realw;

        private int hitx = -1;

        private int hity;

        public int sw = 0;

        private DateTime starttime;

        private string duration;

        private string msg_text1;

        private string msg_text2;

        private bool DisplayMessage = false;

        private bool PriorityMessage = false;

        public enum SudokuSound
        {
            Stop = 0,
            Square = 1,
            No = 2,
            Fine = 3,
            Delete = 4,
            Solved = 5,
            NewPuzzle = 6,
        };

        public delegate void SudokuEvent(SudokuSound S);

        public delegate void SudokuEvent2();

        public event SudokuEvent PlaySound;

        public event SudokuEvent2 RequestRepaint;

        public bool ShowErrors = false;

        public enum SolveMethods
        {
            All = 65535,
            NakedSingles = 1,
            HiddenSingles = 2,
            BlockHiddenSingles = 4,
        }

        public class SolutionStep
        {
            public int x;
            public int y;
            public int num;

            public SolutionStep()
            {
                x = 0; y = 0; num = 0;
            }

            public SolutionStep(int x, int y, int num)
            {
                this.x = x;
                this.y = y;
                this.num = num;
            }
        };

        public class SolutionStepList
        {
            private List<SolutionStep> L;

            public SolutionStepList()
            {
                L = new List<SolutionStep>();
            }

            private bool Search(SolutionStep ss)
            {
                for (int i = 0; i < L.Count; i++)
                {
                    SolutionStep present = L[i];

                    if (ss.x == present.x && ss.y == present.y && ss.num == present.num) return true;
                }

                return false;
            }

            public void Add(SolutionStep ss)
            {
                // if (!Search(ss)) L.Add(ss);

                L.Add(ss);
            }

            public int Count()
            {
                return L.Count;
            }

            public SolutionStep getItem(int index)
            {
                return L[index];
            }
        }

        #endregion Class Decelerations

        public Sudoku()
        {
            s = new int[9, 9];

            f = new int[9, 9];

            a = new int[9, 9];

            e = new int[9, 9];

            R = new Random();

            EnumeratePossibilities();

            return;
        }

        public void SetLocation(Point Location)
        {
            if (DisplayMessage & !PriorityMessage)
            {
                DisplayMessage = false;
                return;
            }

            int new_hitx = (int)Math.Floor((Location.X - realx) / realw * 9.0);

            int new_hity = (int)Math.Floor((Location.Y - realy) / realw * 9.0);

            if (new_hitx < 0 || new_hitx > 8 || new_hity < 0 || new_hity > 8)
            {
                hitx = -1;

                return;
            }

            if (new_hitx == hitx && new_hity == hity)
            {
                hitx = -1;
            }
            else
            {
                if (f[new_hity, new_hitx] == 0)
                {
                    hitx = new_hitx;

                    hity = new_hity;
                }
            }
        }

        public void Deselect()
        {
            hitx = -1;
        }

        public void DeleteCurrentSquare()
        {
            if (hitx != -1)
            {
                s[hity, hitx] = 0;
                e[hity, hitx] = 0;
            }

            hitx = -1;

            EnumeratePossibilities();
        }

        public void KeyPress(char KeyCode)
        {
            if (DisplayMessage & !PriorityMessage)
            {
                DisplayMessage = false;

                return;
            }

            if (KeyCode < '1' || KeyCode > '9') return;

            if (hitx == -1) return;

            s[hity, hitx] = KeyCode - '0';

            e[hity, hitx] = 0;

            hitx = -1;

            EnumeratePossibilities();

            // ComputeErrors();

            if (PlaySound != null) PlaySound(SudokuSound.Square);

            if (isSolved())
            {
                while (hitx != -1) Application.DoEvents();

                Timer T = new Timer();

                T.Tick += new EventHandler(DisplayPuzzleSolved);

                T.Interval = 1500;

                T.Start();

                TimeSpan d = (DateTime.Now - starttime);

                duration = "";

                if (d.Minutes > 0) duration = d.Minutes.ToString() + " minute";

                if (d.Minutes > 1) duration += "s";

                if (d.Minutes > 0 && d.Seconds > 0) duration += " and ";

                if (d.Seconds > 0) duration += d.Seconds.ToString() + " second";

                if (d.Seconds > 1) duration += "s";
            }
        }

        public void UseTemplate()
        {
            string game1 = "X6X1X4X5XXX83X56XX2XXXXXXX18XX4X7XX6XX6XXX3XX7XX9X1XX45XXXXXXX2XX72X69XXX4X5X8X7X"; // easy 1

            game1 = "XXXX7XX6X6XXXXXX42XXX89XX15XXXXX54XX769XXX521XX19XXXXX91XX42XXX28XXXXXX3X7XX8XXXX"; // easy 2

            // game1 = "XXXXXXXX547XXXXXXX85XX42XXX64X58XXXXXX79X41XXXXXX73X96XXX85XX34XXXXXXX673XXXXXXXX"; // hard 1

            game1 = "829173456713645298645298173381726945976514832452839617297381564168457329534962781"; //complete game

            SetGameString(game1);
        }

        public void GenerateGame()
        {
            if (PlaySound != null) PlaySound(SudokuSound.Stop);

            UseTemplate();

            int trials_counter = 0;

            int trials_max = 100;

            SolveMethods M = SolveMethods.All;

            // Generating a list of filled squares

            List<Point> L = new List<Point>();

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (s[j, i] > 0) L.Add(new Point(i, j));
                }

            int n;

            for (n = 0; n < 55;)
            {
                int index = R.Next(L.Count);

                int x = L[index].X;

                int y = L[index].Y;

                int temp = s[x, y];

                if (temp != 0)
                {
                    s[x, y] = 0;

                    Sudoku S2 = CreateCopy();

                    int solutionStepsCount = S2.ComputePossibleSteps(M).Count();

                    bool range0Ok = ((n > 35) && (solutionStepsCount > 25));

                    bool range1Ok = ((n > 15) && (solutionStepsCount > 25));

                    bool range2Ok = n < 16;

                    bool solutionStepsCountOk = range0Ok || range1Ok || range2Ok;

                    if (solutionStepsCountOk)
                    {
                        bool isSolvable = S2.SolvePuzzle(M);

                        if (isSolvable)
                        {
                            L.RemoveAt(index);

                            n++;

                            trials_counter = 0;
                        }
                        else
                        {
                            s[x, y] = temp;
                        }
                    }
                    else
                    {
                        s[x, y] = temp;
                    }
                    trials_counter++;
                }

                if (trials_counter > trials_max) break;
            }

            ScrambleGame();

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (s[i, j] == 0) f[i, j] = 0; else f[i, j] = 1;
                }

            //  SetGameString("XX7XXX5XXXXXX4XX3XXXX832X9X8XXXXX4XXX294X586XXX6XXXXX7X5X364XXXX7XX5XXXXXX3XXX2XX");

            EnumeratePossibilities();

            starttime = DateTime.Now;

            DisplayMessage = false;

            if (PlaySound != null) PlaySound(SudokuSound.NewPuzzle);

            if (RequestRepaint != null) RequestRepaint();
        }

        public void RenderMessage(string line1, string line2, bool priority)
        {
            if (!priority && DisplayMessage) return;

            msg_text1 = line1;
            msg_text2 = line2;
            PriorityMessage = priority;
            DisplayMessage = true;

            if (RequestRepaint != null) RequestRepaint();
        }

        public void ScrambleGame()
        {
            //0 1, 1 2, 3 4, 4 5, 6 7 7 8

            int[] scramble_array = { 0, 1, 3, 4, 6, 7 };

            int scrambles = 10;

            for (int n = 0; n < scrambles; n++)
            {
                int index = R.Next(6);

                int val = scramble_array[index];

                SwapRows(val, val + 1);
            }

            for (int n = 0; n < scrambles; n++)
            {
                int index = R.Next(6);

                int val = scramble_array[index];

                SwapCols(val, val + 1);
            }

            ChangeSymbols();

            EnumeratePossibilities();
        }

        public string GetGameString()
        {
            string result = "";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    result += s[i, j].ToString();
                }
            }

            result = result.Replace("0", "X");

            return result;
        }

        public bool SetGameString(string game)
        {
            if (game.Length != 81) return false;

            for (int n = 0; n < 81; n++)
            {
                char c = game[n];

                if ((c < '1' || c > '9') && c != 'X') return false;
            }

            for (int n = 0; n < 81; n++)
            {
                string c = game.Substring(n, 1);

                int i = n / 9;

                int j = n % 9;

                if (c == "X")
                {
                    s[i, j] = 0;
                    f[i, j] = 0;
                }
                else
                {
                    s[i, j] = Convert.ToInt32(c);
                    f[i, j] = 1;
                }
            }

            EnumeratePossibilities();

            DisplayMessage = false;

            return true;
        }

        public void Draw(Graphics G, float angle)
        {
            Color Background = Color.DarkKhaki;

            Brush BG1 = new Pen(Color.Khaki).Brush;

            Brush BG2 = new Pen(Color.LightGoldenrodYellow).Brush;

            Brush BG;

            Brush Selected = new Pen(Color.BurlyWood).Brush;

            Selected = new SolidBrush(Color.FromArgb(64, Color.RoyalBlue));

            Brush FontColor1 = Brushes.Black;

            Brush FontColor2 = Brushes.RoyalBlue;

            Brush FontColor3 = Brushes.Crimson;

            Brush FontColor = FontColor1;

            Pen Error = new Pen(Color.Red, 3);

            SolidBrush SmallFontColor = new SolidBrush(Color.FromArgb(200, Color.Black));

            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            G.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            G.Clear(Background);

            Pen Border1 = new Pen(Color.Black, 3);

            Pen Border2 = new Pen(Color.Black, 1);

            float w = G.VisibleClipBounds.Width;

            float h = G.VisibleClipBounds.Height;

            float min = Math.Min(w, h);

            float centre_x = w / 2;

            float centre_y = h / 2;

            float startx = centre_x - min / 2;

            float starty = centre_y - min / 2;

            float m = 50;

            realx = startx + m;

            realy = starty + m;

            realw = min - 2 * m;

            if (realw <= 0) return;

            float error_circle_m = realw / 9 * 0.95f;

            Font F = new Font("Arial", realw / 20);

            Font Fsmall = new Font("Arial", realw / 72);

            G.TranslateTransform(centre_x, centre_y);

            G.RotateTransform(angle);

            G.TranslateTransform(-centre_x, -centre_y);

            G.FillRectangle(Brushes.White, realx, realy, realw, realw);

            G.DrawRectangle(Border1, realx, realy, realw, realw);

            if (sw == 5)
            {
                FontColor2 = FontColor1;
                FontColor3 = FontColor1;
            }

            string num = "";

            for (float i = 0; i < 3; i++)
            {
                for (float j = 0; j < 3; j++)
                {
                    G.DrawRectangle(Border1, realx + realw * i / 3, realy + realw * j / 3, realw / 3, realw / 3);

                    if ((i + j) % 2 == 0) BG = BG1; else BG = BG2;

                    G.FillRectangle(BG, realx + realw * i / 3, realy + realw * j / 3, realw / 3, realw / 3);

                    for (float i2 = 0; i2 < 3; i2++)
                    {
                        for (float j2 = 0; j2 < 3; j2++)
                        {
                            if (i * 3 + i2 == hitx && j * 3 + j2 == hity) G.FillRectangle(Selected, realx + realw * (i / 3 + i2 / 9), realy + realw * (j / 3 + j2 / 9), realw / 9, realw / 9);

                            G.DrawRectangle(Border2, realx + realw * (i / 3 + i2 / 9), realy + realw * (j / 3 + j2 / 9), realw / 9, realw / 9);

                            int index_i = Convert.ToInt32(i * 3 + i2);

                            int index_j = Convert.ToInt32(j * 3 + j2);

                            num = s[index_j, index_i].ToString();

                            if (num == "0") num = "";

                            if (f[index_j, index_i] == 1) FontColor = FontColor1;

                            if (f[index_j, index_i] == 0) FontColor = FontColor2;

                            SizeF size_num = G.MeasureString(num, F);

                            float num_x = realx + realw * (i / 3 + i2 / 9) + (realw / 9 - size_num.Width) / 2;

                            float num_y = realy + realw * (j / 3 + j2 / 9) + (realw / 9 - size_num.Height) / 2;

                            // Rectangles: x for number, y for hints and z for error circle

                            RectangleF x = new RectangleF(num_x, num_y, size_num.Width, size_num.Height);

                            RectangleF y = new RectangleF(realx + realw * (i / 3 + i2 / 9), realy + realw * (j / 3 + j2 / 9), realw / 9, realw / 9);

                            RectangleF z = new RectangleF(realx + realw * (i / 3 + i2 / 9) + error_circle_m, realy + realw * (j / 3 + j2 / 9) + error_circle_m, realw / 9 - 2 * error_circle_m, realw / 9 - 2 * error_circle_m);

                            float num_centre_x = num_x + size_num.Width / 2;

                            float num_centre_y = num_y + size_num.Height / 2;

                            G.TranslateTransform(num_centre_x, num_centre_y);

                            G.RotateTransform(-angle);

                            G.TranslateTransform(-num_centre_x, -num_centre_y);

                            G.DrawString(num, F, FontColor, x);

                            G.TranslateTransform(num_centre_x, num_centre_y);

                            G.RotateTransform(+angle);

                            G.TranslateTransform(-num_centre_x, -num_centre_y);

                            if (e[index_j, index_i] == 1 && ShowErrors) G.DrawEllipse(Error, z);

                            string hints = "";

                            for (int b = 0; b < 9; b++)
                            {
                                if (((a[index_j, index_i] >> b) & 1) == 1)
                                {
                                    hints = hints + (b + 1).ToString();
                                }
                            }

                            //G.DrawString(hints, Fsmall, SmallFontColor, y);
                        }
                    }
                }
            }

            //if (solved == 1) ;

            if (DisplayMessage)
            {
                RenderMessageBox(G, msg_text1, msg_text2, realw / 22, realw / 36, w, h, realx, realy, realw);
            }

            //RenderMessageBox(G, "14 Possible Deductions", "Press any key to continue", realw / 22, realw / 36, w, h, realx, realy, realw);

            //RenderMessageBox(G, "Everything's cool dude!", "Press any key to continue", realw / 22, realw / 36, w, h, realx, realy, realw);
        }

        private void RenderMessageBox(Graphics G, string txt1, string txt2, float emSize1, float emSize2, float w, float h, float realx, float realy, float realw)
        {
            Brush Overlay = new SolidBrush(Color.FromArgb(150, Color.White));

            Brush MsgBoxBG = new SolidBrush(Color.LightSlateGray);

            RectangleF msgbox = new RectangleF(realx + realw / 12, realy + realw / 4, realw * 10 / 12, realw / 3);

            Font F1 = new Font("Arial", emSize1);

            Font F2 = new Font("Arial", emSize2);

            SizeF txt1size = G.MeasureString(txt1, F1);

            SizeF txt2size = G.MeasureString(txt2, F2);

            G.FillRectangle(Overlay, new RectangleF(0, 0, w, h));

            G.FillRectangle(MsgBoxBG, msgbox);

            G.DrawRectangle(Pens.Black, realx + realw / 12, realy + realw / 4, realw * 10 / 12, realw / 3);

            PointF txt1pos = new PointF(msgbox.Left + (msgbox.Width - txt1size.Width) / 2, msgbox.Top + (msgbox.Height - txt1size.Height) / 2 - msgbox.Height / 5);

            PointF txt2pos = new PointF(msgbox.Left + (msgbox.Width - txt2size.Width) / 2, msgbox.Top + (msgbox.Height - txt2size.Height) / 2 + msgbox.Height / 5);

            G.DrawString(txt1, F1, Brushes.White, txt1pos);

            G.DrawString(txt2, F2, Brushes.White, txt2pos);
        }

        public bool CheckGame()
        {
            List<int> L = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                // Checking rows:

                L.Clear();

                for (int j = 0; j < 9; j++) L.Add(s[i, j]);

                if (CheckOneToNine(L) == false) return false;

                // Checking rolumns:

                L.Clear();

                for (int j = 0; j < 9; j++) L.Add(s[j, i]);

                if (CheckOneToNine(L) == false) return false;

                // Checking blocks:

                for (int x = 0; x < 9; x += 3)
                {
                    for (int y = 0; y < 9; y += 3)
                    {
                        L.Clear();

                        for (int j = 0; j < 3; j++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                L.Add(s[x + j, y + k]);
                            }
                        }

                        if (CheckOneToNine(L) == false) return false;
                    }
                }
            }

            return true;
        }

        public bool checkSolvable(SolveMethods M)
        {
            Sudoku copy = CreateCopy();

            return copy.SolvePuzzle(M);
        }

        public SolutionStepList ComputePossibleSteps(SolveMethods M)
        {
            EnumeratePossibilities();

            SolutionStepList L = new SolutionStepList();

            // Looking for naked singles

            if ((M & SolveMethods.NakedSingles) > 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        double index = Math.Log(a[j, i], 2) + 1;

                        if (index == Math.Floor(index) && a[j, i] > 0 && s[j, i] == 0)
                        {
                            L.Add(new SolutionStep(i, j, Convert.ToInt32(index)));
                        }
                    }
                }
            }

            // Looking for hidden singles

            if ((M & SolveMethods.HiddenSingles) > 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        int mask = 0;

                        for (int m = 0; m < 9; m++)
                        {
                            if (m != j) mask |= a[m, i];
                        }

                        int match = a[j, i] & (511 - mask);

                        if (s[j, i] == 0 && match > 0)
                        {
                            // Bingo

                            double index = Math.Log(match, 2) + 1;

                            L.Add(new SolutionStep(i, j, Convert.ToInt32(index)));
                        }
                    }
                }
            }

            // Looking for block-hidden singles

            if ((M & SolveMethods.BlockHiddenSingles) > 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        int blockx = i / 3;

                        int blocky = j / 3;

                        int mask = 0;

                        for (int m = 0; m < 3; m++)
                        {
                            for (int n = 0; n < 3; n++)
                            {
                                int xindex = blockx * 3 + m;

                                int yindex = blocky * 3 + n;

                                if (yindex != j || xindex != i) mask |= a[yindex, xindex];
                            }
                        }

                        int match = a[j, i] & (511 - mask);

                        if (s[j, i] == 0 && match > 0)
                        {
                            // Bingo

                            double index = Math.Log(match, 2) + 1;

                            L.Add(new SolutionStep(i, j, Convert.ToInt32(index)));
                        }
                    }
                }
            }

            return L;
        }

        public bool SolveStep(SolveMethods M)
        {
            SolutionStepList L = ComputePossibleSteps(M);

            if (L.Count() == 0) return false;

            ApplySolutionStep(L.getItem(0));

            return true;
        }

        public bool SolvePuzzle(SolveMethods M)
        {
            while (SolveStep(M)) ;

            return (isFull());
        }

        public bool LoadFile(string file)
        {
            StreamReader R = new StreamReader(file);

            string content = R.ReadLine();

            R.Close();

            if (content.Length != 81) return false;

            return SetGameString(content);
        }

        public bool SaveFile(string file)
        {
            StreamWriter W = new StreamWriter(file);

            W.WriteLine(GetGameString());

            W.Close();

            return true;
        }

        public int ComputeErrors()
        {
            Sudoku S2 = this.CreateCopy();

            int errors_count = 0;

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (f[j, i] == 0) S2.s[j, i] = 0;
                }

            S2.SolvePuzzle(SolveMethods.All);

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (S2.s[j, i] == s[j, i] || s[j, i] == 0)
                    {
                        e[j, i] = 0;
                    }
                    else
                    {
                        e[j, i] = 1;
                        errors_count++;
                    }
                }

            return errors_count;
        }

        public bool isSolved()
        {
            return (isFull() && checkSolvable(SolveMethods.All));
        }

        #region Private Functions

        private bool isFull()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (s[i, j] == 0) return false;
                }
            return true;
        }

        private List<int> GenerateRandomList()
        {
            Random R = new Random();

            List<int> L1 = new List<int>();

            List<int> L2 = new List<int>();

            for (int i = 1; i < 10; i++) L1.Add(i);

            while (L1.Count > 0)
            {
                int index = R.Next(L1.Count);

                L2.Add(L1[index]);

                L1.RemoveAt(index);
            }

            return L2;
        }

        private bool CheckOneToNine(List<int> L)
        {
            if (L.Count != 9) MessageBox.Show("Problem here!");

            int[] vals = new int[10];

            for (int i = 0; i < 9; i++)
            {
                int item = L[i];

                if (item > 0)
                {
                    vals[item]++;

                    if (vals[L[i]] > 1) return false;
                }
            }
            return true;
        }

        private void EnumeratePossibilities()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    a[j, i] = 511;
                }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (s[j, i] > 0)
                    {
                        a[j, i] = (1 << (s[j, i]) - 1);

                        int mask = 511 - (1 << (s[j, i]) - 1);

                        int blockx = i / 3;

                        int blocky = j / 3;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                if (blocky * 3 + k != j || blockx * 3 + l != i) a[blocky * 3 + k, blockx * 3 + l] &= mask;
                            }
                        }

                        for (int n = 0; n < 9; n++)
                        {
                            // Removing entries from row and column squares

                            if (n != i) a[j, n] &= mask;

                            if (n != j) a[n, i] &= mask;
                        }
                    }
                }
            }
        }

        private void SwapRows(int r1, int r2)
        {
            int temp;

            for (int n = 0; n < 9; n++)
            {
                temp = s[r1, n];

                s[r1, n] = s[r2, n];

                s[r2, n] = temp;

                temp = f[r1, n];

                f[r1, n] = f[r2, n];

                f[r2, n] = temp;

                temp = a[r1, n];

                a[r1, n] = a[r2, n];

                a[r2, n] = temp;
            }
        }

        private void SwapCols(int c1, int c2)
        {
            int temp;

            for (int n = 0; n < 9; n++)
            {
                temp = s[n, c1];

                s[n, c1] = s[n, c2];

                s[n, c2] = temp;

                temp = f[n, c1];

                f[n, c1] = f[n, c2];

                f[n, c2] = temp;

                temp = a[n, c1];

                a[n, c1] = a[n, c2];

                a[n, c2] = temp;
            }
        }

        private void ChangeSymbols()
        {
            int[] symbols = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int scrambles = 10;

            for (int n = 0; n < scrambles; n++)
            {
                int index1 = R.Next(9) + 1;

                int index2 = R.Next(9) + 1;

                int temp = symbols[index1];

                symbols[index1] = symbols[index2];

                symbols[index2] = temp;
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    s[i, j] = symbols[s[i, j]];
                }
            }
        }

        private Sudoku CreateCopy()
        {
            Sudoku copy = new Sudoku();

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    copy.s[i, j] = s[i, j];
                }

            return copy;
        }

        private void DisplayPuzzleSolved(object sender, EventArgs e)
        {
            Timer T = (Timer)sender;

            T.Stop();

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    f[i, j] = 1;

            if (PlaySound != null) PlaySound(SudokuSound.Solved);

            msg_text1 = "Puzzle Solved";

            msg_text2 = duration;

            PriorityMessage = true;

            DisplayMessage = true;

            if (RequestRepaint != null) RequestRepaint();
        }

        private void ApplySolutionStep(SolutionStep ss)
        {
            s[ss.y, ss.x] = ss.num;

            f[ss.y, ss.x] = 0;
        }

        #endregion Private Functions
    }
}