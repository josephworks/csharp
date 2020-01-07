using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Rook : ChessPiece
    {
<<<<<<< HEAD
        public Rook(Piece p, C c) : base(Piece.eROOK, c)
=======
        public Rook(Piece p, Color c, ChessSquare s) : base(Piece.eROOK, c, s)
>>>>>>> b7b7d359f0f228ef61f60ba84c31ae0deb9c1124
        {
            if (c == Color.eWHITE)
            {
                m_image = ChessGame.Properties.Resources.Rook_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.Rook_Black;
            }
        }

        public override ChessSquare[] GetSquares()
        {
            ChessBoard b = ChessBoard.GetBoard();
            return null;
        }
    }
}
