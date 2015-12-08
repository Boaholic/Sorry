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
    public class SquareButtonTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void SquareButtonTest()
        {
            SquareButton testSquareButton = new SquareButton();
            testSquareButton.UpdateBackgroundImage();
            testSquareButton.boardLocationX();
            testSquareButton.boardLocationy();
        }

    }
}
