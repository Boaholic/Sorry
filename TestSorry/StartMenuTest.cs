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
    public class StartMenuTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void StartMenuTest()
        {
            StartMenu testStartMenu = new StartMenu();
            testStartMenu.button1_Click();
            testStartMenu.button2_Click();
            testStartMenu.button3_Click();
            testStartMenu.button4_Click();
        }

    }
}
