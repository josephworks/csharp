using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Bishop : ChessPiece
    {
        public Bishop(Color c, ChessSquare s) : base(Piece.eBISHOP, c, s)
        {
            if (c == Color.eWHITE)
            {
                m_image = Chess.Properties.Resources.w_Bishop;
            }
            else
            {
                m_image = Chess.Properties.Resources.b_Bishop;
            }
        }
        public override ChessSquare[] GetSquares()
        {
        return null;
        }
    }
}
