using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorry
{
    public partial class NetHostForm : Form
    {
        public NetHostForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ON load of this form, the system checks and displays the local IP.  Wont work til we get a server running...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label7_Load(object sender, EventArgs e)
        {
            
           // var host = Dns.GetHostEntry(Dns.GetHostName());
           // foreach (var ip in host.AddressList)
           // {
             //   if (ip.AddressFamily == AddressFamily.InterNetwork)
              //  {
              //      label7.Text = ip.ToString();
            //    }
         //   }
         //   throw new Exception("Local IP Address Not Found!");
          }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var gameWindow = new Display();
            gameWindow.Show();
        }
    }
}
