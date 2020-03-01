using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Knight : ChessPiece
    {
        public Knight(Color c, ChessSquare s) : base(Piece.eKNIGHT, c, s)
        {
            if (c == Color.eWHITE)
            {
                m_image = Chess.Properties.Resources.w_Knight;
            }
            else
            {
                m_image = Chess.Properties.Resources.b_Knight;
            }
        }
        public override ChessSquare[] GetSquares()
        {
            return null;
        }
    }
}
