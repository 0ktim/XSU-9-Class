namespace grade
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
            dataGridView1 = new DataGridView();
            Columnname = new DataGridViewTextBoxColumn();
            Family = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Columnname, Family, Grade });
            dataGridView1.Location = new Point(163, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(448, 188);
            dataGridView1.TabIndex = 0;
            // 
            // Columnname
            // 
            Columnname.HeaderText = "Име";
            Columnname.MinimumWidth = 6;
            Columnname.Name = "Columnname";
            Columnname.Width = 125;
            // 
            // Family
            // 
            Family.HeaderText = "Фамилия";
            Family.MinimumWidth = 6;
            Family.Name = "Family";
            Family.Width = 125;
            // 
            // Grade
            // 
            Grade.HeaderText = "Оценка";
            Grade.MinimumWidth = 6;
            Grade.Name = "Grade";
            Grade.Width = 125;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(147, 373);
            button1.Name = "button1";
            button1.Size = new Size(270, 57);
            button1.TabIndex = 1;
            button1.Text = "Средна оценка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(442, 373);
            button2.Name = "button2";
            button2.Size = new Size(142, 57);
            button2.TabIndex = 2;
            button2.Text = "Експорт";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(304, 61);
            label1.Name = "label1";
            label1.Size = new Size(195, 38);
            label1.TabIndex = 3;
            label1.Text = "Mini Skolo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Columnname;
        private DataGridViewTextBoxColumn Family;
        private DataGridViewTextBoxColumn Grade;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}