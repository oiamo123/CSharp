namespace CustomerMaintenanceGUI
{
    partial class frmAddModifyCustomer
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
            txtZipCode = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            cboState = new ComboBox();
            SuspendLayout();
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(725, 292);
            txtZipCode.Margin = new Padding(4);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(274, 34);
            txtZipCode.TabIndex = 22;
            txtZipCode.Tag = "ZipCode";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(250, 213);
            txtCity.Margin = new Padding(4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(749, 34);
            txtCity.TabIndex = 20;
            txtCity.Tag = "City";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(249, 150);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(749, 34);
            txtAddress.TabIndex = 19;
            txtAddress.Tag = "Address";
            // 
            // txtName
            // 
            txtName.Location = new Point(249, 80);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(749, 34);
            txtName.TabIndex = 18;
            txtName.Tag = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(583, 292);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 17;
            label6.Text = "Zip Code:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 286);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 16;
            label5.Text = "State:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 219);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 15;
            label4.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 150);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 14;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 13;
            label2.Text = "Name:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(111, 373);
            btnAccept.Margin = new Padding(4);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(162, 49);
            btnAccept.TabIndex = 23;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(836, 373);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(162, 49);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboState
            // 
            cboState.FormattingEnabled = true;
            cboState.Location = new Point(249, 283);
            cboState.Name = "cboState";
            cboState.Size = new Size(255, 36);
            cboState.TabIndex = 25;
            cboState.Tag = "State";
            // 
            // frmAddModifyCustomer
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1068, 489);
            Controls.Add(cboState);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtZipCode);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAddModifyCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddModifyCustomer";
            Load += frmAddModifyCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtZipCode;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAccept;
        private Button btnCancel;
        private ComboBox cboState;
    }
}