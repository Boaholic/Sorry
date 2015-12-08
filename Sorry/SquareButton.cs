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
    public partial class SquareButton : System.Windows.Forms.Button
    {
        public int occupiedBy = 0;
        //0 for nobody, 1 for red, 2 for blue, 3 for yellow, 4 for green
        private int boardLocationX { get; set; }
        private int boardLocationY { get; set; }
        public Square parentSquare;

        public SquareButton(Square pS) :base()
        {
            occupiedBy = 0;
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
                switch (occupiedBy)
                {
                    case 1:
                        BackgroundImage = Resources.pawnRed;
                        break;
                    case 2:
                        BackgroundImage = Resources.pawnBlue;
                        break;
                    case 3:
                        BackgroundImage = Resources.pawnYellow;
                        break;
                    case 4:
                        BackgroundImage = Resources.pawnGreen;
                        break;
                }
            }
            else
                BackgroundImage = null;
        }
    }
}
