using System.Data;
using System.Data.Common;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Library1
{
    public partial class Form1 : Form
    {
        private DataGridView books; //����������� �����
        private DataTable booksTable; //��������� �����
        public Form1()
        {
            InitializeComponent();
            BooksList();

        }

        private void BooksList()
        {
            books = new DataGridView();
            books.Dock = DockStyle.Right; //������������� �� DataGridView
            books.Width = 500; 
            this.Controls.Add(books);

            booksTable = new DataTable();

            booksTable.Columns.Add("��������");
            booksTable.Columns.Add("�����");

            booksTable.Rows.Add("��", "������ ������");
            booksTable.Rows.Add("���������", "������� ������");
            booksTable.Rows.Add("��� �����", "����� ������������");
            booksTable.Rows.Add("�������", "����� ������");
            booksTable.Rows.Add("����� ��������", "����� ������");
            booksTable.Rows.Add("����������", "����� ������");
            booksTable.Rows.Add("��������", "���� �����");
            booksTable.Rows.Add("�������", "���� �����");
            booksTable.Rows.Add("���� �������", "������� ������");
            booksTable.Rows.Add("���� ���� �����", "���� �����");
            booksTable.Rows.Add("�����", "������� �����");
            booksTable.Rows.Add("��������� ���������", "������� �����");
            booksTable.Rows.Add("����", "���� �����");
            booksTable.Rows.Add("���� �������", "������� �����");
            booksTable.Rows.Add("����������� �������", "����� ����������");
            booksTable.Rows.Add("����� �� ���������� �����", "����� �����������");
            booksTable.Rows.Add("������� �� �������� �����", "���� ����������");
            booksTable.Rows.Add("��������", "���� �������");
            booksTable.Rows.Add("������ �������", "���� �����");
            booksTable.Rows.Add("����� � ������ ����", "����� �������");
            booksTable.Rows.Add("������� ����", "������� �����");
            booksTable.Rows.Add("��� �����", "���� �����");
            booksTable.Rows.Add("��������", "������� ������");
            booksTable.Rows.Add("�������", "������ ������");
            booksTable.Rows.Add("����", "������� ������");
            booksTable.Rows.Add("�����", "������ ����������");
            booksTable.Rows.Add("�������������� �������", "������ ������");
            booksTable.Rows.Add("����� � �������", "������� ������");
            booksTable.Rows.Add("�����", "������� �����");
            booksTable.Rows.Add("�������", "������ �����");
            booksTable.Rows.Add("������ �� �������", "����� �����");
            booksTable.Rows.Add("�������", "���� �����");
            booksTable.Rows.Add("������", "������ ��������");

            books.DataSource = booksTable; //������� DataGridView books � DataTable booksTable
            books.ReadOnly = true;
            books.AllowUserToAddRows = false;
            books.AllowUserToDeleteRows = false;

            books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //��������� �� �������� �� �������� �� ��������� �� ������
            books.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = books.SelectedRows[0];

            string bookName = row.Cells["��������"].Value.ToString();
            string authorName = row.Cells["�����"].Value.ToString();

            if (books.SelectedRows.Count > 0)
            {
                if (MessageBox.Show($"������ �� �� �������� ������� '{bookName}' �� {authorName}?",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    books.Rows.Remove(row);
                }
            }
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            string searchText = tbFindBook.Text.ToLower();
            bool found = false;

            foreach (DataGridViewRow row in books.Rows)
            {
                string bookTitle = row.Cells["��������"].Value.ToString().ToLower();
                string author = row.Cells["�����"].Value.ToString().ToLower();

                if (bookTitle.Contains(searchText) || author.Contains(searchText))
                {
                    row.Selected = true;
                    found = true;
                    tbFindBook.Clear();
                }
            }
            if (!found)
            {
                MessageBox.Show("�� � �������� �����!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTitle.Text, "[^�-��-� ]") || System.Text.RegularExpressions.Regex.IsMatch(tbAuthor.Text, "[^�-��-� ]"))
            {
                MessageBox.Show("���� �������� ���� ����� �� ��������!");

            }
            else
            {
                booksTable.Rows.Add(tbTitle.Text, tbAuthor.Text);
                MessageBox.Show("��� ������� ��������� ���� �����!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV Files|*.csv";
                sfd.FileName = "������-�-�����";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    List<string> columnHeaders = new List<string>();

                    List<string> columnNames = new List<string>();
                    foreach (DataGridViewColumn column in books.Columns)
                        {
                        columnHeaders.Add(column.HeaderText);
                    }
                    sb.AppendLine(string.Join(",", columnHeaders));

                    foreach (DataGridViewRow row in books.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            List<string> rowText = new List<string>();

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellValue = cell.Value?.ToString() ?? "";
                                rowText.Add(cellValue);
                            }
                            sb.AppendLine(string.Join(",", rowText));
                        }
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));

                    MessageBox.Show("������ � ������� �������!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ���������: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
