namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OtchetBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string FirstName = row.Cells[0].Value.ToString();
                string LastName = row.Cells[1].Value.ToString();
                string MidleAge = row.Cells[2].Value.ToString();

                if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(MidleAge))
                {
                    MessageBox.Show($"Име: {FirstName}; Фамилия: {LastName} Възръст: {MidleAge}", "Отчет", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MidleAgeBtn_Click(object sender, EventArgs e)
        {
            int totalAge = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.TryParse(row.Cells[2].Value?.ToString(), out int age))
                {
                    totalAge += age;
                    count++;
                }
            }
            MessageBox.Show($"Средна възръст: {totalAge / count}", "Средна възръст", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV File| *.csv",
                Title = "Запази като CSV файл"

            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        writer.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1) 
                        {
                        writer.Write(',');
                        }
                    }
                    writer.WriteLine();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value?.ToString());
                                if (i < dataGridView1.Columns.Count - 1)
                                {
                                    writer.Write(',');
                                }
                            }
                            writer.WriteLine();
                        }
                    }
                }
                MessageBox.Show("Данните са експортирни успешно в CSV файл!");
            }
        }
    }
}
