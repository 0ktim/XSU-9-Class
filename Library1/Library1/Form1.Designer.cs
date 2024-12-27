namespace Library1
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
            tbFindBook = new TextBox();
            tbTitle = new TextBox();
            tbAuthor = new TextBox();
            btnFindBook = new Button();
            btnDelete = new Button();
            btnAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // tbFindBook
            // 
            tbFindBook.Font = new Font("Book Antiqua", 9F, FontStyle.Italic);
            tbFindBook.Location = new Point(12, 50);
            tbFindBook.Name = "tbFindBook";
            tbFindBook.Size = new Size(290, 26);
            tbFindBook.TabIndex = 0;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Book Antiqua", 9F, FontStyle.Italic);
            tbTitle.Location = new Point(12, 241);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(290, 26);
            tbTitle.TabIndex = 1;
            // 
            // tbAuthor
            // 
            tbAuthor.Font = new Font("Book Antiqua", 9F, FontStyle.Italic);
            tbAuthor.Location = new Point(12, 301);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(290, 26);
            tbAuthor.TabIndex = 2;
            // 
            // btnFindBook
            // 
            btnFindBook.BackColor = Color.Transparent;
            btnFindBook.BackgroundImage = (Image)resources.GetObject("btnFindBook.BackgroundImage");
            btnFindBook.BackgroundImageLayout = ImageLayout.Stretch;
            btnFindBook.Cursor = Cursors.Hand;
            btnFindBook.FlatAppearance.BorderSize = 0;
            btnFindBook.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnFindBook.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFindBook.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFindBook.FlatStyle = FlatStyle.Flat;
            btnFindBook.Font = new Font("Book Antiqua", 10.8F, FontStyle.Bold);
            btnFindBook.ForeColor = Color.White;
            btnFindBook.Location = new Point(12, 79);
            btnFindBook.Name = "btnFindBook";
            btnFindBook.Size = new Size(134, 68);
            btnFindBook.TabIndex = 3;
            btnFindBook.UseVisualStyleBackColor = false;
            btnFindBook.Click += btnFindBook_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = Properties.Resources._4_removebg_preview;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Book Antiqua", 10.8F, FontStyle.Bold);
            btnDelete.Location = new Point(168, 78);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 71);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.Transparent;
            btnAddBook.BackgroundImage = (Image)resources.GetObject("btnAddBook.BackgroundImage");
            btnAddBook.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddBook.Cursor = Cursors.Hand;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnAddBook.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddBook.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Book Antiqua", 10.8F, FontStyle.Bold);
            btnAddBook.Location = new Point(12, 350);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(116, 56);
            btnAddBook.TabIndex = 5;
            btnAddBook.TextAlign = ContentAlignment.MiddleRight;
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 182);
            label1.Name = "label1";
            label1.Size = new Size(249, 28);
            label1.TabIndex = 6;
            label1.Text = "Добавяне на книга";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 7;
            label2.Text = "Заглавие";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(12, 278);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 8;
            label3.Text = "Автор";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundImage = Properties.Resources._3_removebg_preview;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Book Antiqua", 10.8F, FontStyle.Bold);
            btnSave.Location = new Point(12, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 59);
            btnSave.TabIndex = 9;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(905, 495);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(btnDelete);
            Controls.Add(btnFindBook);
            Controls.Add(tbAuthor);
            Controls.Add(tbTitle);
            Controls.Add(tbFindBook);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Библиотека";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFindBook;
        private TextBox tbTitle;
        private TextBox tbAuthor;
        private Button btnFindBook;
        private Button btnDelete;
        private Button btnAddBook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
    }
}
