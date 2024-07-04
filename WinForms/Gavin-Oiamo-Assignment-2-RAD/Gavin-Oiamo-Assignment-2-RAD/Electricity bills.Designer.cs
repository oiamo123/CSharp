namespace Gavin_Oiamo_Assignment_2_RAD
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
            btnSubmit = new Button();
            gbxCustData = new GroupBox();
            txtKwh = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnReset = new Button();
            btnExit = new Button();
            btnStats = new Button();
            gbxCustData.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F);
            btnSubmit.Location = new Point(20, 308);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(173, 53);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // gbxCustData
            // 
            gbxCustData.Controls.Add(txtKwh);
            gbxCustData.Controls.Add(txtLastName);
            gbxCustData.Controls.Add(txtFirstName);
            gbxCustData.Controls.Add(label3);
            gbxCustData.Controls.Add(label2);
            gbxCustData.Controls.Add(label1);
            gbxCustData.Controls.Add(btnReset);
            gbxCustData.Controls.Add(btnSubmit);
            gbxCustData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxCustData.Location = new Point(11, 12);
            gbxCustData.Name = "gbxCustData";
            gbxCustData.Size = new Size(567, 378);
            gbxCustData.TabIndex = 2;
            gbxCustData.TabStop = false;
            gbxCustData.Text = "Customer data";
            // 
            // txtKwh
            // 
            txtKwh.Font = new Font("Segoe UI", 14F);
            txtKwh.Location = new Point(194, 203);
            txtKwh.MaxLength = 6;
            txtKwh.Name = "txtKwh";
            txtKwh.Size = new Size(348, 45);
            txtKwh.TabIndex = 8;
            txtKwh.KeyPress += txtKwh_KeyPress;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(194, 143);
            txtLastName.MaxLength = 12;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(348, 45);
            txtLastName.TabIndex = 7;
            txtLastName.KeyPress += txtLastName_KeyPress;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.Location = new Point(194, 83);
            txtFirstName.MaxLength = 12;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(348, 45);
            txtFirstName.TabIndex = 6;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(20, 202);
            label3.Name = "label3";
            label3.Size = new Size(146, 38);
            label3.TabIndex = 5;
            label3.Text = "kWh used:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(20, 143);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(20, 87);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 3;
            label1.Text = "First Name:";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F);
            btnReset.Location = new Point(389, 308);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(173, 53);
            btnReset.TabIndex = 3;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(406, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 53);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStats
            // 
            btnStats.Font = new Font("Segoe UI", 12F);
            btnStats.Location = new Point(16, 397);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(173, 53);
            btnStats.TabIndex = 4;
            btnStats.Text = "&View Stats.";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(591, 465);
            Controls.Add(btnStats);
            Controls.Add(btnExit);
            Controls.Add(gbxCustData);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Electricity Bills";
            gbxCustData.ResumeLayout(false);
            gbxCustData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSubmit;
        private GroupBox gbxCustData;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnReset;
        private TextBox txtKwh;
        private TextBox txtLastName;
        private Button btnExit;
        private Button btnStats;
    }
}
