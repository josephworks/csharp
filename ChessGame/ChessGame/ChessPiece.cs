using System.Drawing;

namespace ChessGame
{
    public enum Piece
    {
        eKING, eQUEEN, eROOK, eKNIGHT, ePAWN, eBISHOP
    }

    public enum Color
    {
        eBLACK, eWHITE
    }

    abstract class ChessPiece
    {
        public Image m_image;
        public ChessSquare m_square;
        public ChessPiece(Piece unit, Color color,ChessSquare s) 
        {
            m_square = s;
        }
        public abstract ChessSquare[] GetSquares();
    }
}
