using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class bishop : ChessPiece
    {
        public bishop(Color c,ChessSquare s) : base(Piece.eBISHOP, c,s)
        {
            if (c == Color.eWHITE)
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
            ChessBoard b = ChessBoard.GetBoard();
            return null;
        }
    }
}
