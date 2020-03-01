using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King : ChessPiece
    {
        public King(Color c, ChessSquare s) : base(Piece.eKING, c, s)
        {
            if (c == Color.eWHITE)
            {
                m_image = Chess.Properties.Resources.w_King;
            }
            else
            {
                m_image = Chess.Properties.Resources.b_King;
            }
        }
        public override ChessSquare[] GetSquares()
        {
            ChessBoard b = ChessBoard.GetBoard();
            ChessSquare[] move = new ChessSquare[8];
            if (m_square.GetColumn() > 1)
                move[0] = b.GetSquare(m_square.GetRow(), m_square.GetColumn() - 1);
            else
                move[0] = null;
            if (m_square.GetColumn() < 8)
                move[1] = b.GetSquare(m_square.GetRow(), m_square.GetColumn() + 1);
            else
                move[0] = null;
            if (m_square.GetRow() > 1 && m_square.GetColumn() > 1)
                move[2] = b.GetSquare(m_square.GetRow() - 1, m_square.GetColumn() - 1);
            else
                move[0] = null;
            if (m_square.GetRow() < 8 && m_square.GetColumn() < 8)
                move[3] = b.GetSquare(m_square.GetRow() + 1, m_square.GetColumn() + 1);
            else
                move[0] = null;
            if (m_square.GetRow() < 8 && m_square.GetColumn() > 1)
                move[4] = b.GetSquare(m_square.GetRow() + 1, m_square.GetColumn() - 1);
            else
                move[0] = null;
            if (m_square.GetColumn() > 1 && m_square.GetRow() < 8)
                move[5] = b.GetSquare(m_square.GetRow() - 1, m_square.GetColumn() + 1);
            else
                move[0] = null;
            if (m_square.GetRow() < 8)
                move[6] = b.GetSquare(m_square.GetRow() + 1, m_square.GetColumn());
            else
                move[0] = null;
            if (m_square.GetRow() > 1)
                move[7] = b.GetSquare(m_square.GetRow() - 1, m_square.GetColumn());
            else
                move[0] = null;

            m_square.GetRow();
            return null;
        }
    }
}
