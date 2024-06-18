namespace ChickenOrEgg
{
    partial class FrmQuestion
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
            picAnswer = new PictureBox();
            groupBox1 = new GroupBox();
            radEgg = new RadioButton();
            radChicken = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)picAnswer).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // picAnswer
            // 
            picAnswer.Location = new Point(306, 40);
            picAnswer.Name = "picAnswer";
            picAnswer.Size = new Size(184, 247);
            picAnswer.SizeMode = PictureBoxSizeMode.Zoom;
            picAnswer.TabIndex = 0;
            picAnswer.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radEgg);
            groupBox1.Controls.Add(radChicken);
            groupBox1.Location = new Point(35, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(198, 141);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "What was first?";
            // 
            // radEgg
            // 
            radEgg.AutoSize = true;
            radEgg.Location = new Point(53, 76);
            radEgg.Name = "radEgg";
            radEgg.Size = new Size(57, 27);
            radEgg.TabIndex = 1;
            radEgg.TabStop = true;
            radEgg.Text = "Egg";
            radEgg.UseVisualStyleBackColor = true;
            radEgg.CheckedChanged += radEgg_CheckedChanged;
            // 
            // radChicken
            // 
            radChicken.AutoSize = true;
            radChicken.Location = new Point(53, 43);
            radChicken.Name = "radChicken";
            radChicken.Size = new Size(88, 27);
            radChicken.TabIndex = 0;
            radChicken.TabStop = true;
            radChicken.Text = "Chicken";
            radChicken.UseVisualStyleBackColor = true;
            radChicken.CheckedChanged += radChicken_CheckedChanged;
            // 
            // FrmQuestion
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(502, 342);
            Controls.Add(groupBox1);
            Controls.Add(picAnswer);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmQuestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Important Question";
            ((System.ComponentModel.ISupportInitialize)picAnswer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picAnswer;
        private GroupBox groupBox1;
        private RadioButton radEgg;
        private RadioButton radChicken;
    }
}
