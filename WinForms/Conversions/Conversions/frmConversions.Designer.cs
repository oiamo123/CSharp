namespace Conversions
{
    partial class frmConversions
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
            txtFeet = new TextBox();
            txtInches = new TextBox();
            txtCentimeters = new TextBox();
            btnToMetric = new Button();
            btnToImperial = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 0;
            label1.Text = "Feet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 120);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "Inches:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 91);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Centimeters:";
            // 
            // txtFeet
            // 
            txtFeet.Location = new Point(153, 43);
            txtFeet.Name = "txtFeet";
            txtFeet.Size = new Size(126, 32);
            txtFeet.TabIndex = 3;
            txtFeet.Tag = "Feet";
            // 
            // txtInches
            // 
            txtInches.Location = new Point(153, 117);
            txtInches.Name = "txtInches";
            txtInches.Size = new Size(126, 32);
            txtInches.TabIndex = 4;
            txtInches.Tag = "Inches";
            // 
            // txtCentimeters
            // 
            txtCentimeters.Location = new Point(596, 88);
            txtCentimeters.Name = "txtCentimeters";
            txtCentimeters.Size = new Size(126, 32);
            txtCentimeters.TabIndex = 5;
            txtCentimeters.Tag = "Centimetres";
            // 
            // btnToMetric
            // 
            btnToMetric.Location = new Point(343, 36);
            btnToMetric.Name = "btnToMetric";
            btnToMetric.Size = new Size(83, 44);
            btnToMetric.TabIndex = 6;
            btnToMetric.Text = ">>";
            btnToMetric.UseVisualStyleBackColor = true;
            btnToMetric.Click += btnToMetric_Click;
            // 
            // btnToImperial
            // 
            btnToImperial.Location = new Point(343, 120);
            btnToImperial.Name = "btnToImperial";
            btnToImperial.Size = new Size(83, 44);
            btnToImperial.TabIndex = 7;
            btnToImperial.Text = "<<";
            btnToImperial.UseVisualStyleBackColor = true;
            btnToImperial.Click += btnToImperial_Click;
            // 
            // frmConversions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 214);
            Controls.Add(btnToImperial);
            Controls.Add(btnToMetric);
            Controls.Add(txtCentimeters);
            Controls.Add(txtInches);
            Controls.Add(txtFeet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "frmConversions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Length Conversions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFeet;
        private TextBox txtInches;
        private TextBox txtCentimeters;
        private Button btnToMetric;
        private Button btnToImperial;
    }
}
