using System.Data;
using System.Data.Common;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Library1
{
    public partial class Form1 : Form
    {
        private DataGridView books; //Визуализира данни
        private DataTable booksTable; //Съхранява данни
        public Form1()
        {
            InitializeComponent();
            BooksList();

        }

        private void BooksList()
        {
            books = new DataGridView();
            books.Dock = DockStyle.Right; //Позициониране на DataGridView
            books.Width = 500; 
            this.Controls.Add(books);

            booksTable = new DataTable();

            booksTable.Columns.Add("Заглавие");
            booksTable.Columns.Add("Автор");

            booksTable.Rows.Add("Ад", "Виктор Пасков");
            booksTable.Rows.Add("Антихрист", "Емилиян Станев");
            booksTable.Rows.Add("Бай Ганьо", "Алеко Константинов");
            booksTable.Rows.Add("Балкани", "Антон Дончев");
            booksTable.Rows.Add("Време разделно", "Антон Дончев");
            booksTable.Rows.Add("Възвишение", "Милен Русков");
            booksTable.Rows.Add("Гераците", "Елин Пелин");
            booksTable.Rows.Add("Грамада", "Иван Вазов");
            booksTable.Rows.Add("Диви разкази", "Николай Хайтов");
            booksTable.Rows.Add("Дядо Йоцо гледа", "Иван Вазов");
            booksTable.Rows.Add("Елада", "Димитър Димов");
            booksTable.Rows.Add("Железният светилник", "Димитър Талев");
            booksTable.Rows.Add("Земя", "Елин Пелин");
            booksTable.Rows.Add("Йоан Кукузел", "Димитър Талев");
            booksTable.Rows.Add("Каралийчеви разкази", "Ангел Каралийчев");
            booksTable.Rows.Add("Книга за българския народ", "Стоян Михайловски");
            booksTable.Rows.Add("Летопис на смутното време", "Вера Мутафчиева");
            booksTable.Rows.Add("Майстори", "Рачо Стоянов");
            booksTable.Rows.Add("Мамино детенце", "Иван Вазов");
            booksTable.Rows.Add("Нощем с белите коне", "Павел Вежинов");
            booksTable.Rows.Add("Осъдени души", "Димитър Димов");
            booksTable.Rows.Add("Под игото", "Иван Вазов");
            booksTable.Rows.Add("Приказки", "Николай Райнов");
            booksTable.Rows.Add("Разкази", "Йордан Йовков");
            booksTable.Rows.Add("Реки", "Емилиян Станев");
            booksTable.Rows.Add("Снаха", "Георги Караславов");
            booksTable.Rows.Add("Старопланински легенди", "Йордан Йовков");
            booksTable.Rows.Add("Тихик и Назарий", "Емилиян Станев");
            booksTable.Rows.Add("Тютюн", "Димитър Димов");
            booksTable.Rows.Add("Хайдути", "Христо Ботев");
            booksTable.Rows.Add("Цената на златото", "Генчо Стоев");
            booksTable.Rows.Add("Чичовци", "Иван Вазов");
            booksTable.Rows.Add("Януари", "Йордан Радичков");

            books.DataSource = booksTable; //Свързва DataGridView books с DataTable booksTable
            books.ReadOnly = true;
            books.AllowUserToAddRows = false;
            books.AllowUserToDeleteRows = false;

            books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Дължината на колоните се определя от дължината на текста
            books.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = books.SelectedRows[0];

            string bookName = row.Cells["Заглавие"].Value.ToString();
            string authorName = row.Cells["Автор"].Value.ToString();

            if (books.SelectedRows.Count > 0)
            {
                if (MessageBox.Show($"Искате ли да изтриете книгата '{bookName}' от {authorName}?",
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
                string bookTitle = row.Cells["Заглавие"].Value.ToString().ToLower();
                string author = row.Cells["Автор"].Value.ToString().ToLower();

                if (bookTitle.Contains(searchText) || author.Contains(searchText))
                {
                    row.Selected = true;
                    found = true;
                    tbFindBook.Clear();
                }
            }
            if (!found)
            {
                MessageBox.Show("Не е намерена книга!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTitle.Text, "[^а-яА-Я ]") || System.Text.RegularExpressions.Regex.IsMatch(tbAuthor.Text, "[^а-яА-Я ]"))
            {
                MessageBox.Show("Моля въведете само букви на кирилица!");

            }
            else
            {
                booksTable.Rows.Add(tbTitle.Text, tbAuthor.Text);
                MessageBox.Show("Вие успешно добавихте нова книга!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV Files|*.csv";
                sfd.FileName = "Списък-с-книги";

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

                    MessageBox.Show("Файлът е запазен успешно!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при запазване: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
