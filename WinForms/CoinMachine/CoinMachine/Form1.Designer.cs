namespace CoinMachine
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
            txtChange = new TextBox();
            btnSubmit = new Button();
            label2 = new Label();
            txtToonies = new TextBox();
            label3 = new Label();
            txtLoonies = new TextBox();
            txtQuarters = new TextBox();
            label4 = new Label();
            txtDimes = new TextBox();
            label5 = new Label();
            txtNickels = new TextBox();
            label6 = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Change:";
            // 
            // txtChange
            // 
            txtChange.Location = new Point(84, 22);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(100, 23);
            txtChange.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(27, 51);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Toonies:";
            // 
            // txtToonies
            // 
            txtToonies.BorderStyle = BorderStyle.FixedSingle;
            txtToonies.Location = new Point(84, 82);
            txtToonies.Name = "txtToonies";
            txtToonies.ReadOnly = true;
            txtToonies.Size = new Size(100, 23);
            txtToonies.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Loonies:";
            // 
            // txtLoonies
            // 
            txtLoonies.BorderStyle = BorderStyle.FixedSingle;
            txtLoonies.Location = new Point(84, 111);
            txtLoonies.Name = "txtLoonies";
            txtLoonies.ReadOnly = true;
            txtLoonies.Size = new Size(100, 23);
            txtLoonies.TabIndex = 6;
            // 
            // txtQuarters
            // 
            txtQuarters.BorderStyle = BorderStyle.FixedSingle;
            txtQuarters.Location = new Point(84, 140);
            txtQuarters.Name = "txtQuarters";
            txtQuarters.ReadOnly = true;
            txtQuarters.Size = new Size(100, 23);
            txtQuarters.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 143);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Quarters:";
            // 
            // txtDimes
            // 
            txtDimes.BorderStyle = BorderStyle.FixedSingle;
            txtDimes.Location = new Point(84, 169);
            txtDimes.Name = "txtDimes";
            txtDimes.ReadOnly = true;
            txtDimes.Size = new Size(100, 23);
            txtDimes.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 172);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "Dime:";
            // 
            // txtNickels
            // 
            txtNickels.BorderStyle = BorderStyle.FixedSingle;
            txtNickels.Location = new Point(84, 198);
            txtNickels.Name = "txtNickels";
            txtNickels.ReadOnly = true;
            txtNickels.Size = new Size(100, 23);
            txtNickels.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 201);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Nickel:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(108, 51);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 243);
            Controls.Add(btnReset);
            Controls.Add(txtNickels);
            Controls.Add(label6);
            Controls.Add(txtDimes);
            Controls.Add(label5);
            Controls.Add(txtQuarters);
            Controls.Add(label4);
            Controls.Add(txtLoonies);
            Controls.Add(label3);
            Controls.Add(txtToonies);
            Controls.Add(label2);
            Controls.Add(btnSubmit);
            Controls.Add(txtChange);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtChange;
        private Button btnSubmit;
        private Label label2;
        private TextBox txtToonies;
        private Label label3;
        private TextBox txtLoonies;
        private TextBox txtQuarters;
        private Label label4;
        private TextBox txtDimes;
        private Label label5;
        private TextBox txtNickels;
        private Label label6;
        private Button btnReset;
    }
}
