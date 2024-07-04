namespace BankingGUI
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
            lstAccounts = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            SuspendLayout();
            // 
            // lstAccounts
            // 
            lstAccounts.FormattingEnabled = true;
            lstAccounts.ItemHeight = 28;
            lstAccounts.Location = new Point(52, 75);
            lstAccounts.Name = "lstAccounts";
            lstAccounts.Size = new Size(213, 144);
            lstAccounts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 37);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 1;
            label1.Text = "Select account:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 75);
            label2.Name = "label2";
            label2.Size = new Size(199, 28);
            label2.TabIndex = 2;
            label2.Text = "Enter money amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(536, 75);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(137, 34);
            txtAmount.TabIndex = 3;
            txtAmount.Tag = "Amount";
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(323, 131);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(121, 45);
            btnDeposit.TabIndex = 4;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(552, 131);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(121, 45);
            btnWithdraw.TabIndex = 5;
            btnWithdraw.Text = "&Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 269);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstAccounts);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banking";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAccounts;
        private Label label1;
        private Label label2;
        private TextBox txtAmount;
        private Button btnDeposit;
        private Button btnWithdraw;
    }
}
