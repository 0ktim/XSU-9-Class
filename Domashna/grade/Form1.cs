namespace grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalgrade = 0;
            int count = 0;



            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (int.TryParse(row.Cells[2].Value?.ToString(), out int age))
                {
                    totalgrade += age;
                    count++;
                }



            }
            MessageBox.Show($" Средна оценка: {totalgrade / count}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {

                Filter = "CSV File|*.csv",
                Title = "Save to CSV File"

            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter witer = new System.IO.StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                {

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        witer.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1)
                        {
                            witer.Write(',');
                        }
                    }
                    witer.WriteLine();
                }
            }
            MessageBox.Show("Данните са запазени в CSV File!");
        }
    }

}
