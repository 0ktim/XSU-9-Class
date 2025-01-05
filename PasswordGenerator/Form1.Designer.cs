namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            lbPassGen = new Label();
            cbDigit = new CheckBox();
            cbLowerCase = new CheckBox();
            cbUpperCase = new CheckBox();
            cbSymbol = new CheckBox();
            btnGenerate = new Button();
            lbFront = new Label();
            lbPassword = new Label();
            btnCopyToClipboard = new Button();
            btnSaveFile = new Button();
            tbLenght = new TextBox();
            lbLenght = new Label();
            saveFileDialog = new SaveFileDialog();
            lbStrength = new Label();
            SuspendLayout();
            // 
            // lbPassGen
            // 
            lbPassGen.AutoSize = true;
            lbPassGen.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassGen.Location = new Point(470, 19);
            lbPassGen.Name = "lbPassGen";
            lbPassGen.Size = new Size(301, 34);
            lbPassGen.TabIndex = 0;
            lbPassGen.Text = "Password Generator";
            // 
            // cbDigit
            // 
            cbDigit.AutoSize = true;
            cbDigit.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            cbDigit.Location = new Point(12, 36);
            cbDigit.Name = "cbDigit";
            cbDigit.Size = new Size(124, 40);
            cbDigit.TabIndex = 1;
            cbDigit.Text = "Digits";
            cbDigit.UseVisualStyleBackColor = true;
            cbDigit.CheckedChanged += cbDigit_CheckedChanged;
            // 
            // cbLowerCase
            // 
            cbLowerCase.AutoSize = true;
            cbLowerCase.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            cbLowerCase.Location = new Point(12, 77);
            cbLowerCase.Name = "cbLowerCase";
            cbLowerCase.Size = new Size(202, 40);
            cbLowerCase.TabIndex = 2;
            cbLowerCase.Text = "LowerCase";
            cbLowerCase.UseVisualStyleBackColor = true;
            // 
            // cbUpperCase
            // 
            cbUpperCase.AutoSize = true;
            cbUpperCase.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            cbUpperCase.Location = new Point(12, 123);
            cbUpperCase.Name = "cbUpperCase";
            cbUpperCase.RightToLeft = RightToLeft.No;
            cbUpperCase.Size = new Size(199, 40);
            cbUpperCase.TabIndex = 3;
            cbUpperCase.Text = "UpperCase";
            cbUpperCase.UseVisualStyleBackColor = true;
            // 
            // cbSymbol
            // 
            cbSymbol.AutoSize = true;
            cbSymbol.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            cbSymbol.Location = new Point(12, 169);
            cbSymbol.Name = "cbSymbol";
            cbSymbol.Size = new Size(149, 40);
            cbSymbol.TabIndex = 4;
            cbSymbol.Text = "Symbol";
            cbSymbol.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.BackgroundImage = (Image)resources.GetObject("btnGenerate.BackgroundImage");
            btnGenerate.BackgroundImageLayout = ImageLayout.Stretch;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(608, 362);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(194, 59);
            btnGenerate.TabIndex = 5;
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lbFront
            // 
            lbFront.AutoSize = true;
            lbFront.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFront.Location = new Point(359, 148);
            lbFront.Name = "lbFront";
            lbFront.Size = new Size(190, 34);
            lbFront.TabIndex = 6;
            lbFront.Text = "Password is:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(555, 148);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(0, 34);
            lbPassword.TabIndex = 7;
            // 
            // btnCopyToClipboard
            // 
            btnCopyToClipboard.BackgroundImage = (Image)resources.GetObject("btnCopyToClipboard.BackgroundImage");
            btnCopyToClipboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopyToClipboard.FlatAppearance.BorderSize = 0;
            btnCopyToClipboard.FlatStyle = FlatStyle.Flat;
            btnCopyToClipboard.Location = new Point(12, 362);
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new Size(218, 60);
            btnCopyToClipboard.TabIndex = 8;
            btnCopyToClipboard.UseVisualStyleBackColor = true;
            btnCopyToClipboard.Click += btnCopyToClipboard_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackgroundImage = (Image)resources.GetObject("btnSaveFile.BackgroundImage");
            btnSaveFile.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveFile.FlatAppearance.BorderSize = 0;
            btnSaveFile.FlatStyle = FlatStyle.Flat;
            btnSaveFile.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveFile.Location = new Point(306, 362);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(218, 55);
            btnSaveFile.TabIndex = 9;
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // tbLenght
            // 
            tbLenght.Location = new Point(495, 108);
            tbLenght.Name = "tbLenght";
            tbLenght.Size = new Size(125, 27);
            tbLenght.TabIndex = 10;
            tbLenght.TextChanged += tbLenght_TextChanged;
            // 
            // lbLenght
            // 
            lbLenght.AutoSize = true;
            lbLenght.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLenght.Location = new Point(359, 99);
            lbLenght.Name = "lbLenght";
            lbLenght.Size = new Size(130, 36);
            lbLenght.TabIndex = 11;
            lbLenght.Text = "Lenght:";
            // 
            // lbStrength
            // 
            lbStrength.AutoSize = true;
            lbStrength.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStrength.Location = new Point(366, 230);
            lbStrength.Name = "lbStrength";
            lbStrength.Size = new Size(0, 34);
            lbStrength.TabIndex = 12;
            // 
            // PasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(lbStrength);
            Controls.Add(lbLenght);
            Controls.Add(tbLenght);
            Controls.Add(btnSaveFile);
            Controls.Add(btnCopyToClipboard);
            Controls.Add(lbPassword);
            Controls.Add(lbFront);
            Controls.Add(btnGenerate);
            Controls.Add(cbSymbol);
            Controls.Add(cbUpperCase);
            Controls.Add(cbLowerCase);
            Controls.Add(cbDigit);
            Controls.Add(lbPassGen);
            Name = "PasswordGenerator";
            Text = "PasswordGenerator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPassGen;
        private CheckBox cbDigit;
        private CheckBox cbLowerCase;
        private CheckBox cbUpperCase;
        private CheckBox cbSymbol;
        private Button btnGenerate;
        private Label lbFront;
        private Label lbPassword;
        private Button btnCopyToClipboard;
        private Button btnSaveFile;
        private TextBox tbLenght;
        private Label lbLenght;
        private SaveFileDialog saveFileDialog;
        private Label lbStrength;
    }
}
