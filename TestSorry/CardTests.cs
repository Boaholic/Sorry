using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class CardTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void CardValTest()
        {
            Card testCard=new Card();
            testCard.cardVal = Card.VALUE.One;
            Assert.IsTrue(testCard.cardVal == Card.VALUE.One);
        }
    }
}