using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class king : Chesspiece
    {
        public king(Color c,Chesssquare s) : base(piece.eKING, c,s)
        {
            if (c == Color.eWHITE)
            {

                m_image = CHESSONFORM.Properties.Resources.King_White;
            }
            else
            {
                m_image = CHESSONFORM.Properties.Resources.King_Black;
            }
        }
        public override Chesssquare[] GetSquares()
        {
            Chessboard b = Chessboard.GetBoard();
            Chesssquare[] move = new Chesssquare[8];
            move[0] = b.GetSquare(m_square.GetRow(),m_square.GetColumn()-1);
            move[1] = b.GetSquare(m_square.GetRow(), m_square.GetColumn()+1);
            move[2] = b.GetSquare(m_square.GetRow()-1, m_square.GetColumn()-1);
            move[3] = b.GetSquare(m_square.GetRow()-1, m_square.GetColumn()+1);
            move[4] = b.GetSquare(m_square.GetRow()+1, m_square.GetColumn()+1);
            move[5] = b.GetSquare(m_square.GetRow()+1, m_square.GetColumn()-1);
            move[6] = b.GetSquare(m_square.GetRow()+1, m_square.GetColumn());
            move[7] = b.GetSquare(m_square.GetRow()-1, m_square.GetColumn());
            return null;
        }
    }
}
