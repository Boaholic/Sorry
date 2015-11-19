using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorry
{
    //Rules and game functionality
    class Game
    {
        public void GameBegin() {
            //Load Start menu
            //Application.Run(Something_neat);
            //get user settings & set variables
            //start game
            Application.Run(new Display());
            //game loop
                //take move
                //check rules
                //check for end came condition
        }
        public void PauseGame() { }
        public void SaveGame() { }
        public void QuitGame() { }
        private void GameWon() { }
        
        public void SquareButtonPressed() { }
        public void CardButtonPressed() { }
        protected void ChangeTurn(int playerId) { }

        protected Board board;
        protected Deck deck;
        protected Display panel;
        protected int[] playerId;
        protected int currentPlayerTurn;
        protected string theme;
        protected Square prevSquarePressed;
        protected Card prevCard;



    }
}
