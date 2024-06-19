namespace TShirts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtBlack = new TextBox();
            txtWhite = new TextBox();
            txtRed = new TextBox();
            lblWinner = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(63, 9);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 5;
            label6.Text = "Black";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(63, 34);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 6;
            label7.Text = "White";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(63, 59);
            label8.Name = "label8";
            label8.Size = new Size(43, 25);
            label8.TabIndex = 7;
            label8.Text = "Red";
            // 
            // txtBlack
            // 
            txtBlack.BorderStyle = BorderStyle.FixedSingle;
            txtBlack.Location = new Point(149, 15);
            txtBlack.Name = "txtBlack";
            txtBlack.ReadOnly = true;
            txtBlack.Size = new Size(156, 23);
            txtBlack.TabIndex = 8;
            txtBlack.Tag = "Black";
            // 
            // txtWhite
            // 
            txtWhite.BorderStyle = BorderStyle.FixedSingle;
            txtWhite.Location = new Point(149, 40);
            txtWhite.Name = "txtWhite";
            txtWhite.ReadOnly = true;
            txtWhite.Size = new Size(156, 23);
            txtWhite.TabIndex = 9;
            txtWhite.Tag = "White";
            // 
            // txtRed
            // 
            txtRed.BorderStyle = BorderStyle.FixedSingle;
            txtRed.Location = new Point(149, 65);
            txtRed.Name = "txtRed";
            txtRed.ReadOnly = true;
            txtRed.Size = new Size(156, 23);
            txtRed.TabIndex = 10;
            txtRed.Tag = "Red";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWinner.Location = new Point(68, 96);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(38, 15);
            lblWinner.TabIndex = 11;
            lblWinner.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 132);
            Controls.Add(lblWinner);
            Controls.Add(txtRed);
            Controls.Add(txtWhite);
            Controls.Add(txtBlack);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtBlack;
        private TextBox txtWhite;
        private TextBox txtRed;
        private Label lblWinner;
    }
}
