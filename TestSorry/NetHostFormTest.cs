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
    public class NetHostFormTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void NetHostFormTest()
        {
            NetHostForm testNetHostForm = new NetHostForm();
            testNetHostForm.listBox1_SelectedIndexChanged();
            testNetHostForm.label6_Click();
            testNetHostForm.textBox1_TextChanged();
            testNetHostForm.label7_Load();
            testNetHostForm.panel1_Paint();
            testNetHostForm.button1_Click();
            testNetHostForm.OnFormClosing();

        }

    }
}
