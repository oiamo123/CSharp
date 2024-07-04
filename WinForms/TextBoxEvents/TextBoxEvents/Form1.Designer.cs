namespace TextBoxEvents
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(67, 72);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 0;
            label1.Text = "Enter Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.Location = new Point(242, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(539, 45);
            txtName.TabIndex = 1;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(67, 150);
            label2.Name = "label2";
            label2.Size = new Size(503, 38);
            label2.TabIndex = 2;
            label2.Text = "Postal Code (6 Characters like A1A1A1):";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(568, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 45);
            textBox1.TabIndex = 3;
            textBox1.Validating += textBox1_Validating;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 254);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox textBox1;
    }
}
