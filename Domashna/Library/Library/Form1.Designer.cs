namespace Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btndelete = new Button();
            btnFindBook = new Button();
            btnAddBook = new Button();
            tbTitle = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbAuthor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.White;
            btndelete.BackgroundImage = (Image)resources.GetObject("btndelete.BackgroundImage");
            btndelete.BackgroundImageLayout = ImageLayout.Stretch;
            btndelete.FlatAppearance.BorderSize = 0;
            btndelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btndelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btndelete.FlatStyle = FlatStyle.Popup;
            btndelete.Location = new Point(105, 335);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 36);
            btndelete.TabIndex = 0;
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click_1;
            // 
            // btnFindBook
            // 
            btnFindBook.BackColor = Color.White;
            btnFindBook.BackgroundImage = (Image)resources.GetObject("btnFindBook.BackgroundImage");
            btnFindBook.BackgroundImageLayout = ImageLayout.Stretch;
            btnFindBook.FlatAppearance.BorderSize = 0;
            btnFindBook.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFindBook.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFindBook.FlatStyle = FlatStyle.Popup;
            btnFindBook.ForeColor = Color.White;
            btnFindBook.Location = new Point(105, 273);
            btnFindBook.Name = "btnFindBook";
            btnFindBook.Size = new Size(94, 41);
            btnFindBook.TabIndex = 1;
            btnFindBook.UseVisualStyleBackColor = false;
            btnFindBook.Click += btnFindBook_Click_1;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.White;
            btnAddBook.BackgroundImage = (Image)resources.GetObject("btnAddBook.BackgroundImage");
            btnAddBook.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddBook.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(95, 79);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(104, 44);
            btnAddBook.TabIndex = 2;
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click_1;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(12, 228);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(125, 27);
            tbTitle.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(105, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 42);
            btnSave.TabIndex = 5;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(41, 35);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 6;
            label1.Text = "Добавяне на книга";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(41, 188);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 7;
            label2.Text = "Заглавие";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PeachPuff;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(191, 190);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 8;
            label3.Text = "Автор";
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(159, 228);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(125, 27);
            tbAuthor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(22, 135);
            label4.Name = "label4";
            label4.Size = new Size(238, 29);
            label4.TabIndex = 10;
            label4.Text = "Намиране на книга:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(301, 34);
            label5.Name = "label5";
            label5.Size = new Size(149, 29);
            label5.TabIndex = 11;
            label5.Text = "Библиотека";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1033, 525);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbAuthor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(tbTitle);
            Controls.Add(btnAddBook);
            Controls.Add(btnFindBook);
            Controls.Add(btndelete);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btndelete;
        private Button btnFindBook;
        private Button btnAddBook;
        private TextBox tbTitle;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbAuthor;
        private Label label4;
        private Label label5;
    }
}