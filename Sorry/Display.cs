using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorry.Properties;

namespace Sorry
{
    class Display: Form
    {
        public Display()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            int boardTop=200, boardRight=50;
            BoardPicture = new Label();

            BoardPicture.Location= new System.Drawing.Point(boardTop, boardRight);
            BoardPicture.Size = new System.Drawing.Size(200, 200);
            Image boardPic = Resources.GameBoard;
            BoardPicture.Size = new Size(boardPic.Width, boardPic.Height); 
            BoardPicture.Image = boardPic;

            CardPicture = new Label();

            CardPicture.Location = new System.Drawing.Point(50, 50);
            CardPicture.Size = new System.Drawing.Size(200, 200);
            Image deckPic = Resources.Deck;
            CardPicture.Size = new Size(deckPic.Width, deckPic.Height);
            CardPicture.Image = deckPic;
            // 
            // GameDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 556);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Display";
            this.Text = "Sorry";
            this.ResumeLayout(false);
            this.Controls.Add(BoardPicture);
            this.Controls.Add(CardPicture);

            // 
            // Board
            // 
            BoardButtons = new List<Button>();
            int buttonNum = 16;
            for (int i = 0; i < buttonNum; i++)
            {
                BoardButtons.Add(new System.Windows.Forms.Button());

                BoardButtons[i].Location = new System.Drawing.Point(boardTop + i * 32, boardRight);
                BoardButtons[i].Name = "Square" + i;
                BoardButtons[i].Size = new System.Drawing.Size(32 , 32);
                BoardButtons[i].TabIndex = 0;
                //Board[i].Text = "Square" + i;
                BoardButtons[i].UseVisualStyleBackColor = true;
                this.Controls.Add(BoardButtons[i]);
            }
            BoardPicture.SendToBack();

        }

        private List<System.Windows.Forms.Button> BoardButtons;
        private Label BoardPicture;
        private Label CardPicture;


    }
}
