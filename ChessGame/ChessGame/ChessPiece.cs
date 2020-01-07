<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using System.Drawing;
>>>>>>> b7b7d359f0f228ef61f60ba84c31ae0deb9c1124

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

    abstract class ChessPiece
    {
        public Image m_image;
<<<<<<< HEAD
        public ChessPiece(Piece unit, C c)
=======
        public ChessSquare m_square;
        public ChessPiece(Piece unit, Color color,ChessSquare s) 
>>>>>>> b7b7d359f0f228ef61f60ba84c31ae0deb9c1124
        {
            m_square = s;
            s.SetChessPiece(this);
        }
        public abstract ChessSquare[] GetSquares();
    }
}
