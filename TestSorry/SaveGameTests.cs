using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorry;

namespace TestSorry
{
    [TestClass()]
    public class SaveGameTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void SaveGameTest()
        {
            SaveGame testSaveGame = new SaveGame();
            testSaveGame.saveButtonOne_Click();
            testSaveGame.saveButtonTwo_Click();
            testSaveGame.saveButtonThree_Click();
            testSaveGame.saveButtonFour_Click();
            testSaveGame.cancelButton_Click();
        }

    }
}
