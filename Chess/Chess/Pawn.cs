using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : ChessPiece
    {
        public Pawn(Color c, ChessSquare s) : base(Piece.ePAWN, c, s)
        {
            if (c == Color.eWHITE)
            {
                m_image = Chess.Properties.Resources.w_Pawn;
            }
            else
            {
                m_image = Chess.Properties.Resources.b_Pawn;
            }
        }
        public override ChessSquare[] GetSquares()
        {
            return null;
        }
    }
}
