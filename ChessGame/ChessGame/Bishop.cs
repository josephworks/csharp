using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class bishop : Chesspiece
    {
        public bishop(Color c,Chesssquare s) : base(piece.eBISHOP, c,s)
        {
            if (c == Color.eWHITE)
            {

                m_image = CHESSONFORM.Properties.Resources.BishopW;
            }
            else
            {
                m_image = CHESSONFORM.Properties.Resources.BishopB;
            }
        }
        public override Chesssquare[] GetSquares()
        {
            Chessboard b = Chessboard.GetBoard();
            return null;
        }
    }
}
