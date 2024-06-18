namespace IceCreamShop
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
            grpScoops = new GroupBox();
            radTriple = new RadioButton();
            radSingle = new RadioButton();
            radDouble = new RadioButton();
            grpOptions = new GroupBox();
            chkCone = new CheckBox();
            chkChocolate = new CheckBox();
            chkNuts = new CheckBox();
            chkFruit = new CheckBox();
            txtTotal = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSubmit = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpScoops.SuspendLayout();
            grpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // grpScoops
            // 
            grpScoops.Controls.Add(radTriple);
            grpScoops.Controls.Add(radSingle);
            grpScoops.Controls.Add(radDouble);
            grpScoops.Location = new Point(12, 12);
            grpScoops.Name = "grpScoops";
            grpScoops.Size = new Size(305, 126);
            grpScoops.TabIndex = 0;
            grpScoops.TabStop = false;
            grpScoops.Text = "Scoops";
            // 
            // radTriple
            // 
            radTriple.AutoSize = true;
            radTriple.Location = new Point(6, 90);
            radTriple.Name = "radTriple";
            radTriple.Size = new Size(113, 25);
            radTriple.TabIndex = 2;
            radTriple.TabStop = true;
            radTriple.Text = "Triple Scoop";
            radTriple.UseVisualStyleBackColor = true;
            // 
            // radSingle
            // 
            radSingle.AutoSize = true;
            radSingle.Location = new Point(6, 28);
            radSingle.Name = "radSingle";
            radSingle.Size = new Size(118, 25);
            radSingle.TabIndex = 0;
            radSingle.TabStop = true;
            radSingle.Text = "Single Scoop";
            radSingle.UseVisualStyleBackColor = true;
            // 
            // radDouble
            // 
            radDouble.AutoSize = true;
            radDouble.Location = new Point(6, 59);
            radDouble.Name = "radDouble";
            radDouble.Size = new Size(125, 25);
            radDouble.TabIndex = 1;
            radDouble.TabStop = true;
            radDouble.Text = "Double Scoop";
            radDouble.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(chkCone);
            grpOptions.Controls.Add(chkChocolate);
            grpOptions.Controls.Add(chkNuts);
            grpOptions.Controls.Add(chkFruit);
            grpOptions.Location = new Point(12, 144);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(305, 152);
            grpOptions.TabIndex = 0;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // chkCone
            // 
            chkCone.AutoSize = true;
            chkCone.Location = new Point(6, 28);
            chkCone.Name = "chkCone";
            chkCone.Size = new Size(105, 25);
            chkCone.TabIndex = 1;
            chkCone.Text = "Bowl/Cone";
            chkCone.UseVisualStyleBackColor = true;
            // 
            // chkChocolate
            // 
            chkChocolate.AutoSize = true;
            chkChocolate.Location = new Point(6, 59);
            chkChocolate.Name = "chkChocolate";
            chkChocolate.Size = new Size(98, 25);
            chkChocolate.TabIndex = 2;
            chkChocolate.Text = "Chocolate";
            chkChocolate.UseVisualStyleBackColor = true;
            // 
            // chkNuts
            // 
            chkNuts.AutoSize = true;
            chkNuts.Location = new Point(6, 90);
            chkNuts.Name = "chkNuts";
            chkNuts.Size = new Size(62, 25);
            chkNuts.TabIndex = 3;
            chkNuts.Text = "Nuts";
            chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkFruit
            // 
            chkFruit.AutoSize = true;
            chkFruit.Location = new Point(6, 121);
            chkFruit.Name = "chkFruit";
            chkFruit.Size = new Size(61, 25);
            chkFruit.TabIndex = 4;
            chkFruit.Text = "Fruit";
            chkFruit.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(88, 316);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(155, 29);
            txtTotal.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(87, 361);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(156, 29);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 318);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 5;
            label1.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 363);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 30);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(130, 409);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 30);
            btnReset.TabIndex = 8;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(242, 409);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 30);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 455);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(txtTotal);
            Controls.Add(grpOptions);
            Controls.Add(grpScoops);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ice Cream Shop";
            Load += Form1_Load;
            grpScoops.ResumeLayout(false);
            grpScoops.PerformLayout();
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpScoops;
        private RadioButton radTriple;
        private RadioButton radSingle;
        private RadioButton radDouble;
        private GroupBox grpOptions;
        private CheckBox chkCone;
        private CheckBox chkChocolate;
        private CheckBox chkNuts;
        private CheckBox chkFruit;
        private TextBox txtTotal;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btnSubmit;
        private Button btnReset;
        private Button btnExit;
    }
}
