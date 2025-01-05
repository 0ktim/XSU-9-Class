namespace Homework2
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
            labelBalance = new Label();
            comboBoxTransactionType = new ComboBox();
            button1 = new Button();
            dataGridViewTransactions = new DataGridView();
            textBoxAmount = new TextBox();
            textBoxDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            SuspendLayout();
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.BackColor = Color.Transparent;
            labelBalance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelBalance.ForeColor = Color.Transparent;
            labelBalance.Location = new Point(487, 625);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(25, 30);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "0";
            // 
            // comboBoxTransactionType
            // 
            comboBoxTransactionType.FormattingEnabled = true;
            comboBoxTransactionType.Location = new Point(427, 279);
            comboBoxTransactionType.Name = "comboBoxTransactionType";
            comboBoxTransactionType.Size = new Size(151, 28);
            comboBoxTransactionType.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(446, 336);
            button1.Name = "button1";
            button1.Size = new Size(116, 38);
            button1.TabIndex = 2;
            button1.Text = "Добави";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(248, 389);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.RowTemplate.Height = 29;
            dataGridViewTransactions.Size = new Size(511, 188);
            dataGridViewTransactions.TabIndex = 3;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(260, 217);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(125, 27);
            textBoxAmount.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(611, 217);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(125, 27);
            textBoxDescription.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(298, 184);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 6;
            label2.Text = "Сума";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(632, 184);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 7;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(487, 246);
            label4.Name = "label4";
            label4.Size = new Size(39, 23);
            label4.TabIndex = 8;
            label4.Text = "Тип";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(343, 62);
            label1.Name = "label1";
            label1.Size = new Size(309, 28);
            label1.TabIndex = 9;
            label1.Text = "Калкулатор за личен бюджет";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(996, 725);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxAmount);
            Controls.Add(dataGridViewTransactions);
            Controls.Add(button1);
            Controls.Add(comboBoxTransactionType);
            Controls.Add(labelBalance);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBalance;
        private ComboBox comboBoxTransactionType;
        private Button button1;
        private DataGridView dataGridViewTransactions;
        private TextBox textBoxAmount;
        private TextBox textBoxDescription;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}