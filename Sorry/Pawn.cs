﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorry
{
    class Pawn
    {
        private int boardLocationX { get; set; }

        private int boardLocationY { get; set; }

        private int ownerPlayer { get; set; }


        public void setBoardLocation(int x, int y)
        {
            // getting this.boardLocationX = x;
            //this.boardLocationY = y;
            //called from board class?

            boardLocationX = x;
            boardLocationY = y;

        }
    }
}
