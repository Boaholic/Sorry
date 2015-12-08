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
    partial class PauseMenu
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ResumeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            //
            // Resume Button
            //
            this.ResumeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResumeButton.BackColor = System.Drawing.Color.Transparent;
            this.ResumeButton.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeButton.ForeColor = System.Drawing.Color.Black;
            this.ResumeButton.Location = new System.Drawing.Point(65, 10);
            this.ResumeButton.Name = "resumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(170, 50);
            this.ResumeButton.TabIndex = 1;
            this.ResumeButton.Visible = true;
            this.ResumeButton.Text = "Resume Game";
            this.ResumeButton.UseVisualStyleBackColor = false;
            this.ResumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            //
            // Cancel Button
            //
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(200, 230);
            this.CancelButton.Name = "cancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 50);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Visible = true;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            //
            // Save Button
            //
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(65, 70);
            this.SaveButton.Name = "saveButton";
            this.SaveButton.Size = new System.Drawing.Size(170, 50);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Visible = true;
            this.SaveButton.Text = "Save Game";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.saveButton_Click);
            //
            // Quit Button
            //
            this.QuitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.Black;
            this.QuitButton.Location = new System.Drawing.Point(65, 190);
            this.QuitButton.Name = "quitButton";
            this.QuitButton.Size = new System.Drawing.Size(170, 50);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Visible = true;
            this.QuitButton.Text = "Quit Game";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.quitButton_Click);
            //
            // End Button
            //
            this.EndButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndButton.BackColor = System.Drawing.Color.Transparent;
            this.EndButton.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndButton.ForeColor = System.Drawing.Color.Black;
            this.EndButton.Location = new System.Drawing.Point(65, 130);
            this.EndButton.Name = "endButton";
            this.EndButton.Size = new System.Drawing.Size(170, 50);
            this.EndButton.TabIndex = 3;
            this.EndButton.Visible = true;
            this.EndButton.Text = "End Game";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.endButton_Click);
            //
            // Pause Menu
            //
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Pause";
            //this.Controls.Add(CancelButton);
            this.Controls.Add(SaveButton);
            this.Controls.Add(QuitButton);
            this.Controls.Add(EndButton);
            this.Controls.Add(ResumeButton);
        }
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button EndButton;
    }
}
