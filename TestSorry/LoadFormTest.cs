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
    public class LoadFormTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void LoadFormTest()
        {
            LoadForm testLoadForm = new LoadForm();
            testLoadForm.button1_Click();
            testLoadForm.OnFormClosing();
        }

    }
}
