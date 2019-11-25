using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public enum Piece
    {
        eKING, eQUEEN, eROOK, eKNIGHT, ePAWN, eBISHOP
    }

    public enum C
    {
        eBLACK, eWHITE
    }
    class ChessPiece
    {
        public Image m_image;
        public ChessPiece(Piece unit, C c)
        {

        }
    }
}
