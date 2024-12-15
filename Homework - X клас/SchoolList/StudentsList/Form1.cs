using System.CodeDom;
using System.Data;
using System.Text;

namespace StudentsList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double averageGrade = 0;
            int countStudents = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.TryParse(row.Cells[2].Value?.ToString(), out int grade))
                {
                    averageGrade += grade;
                    countStudents++;
                }
            }
            MessageBox.Show($"Средна оценка: {averageGrade / countStudents:F2}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.FileName = "SchoolList.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        List<string> columnHeaders = new List<string>();
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            columnHeaders.Add(column.HeaderText);
                        }
                        sb.AppendLine(string.Join(" ", columnHeaders));
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                List<string> rowData = new List<string>();

                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string cellValue = cell.Value?.ToString() ?? "";
                                    rowData.Add(cellValue);
                                }
                                sb.AppendLine(string.Join(",", rowData));
                            }
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                        MessageBox.Show("Данните бяха успешно експортирани!", "Експорт в CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Грешка при експортирането: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Няма данни за експортиране.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //StringBuilder csv = new StringBuilder(10 * dataGridView1.Rows.Count * dataGridView1.Columns.Count);

            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (i > 0)
            //    {
            //        csv.Append(",");
            //    }
            //}
            //using (OpenFileDialog ofd = new OpenFileDialog())
            //{
            //    ofd.Filter = "CSV File | *csv | All File| *.*";
            //    ofd.RestoreDirectory = true;

            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        MessageBox.Show("Файлът е запазен успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }
    }
}
