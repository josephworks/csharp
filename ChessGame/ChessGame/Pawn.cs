using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Pawn : ChessPiece
    {
        public Pawn(Piece p, Color c, ChessSquare s) : base(Piece.ePAWN, c, s)
        {
            if (c == Color.eWHITE)
            {
                m_image = ChessGame.Properties.Resources.Pawn_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.Pawn_Black;
            }
        }

        public override ChessSquare[] GetSquares()
        {
            ChessBoard b = ChessBoard.GetBoard();
            return null;
        }
    }
}
