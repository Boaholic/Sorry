namespace Sorry
{
    partial class LoadForm
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.loadButtonOne = new System.Windows.Forms.Button();
            this.loadButtonTwo = new System.Windows.Forms.Button();
            this.loadButtonThree = new System.Windows.Forms.Button();
            this.loadButtonFour = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loadButtonOne);
            this.panel1.Controls.Add(this.loadButtonTwo);
            this.panel1.Controls.Add(this.loadButtonThree);
            this.panel1.Controls.Add(this.loadButtonFour);
            this.panel1.Location = new System.Drawing.Point(73, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 310);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.backButton.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(133, 250);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(165, 50);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saved Games:";
            //
            // Load Button One
            //
            this.loadButtonOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadButtonOne.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButtonOne.Location = new System.Drawing.Point(90, 50);
            this.loadButtonOne.Name = "loadButtonOne";
            this.loadButtonOne.Size = new System.Drawing.Size(250, 50);
            this.loadButtonOne.TabIndex = 2;
            this.loadButtonOne.Visible = true;
            this.loadButtonOne.Text = "Load Save One";
            this.loadButtonOne.BackColor = System.Drawing.Color.Transparent;
            this.loadButtonOne.ForeColor = System.Drawing.Color.Black;
            this.loadButtonOne.UseVisualStyleBackColor = true;
            this.loadButtonOne.Click += new System.EventHandler(loadOne_Click);
            //
            // Load Button Two
            //
            this.loadButtonTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadButtonTwo.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButtonTwo.Location = new System.Drawing.Point(90, 100);
            this.loadButtonTwo.Name = "loadButtonTwo";
            this.loadButtonTwo.Size = new System.Drawing.Size(250, 50);
            this.loadButtonTwo.TabIndex = 2;
            this.loadButtonTwo.Visible = true;
            this.loadButtonTwo.Text = "Load Save Two";
            this.loadButtonTwo.BackColor = System.Drawing.Color.Transparent;
            this.loadButtonTwo.ForeColor = System.Drawing.Color.Black;
            this.loadButtonTwo.UseVisualStyleBackColor = true;
            this.loadButtonTwo.Click += new System.EventHandler(loadTwo_Click);
            //
            // Load Button Three
            //
            this.loadButtonThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadButtonThree.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButtonThree.Location = new System.Drawing.Point(90, 150);
            this.loadButtonThree.Name = "loadButtonThree";
            this.loadButtonThree.Size = new System.Drawing.Size(250, 50);
            this.loadButtonThree.TabIndex = 2;
            this.loadButtonThree.Visible = true;
            this.loadButtonThree.Text = "Load Save Three";
            this.loadButtonThree.BackColor = System.Drawing.Color.Transparent;
            this.loadButtonThree.ForeColor = System.Drawing.Color.Black;
            this.loadButtonThree.UseVisualStyleBackColor = true;
            this.loadButtonThree.Click += new System.EventHandler(loadThree_Click);
            //
            // Load Button Four
            //
            this.loadButtonFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadButtonFour.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButtonFour.Location = new System.Drawing.Point(90, 200);
            this.loadButtonFour.Name = "loadButtonFour";
            this.loadButtonFour.Size = new System.Drawing.Size(250, 50);
            this.loadButtonFour.TabIndex = 2;
            this.loadButtonFour.Visible = true;
            this.loadButtonFour.Text = "Load Save Four";
            this.loadButtonFour.BackColor = System.Drawing.Color.Transparent;
            this.loadButtonFour.ForeColor = System.Drawing.Color.Black;
            this.loadButtonFour.UseVisualStyleBackColor = true;
            this.loadButtonFour.Click += new System.EventHandler(loadFour_Click);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(590, 394);
            this.Controls.Add(this.panel1);
            this.Name = "LoadForm";
            this.Text = "Saved Games";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loadButtonOne;
        private System.Windows.Forms.Button loadButtonTwo;
        private System.Windows.Forms.Button loadButtonThree;
        private System.Windows.Forms.Button loadButtonFour;
        private System.Windows.Forms.Button backButton;
    }
}