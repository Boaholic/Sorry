using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    //
    [TestClass()]
    public class BoardTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void BoardTest()
        {
            Board testBoard = new Board();
            testBoard.ValidateDistance();
            Assert.IsNotNull(testBoard);
        }
    }
}