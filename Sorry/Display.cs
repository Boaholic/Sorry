﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorry.Properties;

namespace Sorry
{
    /// <summary>
    /// Displays the GUI for the user to interact with
    /// Some of the code was taken from the autogenerated Form Code
    /// </summary>
    class Display: Form
    {
        public Display()
        {
            baseBoard = new Board();
            InitializeCardImageMap();
            InitializeComponent();
        }

        /// <summary>
        /// Renders the Current Game to the Board
        /// </summary>
        public void Render() {
            
        }
        /// <summary>
        /// Renders the card given on the UI
        /// </summary>
        /// <param name="toDisplay">The card to display</param>
        public void DisplayCard(Card toDisplay) {
            CardPicture.Image = CardImages[toDisplay.cardVal];

        }
        private void InitializeCardImageMap() {
            CardImages = new Dictionary<Card.VALUE, Image>();
            CardImages.Add(Card.VALUE.One, Resources.card01);
            CardImages.Add(Card.VALUE.TWO, Resources.card02);
            CardImages.Add(Card.VALUE.THREE, Resources.card03);
            CardImages.Add(Card.VALUE.FOUR, Resources.card04);
            CardImages.Add(Card.VALUE.FIVE, Resources.card05);
            CardImages.Add(Card.VALUE.SEVEN, Resources.card07);
            CardImages.Add(Card.VALUE.EIGHT, Resources.card08);
            CardImages.Add(Card.VALUE.TEN, Resources.card10);
            CardImages.Add(Card.VALUE.ELEVEN, Resources.card11);
            CardImages.Add(Card.VALUE.TWELVE, Resources.card12);
            CardImages.Add(Card.VALUE.SORRY, Resources.cardSorry);

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
        /// Initializes the compents of the Display
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            int boardRight = 200, boardTop = 50;

            BoardPicture = new PictureBox();
            BoardPicture.Location = new System.Drawing.Point(boardRight, boardTop);
            BoardPicture.Size = new System.Drawing.Size(200, 200);
            Image boardPic = Resources.GameBoard;
            BoardPicture.Size = new Size(boardPic.Width, boardPic.Height);
            BoardPicture.Image = boardPic;
            //
            // DeckButton
            //
            DeckButton = new Button();
            DeckButton.Location = new System.Drawing.Point(50, 50);
            DeckButton.Size = new System.Drawing.Size(200, 200);
            Image deckPic = Resources.Deck;
            DeckButton.Size = new Size(deckPic.Width, deckPic.Height);
            DeckButton.Image = deckPic;
            DeckButton.Click += new EventHandler(DeckButtonHit);
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
            this.Controls.Add(DeckButton);
            //
            // CardPicture
            // 
            CardPicture = new Label();
            CardPicture.Location = new System.Drawing.Point(50, 300);
            CardPicture.Size = new System.Drawing.Size(200, 200);
            CardPicture.Size = new Size(deckPic.Width, deckPic.Height);
            CardPicture.Image = deckPic;
            this.Controls.Add(CardPicture);

            // 
            // Board
            // 
            BoardButtons = new List<List<SquareButton>>();
            int buttonSize = 31;
            for (int i = 0; i < baseBoard.board.Length; i++)
            {
                BoardButtons.Add(new List<SquareButton>());
                for (int j = 0; j < baseBoard.board[i].Length; j++)
                {

                    int buttonT = boardTop, buttonR = boardRight,jrfactor=0,jtfactor=0;
                    if (baseBoard.board.Length / 4 > i) {   //top line, Red
                        buttonR=boardRight + i * buttonSize;
                        buttonT = boardTop;
                        jtfactor = 1;
                    }
                    else if (baseBoard.board.Length / 2 > i) { //right line, blue
                        buttonR = boardRight + (baseBoard.board.Length / 4 * buttonSize);
                        buttonT = boardTop + i % 15 * buttonSize;
                        jrfactor = -1;
                    }
                    else if (baseBoard.board.Length * 3 / 4 > i) { //bottom line, yellow
                        buttonR=boardRight + ((baseBoard.board.Length / 4) - i % 15) * buttonSize;
                        buttonT=boardTop + baseBoard.board.Length / 4 * buttonSize;
                        jtfactor = -1;
                    }
                    else {  //left line, green
                        buttonT = boardTop + ((baseBoard.board.Length / 4) - i % 15) * buttonSize;
                        buttonR = boardRight;
                        jrfactor = 1;
                    }
                    BoardButtons[i].Add(new SquareButton());
                    BoardButtons[i][j].Location = new System.Drawing.Point(buttonR+jrfactor*j*32-196, buttonT+ jtfactor * j * buttonSize-45);
                    BoardButtons[i][j].Name = "Square" + i;
                    BoardButtons[i][j].Size = new System.Drawing.Size(buttonSize, buttonSize);
                    BoardButtons[i][j].TabIndex = 0;
                    //Board[i].Text = "Square" + i;
                    BoardButtons[i][j].UseVisualStyleBackColor = true;
                    this.Controls.Add(BoardButtons[i][j]);
                    BoardButtons[i][j].Parent = BoardPicture;
                    BoardButtons[i][j].BackColor = Color.Transparent;

                }

            }

            BoardPicture.SendToBack();

        }

        /// <summary>
        /// Function to test if DisplayCard Works, will not be in final product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeckButtonHit(object sender, EventArgs e) {
            Deck deck = new Deck();
            Card toDisplay = deck.DrawCard();
            DisplayCard(toDisplay);
        }


        private List<List<SquareButton>> BoardButtons;
        private Board baseBoard;
        private PictureBox BoardPicture;
        private Label CardPicture;
        private Button DeckButton;
        private Game parentGame;
        private Image BoardImage;
        private List<Image> pawnImages;
        private Dictionary<Card.VALUE,Image> CardImages;




    }
}
