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
            labelBalance.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBalance.ForeColor = Color.Transparent;
            labelBalance.Location = new Point(396, 471);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(91, 34);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "0.00лв";
            // 
            // comboBoxTransactionType
            // 
            comboBoxTransactionType.FormattingEnabled = true;
            comboBoxTransactionType.Location = new Point(374, 209);
            comboBoxTransactionType.Margin = new Padding(3, 2, 3, 2);
            comboBoxTransactionType.Name = "comboBoxTransactionType";
            comboBoxTransactionType.Size = new Size(133, 23);
            comboBoxTransactionType.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(374, 251);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(134, 44);
            button1.TabIndex = 2;
            button1.Text = "Добави";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(217, 311);
            dataGridViewTransactions.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.RowTemplate.Height = 29;
            dataGridViewTransactions.Size = new Size(447, 141);
            dataGridViewTransactions.TabIndex = 3;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(228, 163);
            textBoxAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(110, 23);
            textBoxAmount.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(535, 163);
            textBoxDescription.Margin = new Padding(3, 2, 3, 2);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(110, 23);
            textBoxDescription.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(237, 123);
            label2.Name = "label2";
            label2.Size = new Size(74, 34);
            label2.TabIndex = 6;
            label2.Text = "Сума";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(544, 123);
            label3.Name = "label3";
            label3.Size = new Size(129, 34);
            label3.TabIndex = 7;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(411, 163);
            label4.Name = "label4";
            label4.Size = new Size(56, 34);
            label4.TabIndex = 8;
            label4.Text = "Тип";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(270, 42);
            label1.Name = "label1";
            label1.Size = new Size(366, 34);
            label1.TabIndex = 9;
            label1.Text = "Калкулатор за личен бюджет";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(872, 544);
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
            Margin = new Padding(3, 2, 3, 2);
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