namespace Homework2
{
    public partial class Form1 : Form
    {
        private decimal balance = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTransactionType.Items.Add("Приход");
            comboBoxTransactionType.Items.Add("Разход");
            comboBoxTransactionType.SelectedIndex = 0;

            dataGridViewTransactions.Columns.Add("date", "Дата");
            dataGridViewTransactions.Columns.Add("description", "Описание");
            dataGridViewTransactions.Columns.Add("amount", "Сума");
            dataGridViewTransactions.Columns.Add("type", "Тип");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string description = textBoxDescription.Text;
            decimal amount;

            if (decimal.TryParse(textBoxAmount.Text, out amount) && !string.IsNullOrWhiteSpace(description))
            {
                string type = comboBoxTransactionType.SelectedItem.ToString();

                if (type == "Разход")
                {
                    amount = -amount;
                }

                balance += amount;
                labelBalance.Text = $"Текущ баланс: {balance:F2} лв.";

                dataGridViewTransactions.Rows.Add(DateTime.Now.ToString("dd.MM.yyyy"), description, Math.Abs(amount).ToString("F2"), type);

                textBoxAmount.Clear();
                textBoxDescription.Clear();
            }
            else
            {
                MessageBox.Show("Моля, въведете валидни данни.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
