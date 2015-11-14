using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorry
{
    class SquareButton
    {
        // Not sure what type this would need to be.  Also don't know if we really need this in the squareButton class
        //private displayImage; 
        private int boardLocationX;
        private int boardLocationY;
        //Will uncomment when class Game is created
        //private Game game;  

        public SquareButton(int x, int y)
        {
            boardLocationX = x;
            boardLocationY = y;
        }

        public void ButtonPressed()
        {
            //Will uncomment when game class is created
            //game.SquareButtonPressed(boardLocationX, boardLocationY);
        }
    }
}
