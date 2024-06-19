namespace Temperatures
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
            txtTemp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAvg = new TextBox();
            label3 = new Label();
            txtHigh = new TextBox();
            label4 = new Label();
            txtLow = new TextBox();
            label5 = new Label();
            txtDays = new TextBox();
            btnSubmit = new Button();
            groupBox1 = new GroupBox();
            groupbox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupbox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(116, 22);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(122, 23);
            txtTemp.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Temperature:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 25);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Avg Temp:";
            // 
            // txtAvg
            // 
            txtAvg.Location = new Point(116, 22);
            txtAvg.Name = "txtAvg";
            txtAvg.Size = new Size(122, 23);
            txtAvg.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 54);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Highest Temp:";
            // 
            // txtHigh
            // 
            txtHigh.Location = new Point(116, 51);
            txtHigh.Name = "txtHigh";
            txtHigh.Size = new Size(122, 23);
            txtHigh.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 83);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "Lowest Temp:";
            // 
            // txtLow
            // 
            txtLow.Location = new Point(116, 80);
            txtLow.Name = "txtLow";
            txtLow.Size = new Size(122, 23);
            txtLow.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 112);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "# of days:";
            // 
            // txtDays
            // 
            txtDays.Location = new Point(116, 109);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(122, 23);
            txtDays.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(53, 60);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(144, 30);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTemp);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 105);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add new temperature";
            // 
            // groupbox2
            // 
            groupbox2.Controls.Add(txtAvg);
            groupbox2.Controls.Add(label2);
            groupbox2.Controls.Add(txtHigh);
            groupbox2.Controls.Add(label5);
            groupbox2.Controls.Add(label3);
            groupbox2.Controls.Add(txtDays);
            groupbox2.Controls.Add(txtLow);
            groupbox2.Controls.Add(label4);
            groupbox2.Location = new Point(17, 123);
            groupbox2.Name = "groupbox2";
            groupbox2.Size = new Size(248, 146);
            groupbox2.TabIndex = 12;
            groupbox2.TabStop = false;
            groupbox2.Text = "Average";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 283);
            Controls.Add(groupbox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupbox2.ResumeLayout(false);
            groupbox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTemp;
        private Label label1;
        private Label label2;
        private TextBox txtAvg;
        private Label label3;
        private TextBox txtHigh;
        private Label label4;
        private TextBox txtLow;
        private Label label5;
        private TextBox txtDays;
        private Button btnSubmit;
        private GroupBox groupBox1;
        private GroupBox groupbox2;
    }
}
