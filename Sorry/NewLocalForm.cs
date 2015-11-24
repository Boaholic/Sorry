using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorry
{
    public partial class NewLocalForm : Form
    {
        public NewLocalForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int local;
            
            if(e.Equals("One"))
            {
                Console.Write("True");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Run(new StartMenu());
        }
    }
}
