using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class bishop : ChessPiece
    {
<<<<<<< HEAD
        public Bishop(Piece p, C c) : base(Piece.eBISHOP, c)
=======
        public bishop(Color c,ChessSquare s) : base(Piece.eBISHOP, c,s)
>>>>>>> b7b7d359f0f228ef61f60ba84c31ae0deb9c1124
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
