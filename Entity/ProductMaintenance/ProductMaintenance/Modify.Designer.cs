namespace ProductMaintenance
{
    partial class Modify
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            txtProdCode = new TextBox();
            txtName = new TextBox();
            txtVersion = new TextBox();
            dtpProdDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Product code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 73);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 118);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 2;
            label3.Text = "Version:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 163);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 3;
            label4.Text = "Release Date:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(167, 212);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(89, 38);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(271, 212);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 38);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtProdCode
            // 
            txtProdCode.Location = new Point(167, 22);
            txtProdCode.MaxLength = 10;
            txtProdCode.Name = "txtProdCode";
            txtProdCode.Size = new Size(163, 31);
            txtProdCode.TabIndex = 6;
            txtProdCode.KeyPress += txtProdCode_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 68);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 31);
            txtName.TabIndex = 7;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // txtVersion
            // 
            txtVersion.Location = new Point(167, 113);
            txtVersion.MaxLength = 4;
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(163, 31);
            txtVersion.TabIndex = 8;
            txtVersion.KeyPress += txtVersion_KeyPress;
            // 
            // dtpProdDate
            // 
            dtpProdDate.Location = new Point(167, 158);
            dtpProdDate.Name = "dtpProdDate";
            dtpProdDate.Size = new Size(300, 31);
            dtpProdDate.TabIndex = 10;
            // 
            // Modify
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(520, 279);
            Controls.Add(dtpProdDate);
            Controls.Add(txtVersion);
            Controls.Add(txtName);
            Controls.Add(txtProdCode);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Modify";
            Text = "Modify";
            Load += Modify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnOk;
        private Button btnCancel;
        private TextBox txtProdCode;
        private TextBox txtName;
        private TextBox txtVersion;
        private DateTimePicker dtpProdDate;
    }
}