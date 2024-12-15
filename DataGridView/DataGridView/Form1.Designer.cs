namespace DataGridView
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            OtchetBtn = new Button();
            MidleAgeBtn = new Button();
            ExportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, Age });
            dataGridView1.Location = new Point(183, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(444, 188);
            dataGridView1.TabIndex = 0;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Име";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 125;
            // 
            // LastName
            // 
            LastName.HeaderText = "Фамилия";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 125;
            // 
            // Age
            // 
            Age.HeaderText = "Възръст";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 125;
            // 
            // OtchetBtn
            // 
            OtchetBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OtchetBtn.Location = new Point(173, 256);
            OtchetBtn.Name = "OtchetBtn";
            OtchetBtn.Size = new Size(94, 39);
            OtchetBtn.TabIndex = 1;
            OtchetBtn.Text = "Отчет";
            OtchetBtn.UseVisualStyleBackColor = true;
            OtchetBtn.Click += OtchetBtn_Click;
            // 
            // MidleAgeBtn
            // 
            MidleAgeBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MidleAgeBtn.Location = new Point(286, 256);
            MidleAgeBtn.Name = "MidleAgeBtn";
            MidleAgeBtn.Size = new Size(203, 39);
            MidleAgeBtn.TabIndex = 2;
            MidleAgeBtn.Text = "Средна възръст";
            MidleAgeBtn.UseVisualStyleBackColor = true;
            MidleAgeBtn.Click += MidleAgeBtn_Click;
            // 
            // ExportBtn
            // 
            ExportBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExportBtn.Location = new Point(495, 256);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(132, 39);
            ExportBtn.TabIndex = 3;
            ExportBtn.Text = "Експорт";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExportBtn);
            Controls.Add(MidleAgeBtn);
            Controls.Add(OtchetBtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Age;
        private Button OtchetBtn;
        private Button MidleAgeBtn;
        private Button ExportBtn;
    }
}
