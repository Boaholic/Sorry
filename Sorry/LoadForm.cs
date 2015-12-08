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
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void loadOne_Click(object sender, EventArgs e)
        {
            String location = Application.StartupPath;
            String filename = "save1.txt";
            String pathString = System.IO.Path.Combine(location, filename);
            //MessageBox.Show(pathString);
            if (System.IO.File.Exists(pathString))
            {
                MessageBox.Show("Game successfully loaded from " + pathString);
                this.Hide();
                var game = new Game();
                game.GameBegin();
            }
            else
            {
                MessageBox.Show("No save file exists in " + pathString);
            }
        }

        private void loadTwo_Click(object sender, EventArgs e)
        {
            String location = Application.StartupPath;
            String filename = "save2.txt";
            String pathString = System.IO.Path.Combine(location, filename);
            //MessageBox.Show(pathString);
            if (System.IO.File.Exists(pathString))
            {
                MessageBox.Show("Game successfully loaded from " + pathString);
                this.Hide();
                var game = new Game();
                game.GameBegin();
            }
            else
            {
                MessageBox.Show("No save file exists in " + pathString);
            }
        }

        private void loadThree_Click(object sender, EventArgs e)
        {
            String location = Application.StartupPath;
            String filename = "save3.txt";
            String pathString = System.IO.Path.Combine(location, filename);
            //MessageBox.Show(pathString);
            if (System.IO.File.Exists(pathString))
            {
                MessageBox.Show("Game successfully loaded from " + pathString);
                this.Hide();
                var game = new Game();
                game.GameBegin();
            }
            else
            {
                MessageBox.Show("No save file exists in " + pathString);
            }
        }

        private void loadFour_Click(object sender, EventArgs e)
        {
            String location = Application.StartupPath;
            String filename = "save4.txt";
            String pathString = System.IO.Path.Combine(location, filename);
            //MessageBox.Show(pathString);
            if (System.IO.File.Exists(pathString))
            {
                MessageBox.Show("Game successfully loaded from " + pathString);
                this.Hide();
                var game = new Game();
                game.GameBegin();
            }
            else
            {
                MessageBox.Show("No save file exists in " + pathString);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                foreach (Form thisForm in forms)
                {
                    thisForm.Close();
                }
            }
            e.Cancel = true;
        }


    }
}
