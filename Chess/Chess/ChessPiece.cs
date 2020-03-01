using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess
{
    public enum Piece
    {
        eKING, eQUEEN, eROOK, eBISHOP, eKNIGHT, ePAWN
    }
    public enum Color
    {
        eBLACK, eWHITE
    }
     abstract class ChessPiece
    {
        public Image m_image;
        public ChessSquare m_square;
        public ChessPiece(Piece unit, Color color, ChessSquare s)
        {
            m_square = s;
            s.SetChessPiece(this);
        }
        public abstract ChessSquare[] GetSquares();  
    }
}
