using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Queen : ChessPiece
    {
<<<<<<< HEAD
        public Queen(Piece p, C c) : base(Piece.eQUEEN, c)
=======
        public Queen(Piece p, Color c, ChessSquare s) : base(Piece.eQUEEN, c, s)
>>>>>>> b7b7d359f0f228ef61f60ba84c31ae0deb9c1124
        {
            if (c == Color.eWHITE)
            {
                m_image = ChessGame.Properties.Resources.Queen_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.Queen_Black;
            }
        }

        public override ChessSquare[] GetSquares()
        {
            ChessBoard b = ChessBoard.GetBoard();
            return null;
        }
    }
}
