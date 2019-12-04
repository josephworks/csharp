using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects.Advices;

namespace ChessGame
{
    class ChessBoard
    {
        private ChessSquare[,] m_b = new ChessSquare[8, 8];

        public ChessBoard()
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    m_b[r, c] = new ChessSquare(r + 1, c + 1);
                    System.Console.WriteLine(m_b[r, c]);
                }
            }
        }
    }
}
