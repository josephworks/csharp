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
        public Chesssquare m_square;
        public Chesspiece(piece unit, Color color,Chesssquare s) 
        {
            m_square = s;
        }
        public abstract Chesssquare[] GetSquares();
    }
}
