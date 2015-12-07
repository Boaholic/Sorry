using Sorry.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorry
{
    partial class SquareButton : System.Windows.Forms.Button
    {
        private int boardLocationX { get; set; }
        private int boardLocationY { get; set; }
        public Square parentSquare;

        public SquareButton(Square pS) :base()
        {
            Visible = true;
            parentSquare = pS;
            //BackColor = Color.Transparent;
        }


        /// <summary>
        /// Upadte the BackGround Image to be what the parent square is
        /// whether it contains a pawn or not
        /// </summary>
        public void  UpdateBackgroundImage()
        {

            if (parentSquare.IsOccupied() != null)
            {
                switch (parentSquare.IsOccupied().ownerPlayer)
                {
                    case 0:
                        BackgroundImage = Resources.pawnRed;
                        break;
                    case 1:
                        BackgroundImage = Resources.pawnBlue;
                        break;
                    case 2:
                        BackgroundImage = Resources.pawnYellow;
                        break;
                    case 3:
                        BackgroundImage = Resources.pawnGreen;
                        break;
                }
            }
            else
                BackgroundImage = null;
        }
    }
}
