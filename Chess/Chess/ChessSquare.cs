using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessSquare
    {
        private ChessPiece m_piece;
        private int m_row;
        private int m_column;
        public ChessSquare(ChessPiece p)
        {
            m_piece = p;
        }
        public ChessSquare(ChessPiece p, int row, int column)
        {
            m_piece = p;
            m_row = row;
            m_column = column;
        }
        public ChessSquare(int row, int column)
        {
            m_row = row;
            m_column = column;
        }
        public ChessSquare(string location)
        {
            string column = location.Substring(0, 1);
            string row = location.Substring(1, 1);
            switch (column)
            {
                case "A":
                    m_column = 1;
                    break;
                case "B":
                    m_column = 2;
                    break;
                case "C":
                    m_column = 3;
                    break;
                case "D":
                    m_column = 4;
                    break;
                case "E":
                    m_column = 5;
                    break;
                case "F":
                    m_column = 6;
                    break;
                case "G":
                    m_column = 7;
                    break;
                case "H":
                    m_column = 8;
                    break;
            }
            m_row = int.Parse(row);
        }
        public override string ToString()
        {
            string retVal = "";
            switch (m_column)
            {
                case 1:
                    retVal = "A";
                    break;
                case 2:
                    retVal = "B";
                    break;
                case 3:
                    retVal = "C";
                    break;
                case 4:
                    retVal = "D";
                    break;
                case 5:
                    retVal = "E";
                    break;
                case 6:
                    retVal = "F";
                    break;
                case 7:
                    retVal = "G";
                    break;
                case 8:
                    retVal = "H";
                    break;
            }
            return retVal + m_row;
        }
        public int GetRow()
        {
            return m_row;
        }
        public int GetColumn()
        {
            return m_column;
        }
        public void SetChessPiece(ChessPiece p) { m_piece = p; }
        public ChessPiece GetChessPiece() { return m_piece; }
    }
}
