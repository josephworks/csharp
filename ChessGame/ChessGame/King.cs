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
<<<<<<< HEAD
        public King(Piece p, C c) : base(Piece.eKING, c)
        {
            if (c == C.eWHITE)
            {
=======
        public King(Color c,ChessSquare s) : base(Piece.eKING, c,s)
        {
            if (c == Color.eWHITE)
            {

>>>>>>> b7b7d359f0f228ef61f60ba84c31ae0deb9c1124
                m_image = ChessGame.Properties.Resources.King_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.King_Black;
            }
<<<<<<< HEAD
=======
            
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
>>>>>>> b7b7d359f0f228ef61f60ba84c31ae0deb9c1124
        }
    }
}
