using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class DisplayTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void DisaplayTest()
        {
            Display testDisplay = new Display();
            testDisplay.Render();
            testDisplay.DisplayCard();
            testDisplay.InitializeCardImageMap();
            testDisplay.Dispose();
            testDisplay.InitializeComponent();
            testDisplay.DeckButtonHit();
            testDisplay.OnFormClosing();
            testDisplay.PauseButton_Click();
        }
    }
}