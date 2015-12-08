using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorry
{
    //Rules and game functionality
    public class Game
    {
        public void GameBegin() {
            //Load Start menu
            //Application.Run(Something_neat);
            //get user settings & set variables
            //start game
            board = new Board();
            deck = new Deck();
            currentPlayerTurn = 0;
            panel = new Display(this, 0);
            panel.Show();
            //game loop
            //take move
            //check rules
            //check for end came condition
        }
        public void PauseGame() { }
        public void SaveGame() { }
        public void QuitGame() { }
        private void GameWon() { }
        
        public void SquareButtonPressed(object sender, EventArgs e)
        {
            
        }
        public Card CardButtonPressed()
        {
            if (prevCard == null) {
                prevCard = deck.DrawCard();
            }
            return prevCard;
        }

        /// <summary>
        /// Move on to the next Players Turn, and allow the user to pick a new card.
        /// </summary>
        protected void ChangeTurn() {
            prevCard = null;
            currentPlayerTurn = (currentPlayerTurn + 1) % 4;
        }

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
