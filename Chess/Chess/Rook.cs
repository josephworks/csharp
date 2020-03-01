using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Rook : ChessPiece
    {
        public Rook(Color c, ChessSquare s) : base(Piece.eROOK, c, s)
        {
            if (c == Color.eWHITE)
            {
                m_image = Chess.Properties.Resources.w_Rook;
            }
            else
            {
                m_image = Chess.Properties.Resources.b_Rook;
            }
        }
        public override ChessSquare[] GetSquares()
        {
            return null;
        }
    }
}
