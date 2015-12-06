using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorry
{
    public class Pawn
    {
        public Pawn(int x,int y,int owner) {
            boardLocationX = x;
            boardLocationY = y;
            ownerPlayer = owner;
        }

        private int boardLocationX { get; set; }

        private int boardLocationY { get; set; }

        public int ownerPlayer { get; set; }


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
