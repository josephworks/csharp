using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class King : ChessPiece
    {
        public King(Piece p, Color c) : base(Piece.eKING, c)
        {
            if (c = Color.eWHITE)
            {
                m_image = ChessGame.Properties.Resources.King_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.King_Black;
            }
        }

        public override ChessSquare[] GetSquares()
        {
            ChessBoard b = ChessBoard.GetBoard;
            return null;
        }
    }
}
