using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class king : ChessPiece
    {
        public king(Color c,ChessSquare s) : base(Piece.eKING, c,s)
        {
            if (c == Color.eWHITE)
            {

                m_image = ChessGame.Properties.Resources.King_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.King_Black;
            }
        }
        public override ChessSquare[] GetSquares()
        {
            ChessBoard b = ChessBoard.GetBoard();
            ChessSquare[] move = new ChessSquare[8];
            if (m_square.GetColumn() > 1)
            {
                move[0] = b.GetSquare(m_square.GetRow(), m_square.GetColumn() - 1);
            }
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
