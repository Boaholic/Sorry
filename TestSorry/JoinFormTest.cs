using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorry;

namespace TestSorry
{
    //
    [TestClass()]
    public class JoinFormTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void JoinFormTest()
        {
            JoinForm testJoinForm = new JoinForm();
            testJoinForm.button1_Click();
            testJoinForm.OnFormClosing();
        }

    }
}
