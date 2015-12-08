using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorry
{
    public partial class SaveGame : Form
    {
        Display gameDisplay;

        public SaveGame(Display rootDisplay)
        {
            gameDisplay = rootDisplay;
            InitializeComponent();
        }

        private void saveButtonOne_Click(object sender, EventArgs e)
        {
            String location = Application.StartupPath;
            String filename = "save1.txt";
            String pathString = System.IO.Path.Combine(location, filename);
            //MessageBox.Show(pathString);
            if (!System.IO.File.Exists(pathString))
            {
                System.IO.File.Create(pathString).Dispose();
                System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
                foreach (List<SquareButton> listofButtons in gameDisplay.BoardButtons)
                {
                    foreach(SquareButton button in listofButtons)
                    {
                        tw.WriteLine(button.occupiedBy);
                    }
                }
                tw.WriteLine("saving game 1");
                tw.Close();
                MessageBox.Show("Saved the game to " + pathString);
            }
            else if (System.IO.File.Exists(pathString))
            {
                DialogResult checkMessage = MessageBox.Show("A game already exists in this save. Do you want to override it?", "Override Warning", MessageBoxButtons.YesNo);
                if (checkMessage == DialogResult.Yes)
                {
                    System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
                    foreach (List<SquareButton> listofButtons in gameDisplay.BoardButtons)
                    {
                        foreach (SquareButton button in listofButtons)
                        {
                            tw.WriteLine(button.occupiedBy);
                        }
                    }
                    tw.Close();
                    MessageBox.Show("Saved the game to " + pathString);
                }
                else if (checkMessage == DialogResult.No)
                {
                    //does nothing and returns to save menu
                }
            }

        }

        private void saveButtonTwo_Click(object sender, EventArgs e)
        {
            String location = Application.StartupPath;
            String filename = "save2.txt";
            String pathString = System.IO.Path.Combine(location, filename);
            //MessageBox.Show(pathString);
            if (!System.IO.File.Exists(pathString))
            {
                System.IO.File.Create(pathString).Dispose();
                System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
                foreach (List<SquareButton> listofButtons in gameDisplay.BoardButtons)
                {
                    foreach (SquareButton button in listofButtons)
                    {
                        tw.WriteLine(button.occupiedBy);
                    }
                }
                tw.Close();
                MessageBox.Show("Saved the game to " + pathString);
            }
            else if (System.IO.File.Exists(pathString))
            {
                DialogResult checkMessage = MessageBox.Show("A game already exists in this save. Do you want to override it?", "Override Warning", MessageBoxButtons.YesNo);
                if (checkMessage == DialogResult.Yes)
                {
                    System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
                    foreach (List<SquareButton> listofButtons in gameDisplay.BoardButtons)
                    {
                        foreach (SquareButton button in listofButtons)
                        {
                            tw.WriteLine(button.occupiedBy);
                        }
                    }
                    tw.Close();
                    MessageBox.Show("Saved the game to " + pathString);
                }
                else if (checkMessage == DialogResult.No)
                {
                    //does nothing and returns to save menu
                }
            }
        }

        private void saveButtonThree_Click(object sender, EventArgs e)
        {
            String location = Application.StartupPath;
            String filename = "save3.txt";
            String pathString = System.IO.Path.Combine(location, filename);
            //MessageBox.Show(pathString);
            if (!System.IO.File.Exists(pathString))
            {
                System.IO.File.Create(pathString).Dispose();
                System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
                foreach (List<SquareButton> listofButtons in gameDisplay.BoardButtons)
                {
                    foreach (SquareButton button in listofButtons)
                    {
                        tw.WriteLine(button.occupiedBy);
                    }
                }
                tw.Close();
                MessageBox.Show("Saved the game to " + pathString);
            }
            else if (System.IO.File.Exists(pathString))
            {
                DialogResult checkMessage = MessageBox.Show("A game already exists in this save. Do you want to override it?", "Override Warning", MessageBoxButtons.YesNo);
                if (checkMessage == DialogResult.Yes)
                {
                    System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
                    foreach (List<SquareButton> listofButtons in gameDisplay.BoardButtons)
                    {
                        foreach (SquareButton button in listofButtons)
                        {
                            tw.WriteLine(button.occupiedBy);
                        }
                    }
                    tw.Close();
                    MessageBox.Show("Saved the game to " + pathString);
                }
                else if (checkMessage == DialogResult.No)
                {
                    //does nothing and returns to save menu
                }
            }
        }

        private void saveButtonFour_Click(object sender, EventArgs e)
        {
            String location = Application.StartupPath;
            String filename = "save4.txt";
            String pathString = System.IO.Path.Combine(location, filename);
            //MessageBox.Show(pathString);
            if (!System.IO.File.Exists(pathString))
            {
                System.IO.File.Create(pathString).Dispose();
                System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
                foreach (List<SquareButton> listofButtons in gameDisplay.BoardButtons)
                {
                    foreach (SquareButton button in listofButtons)
                    {
                        tw.WriteLine(button.occupiedBy);
                    }
                }
                tw.Close();
                MessageBox.Show("Saved the game to " + pathString);
            }
            else if (System.IO.File.Exists(pathString))
            {
                DialogResult checkMessage = MessageBox.Show("A game already exists in this save. Do you want to override it?", "Override Warning", MessageBoxButtons.YesNo);
                if (checkMessage == DialogResult.Yes)
                {
                    System.IO.TextWriter tw = new System.IO.StreamWriter(pathString);
                    foreach (List<SquareButton> listofButtons in gameDisplay.BoardButtons)
                    {
                        foreach (SquareButton button in listofButtons)
                        {
                            tw.WriteLine(button.occupiedBy);
                        }
                    }
                    tw.Close();
                    MessageBox.Show("Saved the game to " + pathString);
                }
                else if (checkMessage == DialogResult.No)
                {
                    //does nothing and returns to save menu
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
