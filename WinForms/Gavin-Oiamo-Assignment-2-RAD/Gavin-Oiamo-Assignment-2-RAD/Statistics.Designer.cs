namespace Gavin_Oiamo_Assignment_2_RAD
{
    partial class Statistics
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
            btnExit = new Button();
            lstCustomers = new ListBox();
            btnViewMore = new Button();
            btnViewLess = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(570, 253);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(12, 11);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(553, 274);
            lstCustomers.TabIndex = 5;
            // 
            // btnViewMore
            // 
            btnViewMore.Font = new Font("Segoe UI", 12F);
            btnViewMore.Location = new Point(570, 11);
            btnViewMore.Margin = new Padding(2);
            btnViewMore.Name = "btnViewMore";
            btnViewMore.Size = new Size(121, 32);
            btnViewMore.TabIndex = 6;
            btnViewMore.Text = ">>>";
            btnViewMore.UseVisualStyleBackColor = true;
            btnViewMore.Click += btnViewMore_Click;
            // 
            // btnViewLess
            // 
            btnViewLess.Font = new Font("Segoe UI", 12F);
            btnViewLess.Location = new Point(570, 47);
            btnViewLess.Margin = new Padding(2);
            btnViewLess.Name = "btnViewLess";
            btnViewLess.Size = new Size(121, 32);
            btnViewLess.TabIndex = 7;
            btnViewLess.Text = "<<<";
            btnViewLess.UseVisualStyleBackColor = true;
            btnViewLess.Click += btnViewLess_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F);
            btnRemove.Location = new Point(570, 83);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(121, 32);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(701, 299);
            Controls.Add(btnRemove);
            Controls.Add(btnViewLess);
            Controls.Add(btnViewMore);
            Controls.Add(lstCustomers);
            Controls.Add(btnExit);
            Margin = new Padding(2);
            Name = "Statistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics";
            Load += Statistics_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private ListBox lstCustomers;
        private Button btnViewMore;
        private Button btnViewLess;
        private Button btnRemove;
    }
}