using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class ChessSquare
    {
        private ChessPiece m_piece = new ChessPiece();

        public ChessSquare(ChessPiece p)
        {
            m_piece = p;
        }
    }
}
