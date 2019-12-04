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
        public ChessPiece(Piece unit, Color c) { }
        public abstract ChessSquare[] GetSquares();
    }
}
