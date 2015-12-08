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
    public class newNetworkTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void newNetworkTest()
        {
            newNetwork testnewNetwork = new newNetwork();
            testnewNetwork.panel1_Paint();
            testnewNetwork.button1_Click();
            testnewNetwork.button2_Click();
            testnewNetwork.OnFormClosing();
        }

    }
}
