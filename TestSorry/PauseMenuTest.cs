using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class PauseMenuTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void PauseMenuTest()
        {
            PauseMenu testPauseMenu = new PauseMenu();
            testPauseMenu.cancelButton_Click();
            testPauseMenu.saveButton_Click();
            testPauseMenu.saveGame();
            testPauseMenu.quitButton_Click();
            testPauseMenu.endButton_Click();
            testPauseMenu.resumeButton_Click();
        }
    }
}