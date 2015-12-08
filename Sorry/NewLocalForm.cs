﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorry;

namespace Sorry
{
    public partial class NewLocalForm : Form
    {
        public NewLocalForm()
        {
            InitializeComponent();
            boardchoice = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            boardchoice = 0;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            boardchoice = 1;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            boardchoice = 2;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int local;
            
            if(e.Equals("One"))
            {
                Console.Write("True");
            }
            
        }
        /// <summary>
        /// This launches the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var game = new Game(boardchoice);
            game.GameBegin();
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
                e.Cancel = true;
            }

        }

        private int boardchoice;

    }
}
