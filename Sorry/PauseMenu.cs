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
    public partial class PauseMenu : Form
    {
        public PauseMenu()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //add save game code here
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult checkMessage = MessageBox.Show("Are you sure you want to quit the game?", "Are you sure?", MessageBoxButtons.YesNo);
            if(checkMessage == DialogResult.Yes)
            {
                MessageBox.Show("Quitting!"); //replace with quitting code
            }
            else if (checkMessage == DialogResult.No)
            {
                //do nothing
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            //add end game code here
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
