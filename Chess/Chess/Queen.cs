using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : ChessPiece
    {
        public Queen(Color c, ChessSquare s) : base(Piece.eQUEEN, c, s)
        {
            if (c == Color.eWHITE)
            {
                m_image = Chess.Properties.Resources.w_Queen;
            }
            else
            {
                m_image = Chess.Properties.Resources.b_Queen;
            }
        }
        public override ChessSquare[] GetSquares()
        {
            return null;
        }
    }
}
