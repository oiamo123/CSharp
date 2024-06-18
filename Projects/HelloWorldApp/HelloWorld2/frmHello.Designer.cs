namespace HelloWorld2
{
    partial class frmHello
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
            lblGreeting = new Label();
            btnGreet = new Button();
            txtName = new TextBox();
            lblName = new Label();
            btnReset = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblGreeting
            // 
            lblGreeting.BorderStyle = BorderStyle.Fixed3D;
            lblGreeting.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGreeting.ForeColor = Color.Black;
            lblGreeting.Location = new Point(123, 20);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(464, 110);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "Hello World";
            lblGreeting.TextAlign = ContentAlignment.MiddleCenter;
            lblGreeting.Click += label1_Click;
            // 
            // btnGreet
            // 
            btnGreet.Location = new Point(123, 218);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(165, 29);
            btnGreet.TabIndex = 1;
            btnGreet.Text = "&Submit";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += btnGreet_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(301, 157);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 29);
            txtName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Location = new Point(123, 160);
            lblName.Name = "lblName";
            lblName.Size = new Size(134, 21);
            lblName.TabIndex = 3;
            lblName.Text = "Enter your name:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(422, 218);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(165, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(422, 253);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmHello
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 421);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnGreet);
            Controls.Add(lblGreeting);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmHello";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGreeting;
        private Button btnGreet;
        private TextBox txtName;
        private Label lblName;
        private Button btnReset;
        private Button btnExit;
    }
}
