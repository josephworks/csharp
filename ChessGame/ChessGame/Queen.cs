using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Queen : ChessPiece
    {
        public Queen(Piece p, Color c) : base(Piece.eQUEEN, c)
        {
            if (c = Color.eWHITE)
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
            ChessBoard b = ChessBoard.GetBoard;
            return null;
        }
    }
}
