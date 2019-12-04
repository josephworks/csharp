using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Bishop : ChessPiece
    {
        public Bishop(Piece p, Color c) : base(Piece.eBISHOP, c)
        {
            if (c = Color.eWHITE)
            {
                m_image = ChessGame.Properties.Resources.Bishop_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.Bishop_Black;
            }
        }

        public override ChessSquare[] GetSquares()
        {
            ChessBoard b = ChessBoard.GetBoard;
            return null;
        }
    }
}
