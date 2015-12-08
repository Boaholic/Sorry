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
        /// Saves the game to a .txt file.
        /// If the game is already saved, it adds to the current file
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            //String location = Application.StartupPath;
            //String filename = "save.txt";
            //String pathString = System.IO.Path.Combine(location, filename);
            ////MessageBox.Show(pathString);
            //if (!System.IO.File.Exists(pathString))
            //{
            //    System.IO.File.Create(pathString).Dispose();
            //    System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
            //    tw.WriteLine("saving the game");
            //    tw.Close();
            //    MessageBox.Show("Saved the game to " + pathString);
            //}
            ////else if (System.IO.File.Exists(pathString))
            ////{
            ////    System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
            ////    tw.WriteLine("saving the game again!");
            ////    tw.Close();
            ////}
            SaveGame saveMenu = new SaveGame(gameWindow);
            saveMenu.Show();

        }

        /// <summary>
        /// Saves the current game to the file specified
        /// </summary>
        private void saveGame(System.IO.TextWriter tw)
        {

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
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
                //gameWindow.Close();
                //this.Close();
                //StartMenu newGame = new StartMenu();
                //newGame.Show();
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
