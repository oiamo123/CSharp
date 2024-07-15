namespace CustomerMaintenanceGUI
{
    partial class frmCustomerMaintenance
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
            txtCustomerID = new TextBox();
            btnGetCustomer = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZipCode = new TextBox();
            btnAdd = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label7 = new Label();
            dgvInvoices = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 42);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 0;
            label1.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(196, 39);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(108, 34);
            txtCustomerID.TabIndex = 1;
            txtCustomerID.Tag = "Customer ID";
            // 
            // btnGetCustomer
            // 
            btnGetCustomer.Location = new Point(348, 39);
            btnGetCustomer.Name = "btnGetCustomer";
            btnGetCustomer.Size = new Size(153, 36);
            btnGetCustomer.TabIndex = 2;
            btnGetCustomer.Text = "&Get Customer";
            btnGetCustomer.UseVisualStyleBackColor = true;
            btnGetCustomer.Click += btnGetCustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 119);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 181);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 246);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 5;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 305);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 6;
            label5.Text = "State:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 305);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 7;
            label6.Text = "Zip Code:";
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 119);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(546, 34);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(161, 181);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(546, 34);
            txtAddress.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(161, 243);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(546, 34);
            txtCity.TabIndex = 10;
            // 
            // txtState
            // 
            txtState.Location = new Point(161, 302);
            txtState.Name = "txtState";
            txtState.ReadOnly = true;
            txtState.Size = new Size(196, 34);
            txtState.TabIndex = 11;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(507, 305);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.ReadOnly = true;
            txtZipCode.Size = new Size(200, 34);
            txtZipCode.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(61, 378);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 39);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(223, 378);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(134, 39);
            btnModify.TabIndex = 14;
            btnModify.Text = "&Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(382, 378);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 39);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(573, 378);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(134, 39);
            btnExit.TabIndex = 16;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(777, 47);
            label7.Name = "label7";
            label7.Size = new Size(188, 28);
            label7.TabIndex = 17;
            label7.Text = "Customer's Invoices:";
            // 
            // dgvInvoices
            // 
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(779, 109);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.Size = new Size(624, 311);
            dgvInvoices.TabIndex = 18;
            // 
            // frmCustomerMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 469);
            Controls.Add(dgvInvoices);
            Controls.Add(label7);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(txtZipCode);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGetCustomer);
            Controls.Add(txtCustomerID);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCustomerMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Maintenance";
            Load += frmCustomerMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerID;
        private Button btnGetCustomer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZipCode;
        private Button btnAdd;
        private Button btnModify;
        private Button btnDelete;
        private Button btnExit;
        private Label label7;
        private DataGridView dgvInvoices;
    }
}
