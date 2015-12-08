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
        public Game(int theme)
        {
            setTheme(theme);
        }
        public int gameTheme;
        public void GameBegin() {
            //Load Start menu
            //Application.Run(Something_neat);
            //get user settings & set variables
            //start game
            board = new Board();
            deck = new Deck();
            currentPlayerTurn = 0;
            panel = new Display(this, getTheme());
            panel.Show();
            //game loop
            //take move
            //check rules
            //check for end came condition
        }
        public void setTheme(int t)
        {
            gameTheme = t;
        }
        public int getTheme()
        {
            return gameTheme;
        }
        public void PauseGame() { }
        public void SaveGame() { }
        public void QuitGame() { }
        private void GameWon() { }
        
        public void SquareButtonPressed(object sender, EventArgs e)
        {
            var curSquareButton = (SquareButton)sender;
            var squarePressed = curSquareButton.parentSquare;
            if (prevCard == null)
                return;

            if (prevSquarePressed == null)
            {
                if (squarePressed.IsOccupied() != null && squarePressed.IsOccupied().ownerPlayer == currentPlayerTurn)
                {
                    prevSquarePressed = squarePressed;
                }

            }
            else
            {
                //logic comes in to play

                // we now need to validate the move
                switch (prevCard.cardVal)
                {
                    case Card.VALUE.One:
                        if (prevSquarePressed.type == SquareType.Start)
                        {
                            if (board.validateDistance(prevSquarePressed, squarePressed, 1)) {
                                squarePressed.SetOccupied(prevSquarePressed.IsOccupied());
                                prevSquarePressed.SetOccupied(null);
                            }
                        }
                        break;
                    case Card.VALUE.TWO:
                        break;
                    case Card.VALUE.THREE:
                        break;
                    case Card.VALUE.FOUR:
                        break;
                    case Card.VALUE.FIVE:
                        break;
                    case Card.VALUE.SEVEN:
                        break;
                    case Card.VALUE.EIGHT:
                        break;
                    case Card.VALUE.TEN:
                        break;
                    case Card.VALUE.ELEVEN:
                        break;
                    case Card.VALUE.TWELVE:
                        break;
                    case Card.VALUE.SORRY:
                        break;
                }
            }
            panel.Render();
        }
        public Card CardButtonPressed()
        {
            //logic needs to go here to see if it is impossible for the player to move


            if (prevCard == null) {
                prevCard = deck.DrawCard();
            }
            return prevCard;
        }

        public void PassPressed(object sender, EventArgs e)
        {
            ChangeTurn();
        }

        /// <summary>
        /// Move on to the next Players Turn, and allow the user to pick a new card.
        /// </summary>
        protected void ChangeTurn() {
            prevCard = null;
            currentPlayerTurn = (currentPlayerTurn + 1) % 4;
            string playerName = "None";
            switch (currentPlayerTurn) {
                case 0:
                    playerName = "Red";
                    break;
                case 1:
                    playerName = "Blue";
                    break;
                case 2:
                    playerName = "Yellow";
                    break;
                case 3:
                    playerName = "Green";
                    break;
            }

            MessageBox.Show("Player "+playerName+" Turn", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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
