namespace FindMax
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(310, 334);
            button1.Name = "button1";
            button1.Size = new Size(189, 73);
            button1.TabIndex = 0;
            button1.Text = "Резултат";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 20);
            label1.TabIndex = 1;
            label1.Text = "Намиране на най-голямо число";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 48);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 2;
            label2.Text = "Въведете първо число";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 130);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 3;
            label3.Text = "Въведете второ число";
            // 
            // num1
            // 
            num1.Location = new Point(272, 71);
            num1.Name = "num1";
            num1.Size = new Size(278, 27);
            num1.TabIndex = 4;
            // 
            // num2
            // 
            num2.Location = new Point(272, 153);
            num2.Name = "num2";
            num2.Size = new Size(278, 27);
            num2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 246);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 223);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Резултат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox num1;
        private TextBox num2;
        private TextBox textBox3;
        private Label label4;
    }
}