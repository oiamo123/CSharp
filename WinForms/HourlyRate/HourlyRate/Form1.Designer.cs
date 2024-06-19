namespace HourlyRate
{
    partial class hoursWorked
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtHrRate = new TextBox();
            txtHrsWorked = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            label3 = new Label();
            txtPay = new TextBox();
            grbDetails = new GroupBox();
            txtOtPay = new TextBox();
            txtRegularPay = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.money;
            pictureBox1.Location = new Point(47, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 216);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 1;
            label1.Text = "Hours Worked:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 266);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 2;
            label2.Text = "Hourly Rate:";
            // 
            // txtHrRate
            // 
            txtHrRate.Location = new Point(187, 263);
            txtHrRate.Name = "txtHrRate";
            txtHrRate.Size = new Size(115, 30);
            txtHrRate.TabIndex = 4;
            txtHrRate.Tag = "Hourly rate";
            // 
            // txtHrsWorked
            // 
            txtHrsWorked.Location = new Point(187, 213);
            txtHrsWorked.Name = "txtHrsWorked";
            txtHrsWorked.Size = new Size(115, 30);
            txtHrsWorked.TabIndex = 3;
            txtHrsWorked.Tag = "Hours worked";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(31, 310);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(103, 44);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Enter";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(199, 310);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 44);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 366);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 7;
            label3.Text = "Pay Amount:";
            // 
            // txtPay
            // 
            txtPay.Location = new Point(187, 366);
            txtPay.Name = "txtPay";
            txtPay.ReadOnly = true;
            txtPay.Size = new Size(115, 30);
            txtPay.TabIndex = 7;
            // 
            // grbDetails
            // 
            grbDetails.Controls.Add(txtOtPay);
            grbDetails.Controls.Add(txtRegularPay);
            grbDetails.Controls.Add(label5);
            grbDetails.Controls.Add(label4);
            grbDetails.Location = new Point(31, 421);
            grbDetails.Name = "grbDetails";
            grbDetails.Size = new Size(271, 132);
            grbDetails.TabIndex = 8;
            grbDetails.TabStop = false;
            grbDetails.Text = "Calculation Details";
            // 
            // txtOtPay
            // 
            txtOtPay.Location = new Point(138, 85);
            txtOtPay.Name = "txtOtPay";
            txtOtPay.Size = new Size(118, 30);
            txtOtPay.TabIndex = 3;
            // 
            // txtRegularPay
            // 
            txtRegularPay.Location = new Point(138, 35);
            txtRegularPay.Name = "txtRegularPay";
            txtRegularPay.Size = new Size(118, 30);
            txtRegularPay.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 85);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 1;
            label5.Text = "Overtime pay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 42);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 0;
            label4.Text = "Regular Pay:";
            // 
            // hoursWorked
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(330, 575);
            Controls.Add(grbDetails);
            Controls.Add(txtPay);
            Controls.Add(label3);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtHrsWorked);
            Controls.Add(txtHrRate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "hoursWorked";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hours Worked";
            Load += hoursWorked_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbDetails.ResumeLayout(false);
            grbDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtHrRate;
        private TextBox txtHrsWorked;
        private Button btnSubmit;
        private Button btnClear;
        private Label label3;
        private TextBox txtPay;
        private GroupBox grbDetails;
        private Label label5;
        private Label label4;
        private TextBox txtOtPay;
        private TextBox txtRegularPay;
    }
}
