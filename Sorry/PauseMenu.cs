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
            //add quit game code here
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            //add end game code here
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            //add resume game code here
        }
    }
}
