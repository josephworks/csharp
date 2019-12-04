using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Rook : ChessPiece
    {
        public Rook(Piece p, Color c) : base(Piece.eROOK, c)
        {
            if (c = Color.eWHITE)
            {
                m_image = ChessGame.Properties.Resources.Rook_White;
            }
            else
            {
                m_image = ChessGame.Properties.Resources.Rook_Black;
            }
        }

        public override ChessSquare[] GetSquares()
        {
            ChessBoard b = ChessBoard.GetBoard;
            return null;
        }
    }
}
