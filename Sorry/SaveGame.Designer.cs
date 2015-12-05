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
    partial class SaveGame
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.saveButtonOne = new System.Windows.Forms.Button();
            this.saveButtonTwo = new System.Windows.Forms.Button();
            this.saveButtonThree = new System.Windows.Forms.Button();
            this.saveButtonFour = new System.Windows.Forms.Button();

            //
            // Save Button One
            //
            this.saveButtonOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButtonOne.BackColor = System.Drawing.Color.Transparent;
            this.saveButtonOne.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButtonOne.ForeColor = System.Drawing.Color.Black;
            this.saveButtonOne.Location = new System.Drawing.Point(25, 25);
            this.saveButtonOne.Name = "saveButtonOne";
            this.saveButtonOne.Size = new System.Drawing.Size(100, 50);
            this.saveButtonOne.TabIndex = 2;
            this.saveButtonOne.Visible = true;
            this.saveButtonOne.Text = "Save Slot 1";
            this.saveButtonOne.UseVisualStyleBackColor = false;
            this.saveButtonOne.Click += new System.EventHandler(this.saveButtonOne_Click);

            //
            // Save Button Two
            //
            this.saveButtonTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButtonTwo.BackColor = System.Drawing.Color.Transparent;
            this.saveButtonTwo.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButtonTwo.ForeColor = System.Drawing.Color.Black;
            this.saveButtonTwo.Location = new System.Drawing.Point(75, 25);
            this.saveButtonTwo.Name = "saveButtonTwo";
            this.saveButtonTwo.Size = new System.Drawing.Size(100, 50);
            this.saveButtonTwo.TabIndex = 3;
            this.saveButtonTwo.Visible = true;
            this.saveButtonTwo.Text = "Save Slot 2";
            this.saveButtonTwo.UseVisualStyleBackColor = false;
            this.saveButtonTwo.Click += new System.EventHandler(this.saveButtonTwo_Click);

            //
            // Save Button Three
            //
            this.saveButtonThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButtonThree.BackColor = System.Drawing.Color.Transparent;
            this.saveButtonThree.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButtonThree.ForeColor = System.Drawing.Color.Black;
            this.saveButtonThree.Location = new System.Drawing.Point(25, 125);
            this.saveButtonThree.Name = "saveButtonThree";
            this.saveButtonThree.Size = new System.Drawing.Size(100, 50);
            this.saveButtonThree.TabIndex = 4;
            this.saveButtonThree.Visible = true;
            this.saveButtonThree.Text = "Save Slot 3";
            this.saveButtonThree.UseVisualStyleBackColor = false;
            this.saveButtonThree.Click += new System.EventHandler(this.saveButtonThree_Click);

            //
            // Save Button Four
            //
            this.saveButtonFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButtonFour.BackColor = System.Drawing.Color.Transparent;
            this.saveButtonFour.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButtonFour.ForeColor = System.Drawing.Color.Black;
            this.saveButtonFour.Location = new System.Drawing.Point(75, 125);
            this.saveButtonFour.Name = "saveButtonFour";
            this.saveButtonFour.Size = new System.Drawing.Size(100, 50);
            this.saveButtonFour.TabIndex = 5;
            this.saveButtonFour.Visible = true;
            this.saveButtonFour.Text = "Save Slot 4";
            this.saveButtonFour.UseVisualStyleBackColor = false;
            this.saveButtonFour.Click += new System.EventHandler(this.saveButtonFour_Click);

            //
            // Save Menu
            //
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(saveButtonOne);
            this.Controls.Add(saveButtonTwo);
            this.Controls.Add(saveButtonThree);
            this.Controls.Add(saveButtonFour);
        }

        private System.Windows.Forms.Button saveButtonOne;
        private System.Windows.Forms.Button saveButtonTwo;
        private System.Windows.Forms.Button saveButtonThree;
        private System.Windows.Forms.Button saveButtonFour;
    }
}
