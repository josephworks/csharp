using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    class King : ChessPiece
    {
        public King(Piece p, C c) : base(Piece.eKING, c)
        {
            if (c == C.eWHITE)
            {
                m_image = ChessGame.Properties.Resources.King_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.King_Black;
            }
        }
    }
}
