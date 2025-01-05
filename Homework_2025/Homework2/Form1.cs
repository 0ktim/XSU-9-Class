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
            comboBoxTransactionType.Items.Add("������");
            comboBoxTransactionType.Items.Add("������");
            comboBoxTransactionType.SelectedIndex = 0;

            dataGridViewTransactions.Columns.Add("date", "����");
            dataGridViewTransactions.Columns.Add("description", "��������");
            dataGridViewTransactions.Columns.Add("amount", "����");
            dataGridViewTransactions.Columns.Add("type", "���");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string description = textBoxDescription.Text;
            decimal amount;

            if (decimal.TryParse(textBoxAmount.Text, out amount) && !string.IsNullOrWhiteSpace(description))
            {
                string type = comboBoxTransactionType.SelectedItem.ToString();

                if (type == "������")
                {
                    amount = -amount;
                }

                balance += amount;
                labelBalance.Text = $"����� ������: {balance:F2} ��.";

                dataGridViewTransactions.Rows.Add(DateTime.Now.ToString("dd.MM.yyyy"), description, Math.Abs(amount).ToString("F2"), type);

                textBoxAmount.Clear();
                textBoxDescription.Clear();
            }
            else
            {
                MessageBox.Show("����, �������� ������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
