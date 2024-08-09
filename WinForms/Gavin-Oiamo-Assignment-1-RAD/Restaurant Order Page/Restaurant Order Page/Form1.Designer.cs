namespace Restaurant_Order_Page
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
            boxMain = new GroupBox();
            radSalad = new RadioButton();
            radPizza = new RadioButton();
            radBurger = new RadioButton();
            boxAddOns = new GroupBox();
            chk3 = new CheckBox();
            chk2 = new CheckBox();
            chk1 = new CheckBox();
            boxTotal = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTotal = new TextBox();
            txtTax = new TextBox();
            txtSubTotal = new TextBox();
            btnSubmit = new Button();
            btnReset = new Button();
            label1 = new Label();
            btnExit = new Button();
            boxMain.SuspendLayout();
            boxAddOns.SuspendLayout();
            boxTotal.SuspendLayout();
            SuspendLayout();
            // 
            // boxMain
            // 
            boxMain.Controls.Add(radSalad);
            boxMain.Controls.Add(radPizza);
            boxMain.Controls.Add(radBurger);
            boxMain.Location = new Point(32, 19);
            boxMain.Margin = new Padding(2);
            boxMain.Name = "boxMain";
            boxMain.Padding = new Padding(2);
            boxMain.Size = new Size(176, 102);
            boxMain.TabIndex = 0;
            boxMain.TabStop = false;
            boxMain.Text = "Main Course";
            // 
            // radSalad
            // 
            radSalad.AutoSize = true;
            radSalad.Location = new Point(11, 78);
            radSalad.Margin = new Padding(2);
            radSalad.Name = "radSalad";
            radSalad.Size = new Size(91, 19);
            radSalad.TabIndex = 2;
            radSalad.TabStop = true;
            radSalad.Text = "Salad - $4.95";
            radSalad.UseVisualStyleBackColor = true;
            radSalad.CheckedChanged += radSalad_CheckedChanged;
            // 
            // radPizza
            // 
            radPizza.AutoSize = true;
            radPizza.Location = new Point(11, 52);
            radPizza.Margin = new Padding(2);
            radPizza.Name = "radPizza";
            radPizza.Size = new Size(89, 19);
            radPizza.TabIndex = 1;
            radPizza.TabStop = true;
            radPizza.Text = "Pizza - $5.95";
            radPizza.UseVisualStyleBackColor = true;
            radPizza.CheckedChanged += radPizza_CheckedChanged;
            // 
            // radBurger
            // 
            radBurger.AutoSize = true;
            radBurger.Location = new Point(11, 25);
            radBurger.Margin = new Padding(2);
            radBurger.Name = "radBurger";
            radBurger.Size = new Size(124, 19);
            radBurger.TabIndex = 0;
            radBurger.TabStop = true;
            radBurger.Text = "Hamburger - $6.95";
            radBurger.UseVisualStyleBackColor = true;
            radBurger.CheckedChanged += radBurger_CheckedChanged;
            // 
            // boxAddOns
            // 
            boxAddOns.Controls.Add(chk3);
            boxAddOns.Controls.Add(chk2);
            boxAddOns.Controls.Add(chk1);
            boxAddOns.Location = new Point(238, 19);
            boxAddOns.Margin = new Padding(2);
            boxAddOns.Name = "boxAddOns";
            boxAddOns.Padding = new Padding(2);
            boxAddOns.Size = new Size(254, 102);
            boxAddOns.TabIndex = 1;
            boxAddOns.TabStop = false;
            boxAddOns.Text = "Add-on-items";
            // 
            // chk3
            // 
            chk3.AutoSize = true;
            chk3.Location = new Point(15, 78);
            chk3.Margin = new Padding(2);
            chk3.Name = "chk3";
            chk3.Size = new Size(83, 19);
            chk3.TabIndex = 2;
            chk3.Text = "checkBox3";
            chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            chk2.AutoSize = true;
            chk2.Location = new Point(15, 52);
            chk2.Margin = new Padding(2);
            chk2.Name = "chk2";
            chk2.Size = new Size(83, 19);
            chk2.TabIndex = 1;
            chk2.Text = "checkBox2";
            chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.Location = new Point(15, 25);
            chk1.Margin = new Padding(2);
            chk1.Name = "chk1";
            chk1.Size = new Size(83, 19);
            chk1.TabIndex = 0;
            chk1.Text = "checkBox1";
            chk1.UseVisualStyleBackColor = true;
            // 
            // boxTotal
            // 
            boxTotal.Controls.Add(label4);
            boxTotal.Controls.Add(label3);
            boxTotal.Controls.Add(label2);
            boxTotal.Controls.Add(txtTotal);
            boxTotal.Controls.Add(txtTax);
            boxTotal.Controls.Add(txtSubTotal);
            boxTotal.Location = new Point(32, 133);
            boxTotal.Margin = new Padding(2);
            boxTotal.Name = "boxTotal";
            boxTotal.Padding = new Padding(2);
            boxTotal.Size = new Size(288, 122);
            boxTotal.TabIndex = 6;
            boxTotal.TabStop = false;
            boxTotal.Text = "Order Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 25);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 0;
            label4.Text = "Subtotal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 90);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Order Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Tax (5%):";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Control;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(116, 84);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(130, 27);
            txtTotal.TabIndex = 3;
            txtTotal.TabStop = false;
            // 
            // txtTax
            // 
            txtTax.BackColor = SystemColors.Control;
            txtTax.BorderStyle = BorderStyle.FixedSingle;
            txtTax.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTax.Location = new Point(116, 53);
            txtTax.Margin = new Padding(2);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(130, 27);
            txtTax.TabIndex = 2;
            txtTax.TabStop = false;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = SystemColors.Control;
            txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubTotal.Location = new Point(116, 22);
            txtSubTotal.Margin = new Padding(2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(130, 27);
            txtSubTotal.TabIndex = 1;
            txtSubTotal.TabStop = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Location = new Point(377, 140);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(115, 28);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Cursor = Cursors.Hand;
            btnReset.Location = new Point(377, 185);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(115, 28);
            btnReset.TabIndex = 4;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(377, 227);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 28);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(526, 281);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnSubmit);
            Controls.Add(boxTotal);
            Controls.Add(boxAddOns);
            Controls.Add(boxMain);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lunch Order";
            Load += Form1_Load;
            boxMain.ResumeLayout(false);
            boxMain.PerformLayout();
            boxAddOns.ResumeLayout(false);
            boxAddOns.PerformLayout();
            boxTotal.ResumeLayout(false);
            boxTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox boxMain;
        private GroupBox boxAddOns;
        private GroupBox boxTotal;
        private TextBox txtTotal;
        private TextBox txtTax;
        private TextBox txtSubTotal;
        private Button btnSubmit;
        private Button btnReset;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private RadioButton radSalad;
        private RadioButton radPizza;
        private RadioButton radBurger;
        private CheckBox chk3;
        private CheckBox chk2;
        private CheckBox chk1;
        private Button btnExit;
    }
}
