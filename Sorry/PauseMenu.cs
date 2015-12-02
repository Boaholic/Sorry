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
    /// <summary>
    /// 
    /// </summary>
    public partial class PauseMenu : Form
    {
        Display gameWindow;
        /// <summary>
        /// 
        /// </summary>
        public PauseMenu(Display rootDisplay)
        {
            gameWindow = rootDisplay;
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            //add save game code here
        }

        /// <summary>
        /// 
        /// </summary>
        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult checkMessage = MessageBox.Show("Are you sure you want to quit the game?", "Are you sure?", MessageBoxButtons.YesNo);
            if(checkMessage == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (checkMessage == DialogResult.No)
            {
                //does nothing and returns to pause menu
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void endButton_Click(object sender, EventArgs e)
        {
            DialogResult checkMessage = MessageBox.Show("Are you sure you want to end the current game?", "Are you sure?", MessageBoxButtons.YesNo);
            if (checkMessage == DialogResult.Yes)
            {
                gameWindow.Close();
                this.Close();
                StartMenu newGame = new StartMenu();
                newGame.Show();
            }
            else if (checkMessage == DialogResult.No)
            {
                //does nothing and returns to pause menu
            }

            //add end game code here
        }

        /// <summary>
        /// 
        /// </summary>
        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
