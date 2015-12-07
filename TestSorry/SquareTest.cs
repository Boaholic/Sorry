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
    public class SquareTests
    {
        [TestMethod()]
        public void SquareTest()
        {
            Square testSquare = new Square();
            testSquare.IsOccupied();
            //testSquare.SetOccupied();
        }

    }
}
