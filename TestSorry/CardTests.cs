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
        [TestMethod()]
        public void CardValTest()
        {
            Card testCard=new Card();
            testCard.cardVal = Card.VALUE.One;
            Assert.IsTrue(testCard.cardVal == Card.VALUE.One);
        }
    }
}