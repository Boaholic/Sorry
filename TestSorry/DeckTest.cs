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
    public class DeckTest
    {
        [TestMethod()]
        public void testDeck()
        {
            Deck testDeck = new Deck();
            testDeck.CreateDeck();
            testDeck.DrawCard();
            testDeck.Shuffle();
            Assert.IsNotNull(testDeck);
        }

    }
}
