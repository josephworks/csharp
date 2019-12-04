using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Knight : ChessPiece
    {
        public Knight(Piece p, Color c) : base(Piece.eKNIGHT, c)
        {
            if (c = Color.eWHITE)
            {
                m_image = ChessGame.Properties.Resources.Knight_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.Knight_Black;
            }
        }

        public override ChessSquare[] GetSquares()
        {
            ChessBoard b = ChessBoard.GetBoard;
            return null;
        }
    }
}
