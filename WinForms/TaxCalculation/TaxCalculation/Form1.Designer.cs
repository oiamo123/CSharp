namespace TaxCalculation
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
            txtSalary = new TextBox();
            txtTaxes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSubmit = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(66, 12);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(127, 23);
            txtSalary.TabIndex = 0;
            // 
            // txtTaxes
            // 
            txtTaxes.BorderStyle = BorderStyle.FixedSingle;
            txtTaxes.Location = new Point(66, 41);
            txtTaxes.Name = "txtTaxes";
            txtTaxes.ReadOnly = true;
            txtTaxes.Size = new Size(127, 23);
            txtTaxes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Salary:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 43);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Taxed:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(9, 82);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(82, 30);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(111, 82);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 30);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 123);
            Controls.Add(btnReset);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTaxes);
            Controls.Add(txtSalary);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tax Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSalary;
        private TextBox txtTaxes;
        private Label label1;
        private Label label2;
        private Button btnSubmit;
        private Button btnReset;
    }
}
