using System.Windows.Forms;
using static System.Console;

namespace ConsoleForms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Beep(1000, 500);
            Beep(2000, 500);
            Beep(3000, 500);
            Beep(4000, 500);
            Beep(5000, 500);
            Beep(6000, 500);
            Beep(7000, 500);
            Beep(8000, 500);
            Beep(9000, 500);
            Beep(10000, 500);
            while (MessageBox.Show("Do you want another beep",
                       "State Controlled Loop", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                times++;
                if (times == 3)
                    break;
                if (times % 2 == 0)
                    continue;
                Beep(1000, 10000);
            }
        }
    }
}