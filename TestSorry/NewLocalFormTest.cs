using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class NewLocalFormTests
    {
        //Run Constructor
        //Check Functions
        [TestMethod()]
        public void NewLocalFormTest()
        {
            NewLocalForm testNewLocalForm = new NewLocalForm();
            testNewLocalForm.button1_Click();
            testNewLocalForm.listBox1_SelectedIndexChanged();
            testNewLocalForm.OnFormClosing();
            testNewLocalForm.radioButton1_CheckedChanged();
        }
    }
}