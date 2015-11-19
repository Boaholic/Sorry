using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorry
{
    public class Pawn
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

        /// <summary>
        /// Returns a KeyValuePair of the x,y coordinate of the pawn.
        /// </summary>
        /// <returns></returns>
        public KeyValuePair<int, int> getBoardLocation()
        {
            return new KeyValuePair<int, int>(boardLocationX, boardLocationY);
        }
    }
}
