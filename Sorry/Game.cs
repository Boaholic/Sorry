using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorry
{
    //Rules and game functionality
    abstract class Game
    {
        public void GameBegin() { }
        public void PauseGame() { }
        public void SaveGame() { }
        public void QuitGame() { }
        private void GameWon() { }
        
        public void SquareButtonPressed() { }
        public void CardButtonPressed() { }
        protected abstract void ChangeTurn(int playerId);

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
