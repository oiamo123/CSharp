namespace ProductMaintenance
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lstProducts = new ListBox();
            btnAdd = new Button();
            btnModify = new Button();
            btnRemove = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 25);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 25);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Version";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 25);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 3;
            label4.Text = "Release Date";
            // 
            // lstProducts
            // 
            lstProducts.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 22;
            lstProducts.Location = new Point(34, 53);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(703, 246);
            lstProducts.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Location = new Point(34, 337);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = SystemColors.Control;
            btnModify.Location = new Point(170, 337);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(112, 39);
            btnModify.TabIndex = 6;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.Control;
            btnRemove.Location = new Point(308, 337);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 39);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Control;
            btnExit.Location = new Point(625, 337);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 39);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            CancelButton = btnExit;
            ClientSize = new Size(793, 393);
            Controls.Add(btnExit);
            Controls.Add(btnRemove);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(lstProducts);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Product Maintenance";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstProducts;
        private Button btnAdd;
        private Button btnModify;
        private Button btnRemove;
        private Button btnExit;
    }
}
