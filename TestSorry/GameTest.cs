using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class GameTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void GameTest()
        {
            Game testGame = new Game();
            testGame.PauseGame();
            testGame.SaveGame();
            testGame.QuitGame();
            testGame.GameWon();
            testGame.SquareButtonPressed();
            testGame.CardButtonPressed();
            testGame.ChangeTur();
        }
    }
}