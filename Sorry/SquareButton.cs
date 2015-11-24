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
        private Image displayImage { get; set; }

        private Game game;

        public SquareButton() :base()
        {
            Visible = true;
            //BackColor = Color.Transparent;
        }
          

        public void buttonPressed()
        {
            //game.SquareButtonPressed();
        }
    }
}
