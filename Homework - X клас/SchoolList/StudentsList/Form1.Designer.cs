namespace StudentsList
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
            FirstNameColumn = new DataGridViewTextBoxColumn();
            LastNameColumn = new DataGridViewTextBoxColumn();
            GradeColumn = new DataGridViewTextBoxColumn();
            btnCalculate = new Button();
            label1 = new Label();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FirstNameColumn, LastNameColumn, GradeColumn });
            dataGridView1.Location = new Point(24, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(660, 344);
            dataGridView1.TabIndex = 0;
            // 
            // FirstNameColumn
            // 
            FirstNameColumn.HeaderText = "Име";
            FirstNameColumn.MinimumWidth = 6;
            FirstNameColumn.Name = "FirstNameColumn";
            FirstNameColumn.Width = 200;
            // 
            // LastNameColumn
            // 
            LastNameColumn.HeaderText = "Фамилия";
            LastNameColumn.MinimumWidth = 6;
            LastNameColumn.Name = "LastNameColumn";
            LastNameColumn.Width = 200;
            // 
            // GradeColumn
            // 
            GradeColumn.HeaderText = "Оценка";
            GradeColumn.MinimumWidth = 6;
            GradeColumn.Name = "GradeColumn";
            GradeColumn.Width = 200;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Snow;
            btnCalculate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCalculate.Location = new Point(327, 395);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(297, 40);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(136, 399);
            label1.Name = "label1";
            label1.Size = new Size(188, 31);
            label1.TabIndex = 2;
            label1.Text = "Средна оценка:";
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Snow;
            btnExport.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnExport.Location = new Point(253, 441);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(187, 40);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(707, 501);
            Controls.Add(btnExport);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FirstNameColumn;
        private DataGridViewTextBoxColumn LastNameColumn;
        private DataGridViewTextBoxColumn GradeColumn;
        private Button btnCalculate;
        private Label label1;
        private Button btnExport;
    }
}
