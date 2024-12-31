using System.Data;
using System.Text;

namespace Library
{

    public partial class Form1 : Form
    {
        private DataGridView books;
        private DataTable booksTable;
        public Form1()
        {
            InitializeComponent();
            BooksList();

        }

        private void BooksList()
        {
            books = new DataGridView();
            books.Dock = DockStyle.Right;
            books.Width = 500;
            this.Controls.Add(books);

            booksTable = new DataTable();

            booksTable.Columns.Add("Книга");
            booksTable.Columns.Add("Автор");

            booksTable.Rows.Add("Под игото", "Иван Вазов");
            booksTable.Rows.Add("Тютюн", "Димитър Димов");
            booksTable.Rows.Add("Железният светилник", "Димитър Талев");
            booksTable.Rows.Add("Осъдени души", "Димитър Димов");
            booksTable.Rows.Add("Бай Ганьо", "Алеко Константинов");
            booksTable.Rows.Add("Чичовци", "Иван Вазов");
            booksTable.Rows.Add("Ангелинка", "Елин Пелин");
            booksTable.Rows.Add("Гераците", "Елин Пелин");
            booksTable.Rows.Add("Хайка за Вълци", "Ивайло Петлов");
            booksTable.Rows.Add("Време Разделно", "Антон Дончев");
            booksTable.Rows.Add("Приключенията на Лиско", "Борис Априлов");
            booksTable.Rows.Add("Козият рог", "Николай Хайтов");
            booksTable.Rows.Add("Диви разкази", "Николай Хайтов");
            booksTable.Rows.Add("Милионерът", "Елин Пелин");
            booksTable.Rows.Add("Трите живота на Кракра", "Антон Дончев");
            booksTable.Rows.Add("Земя", "Елин Пелин");
            booksTable.Rows.Add("На разсъмване", "Йордан Йовков");
            booksTable.Rows.Add("Старопланински Легенди", "Йордан Йовков");
            booksTable.Rows.Add("Албена", "Йордан Йовков");
            booksTable.Rows.Add("Нощем с белите коси", "Павел Вежинов");
            booksTable.Rows.Add("Калуня-Каня", "Георги Божинов");
            booksTable.Rows.Add("Легенда за Сибин", "Евгени Кузманов");
            booksTable.Rows.Add("Мъртви души", "Алеко Константинов");
            booksTable.Rows.Add("Писма до Ганка", "Йордан Радичков");
            booksTable.Rows.Add("Ние,врабчетата", "Йордан Радичков");
            booksTable.Rows.Add("Лавина", "Блага Димитрова");
            booksTable.Rows.Add("Петко войвода", "Николай Райнов");
            booksTable.Rows.Add("Изумруденото око", "Людмила Филипова");
            booksTable.Rows.Add("Шибил", "Йордан Йовков");
            booksTable.Rows.Add("Бяла пръст", "Георги Караславов");
            booksTable.Rows.Add("Цената на златото", "Генчо Стоев");
            booksTable.Rows.Add("Почивка в Арко Ирис", "Георги Господинов");
            booksTable.Rows.Add("Естествен роман", "Георги Господинов");
            booksTable.Rows.Add("Физика на тъгата", "Георги Господинов");
            booksTable.Rows.Add("Иван Кондарев", "Емилиян Станев");
            booksTable.Rows.Add("Антихрист", "Емилиян Станев");
            booksTable.Rows.Add("Крадецът на праскови", "Емилиян станев");
            booksTable.Rows.Add("В полите на Витоша", "Пейо Яворов");
            booksTable.Rows.Add("Моторни песни", "Гео Милев");
            booksTable.Rows.Add("Писма от България", "Алеко Константинов");
            booksTable.Rows.Add("Смъртта на Аякс", "Петър Увалиев");
            booksTable.Rows.Add("Преспанските камбани", "Димитър Талев");
            booksTable.Rows.Add("Татул", "Николай Хайтов");
            booksTable.Rows.Add("Денят не си личи по заранта", "Николай Райнов");
            booksTable.Rows.Add("Самуил", "Димитър Талев");
            booksTable.Rows.Add("Пътешественикът", "Николай Кънчев");
            booksTable.Rows.Add("Кръвта остава", "  Георги Краславов");
            booksTable.Rows.Add("Потъването на Созопол", "Ина Вълчанова");



            books.DataSource = booksTable;
            books.ReadOnly = true;
            books.AllowUserToAddRows = false;
            books.AllowUserToDeleteRows = false;

            books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            books.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = books.SelectedRows[0];

            string bookName = row.Cells["Книга"].Value.ToString();
            string authorName = row.Cells["Автор"].Value.ToString();

            if (books.SelectedRows.Count > 0)
            {
                if (MessageBox.Show($"Книгата '{bookName}' на автора {authorName}?",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    books.Rows.Remove(row);
                }
            }
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            string searchText = tbTitle.Text.ToLower();
            bool found = false;

            foreach (DataGridViewRow row in books.Rows)
            {
                string bookTitle = row.Cells["Книга"].Value.ToString().ToLower();
                string author = row.Cells["Автор"].Value.ToString().ToLower();

                if (bookTitle.Contains(searchText) || author.Contains(searchText))
                {
                    row.Selected = true;
                    found = true;
                    tbTitle.Clear();
                    tbAuthor.Clear();
                }
            }
            if (!found)
            {
                MessageBox.Show("Намерена!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTitle.Text, "Заглавие") || System.Text.RegularExpressions.Regex.IsMatch(tbAuthor.Text, "Автор"))
            {
                MessageBox.Show("Вече е налично");

            }
            else
            {
                booksTable.Rows.Add(tbTitle.Text, tbAuthor.Text);
                MessageBox.Show("Добавено усрешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefd = new SaveFileDialog();
                savefd.Filter = "CSV Files|*.csv";
                savefd.FileName = "Запазено успешно";

                if (savefd.ShowDialog() == DialogResult.OK)
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

                    File.WriteAllText(savefd.FileName, sb.ToString(), new UTF8Encoding(true));

                    MessageBox.Show("Записано успешно!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Грешка: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindBook_Click_1(object sender, EventArgs e)
        {
            string searchText = tbTitle.Text.ToLower();
            bool found = false;

            foreach (DataGridViewRow row in books.Rows)
            {
                string bookTitle = row.Cells["Книга"].Value.ToString().ToLower();
                string author = row.Cells["Автор"].Value.ToString().ToLower();

                if (bookTitle.Contains(searchText) || author.Contains(searchText))
                {
                    row.Selected = true;
                    found = true;
                    tbTitle.Clear();
                }
            }
            if (!found)
            {
                MessageBox.Show("Няма намерена книга или автор!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefd = new SaveFileDialog();
                savefd.Filter = "CSV Files|*.csv";
                savefd.FileName = "Запазено успешно";

                if (savefd.ShowDialog() == DialogResult.OK)
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

                    File.WriteAllText(savefd.FileName, sb.ToString(), new UTF8Encoding(true));

                    MessageBox.Show("Записано успешно!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Грешка: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTitle.Text, "Заглавие") || System.Text.RegularExpressions.Regex.IsMatch(tbAuthor.Text, "Автор"))
            {
                MessageBox.Show("Вече е налично");

            }
            else
            {
                booksTable.Rows.Add(tbTitle.Text, tbAuthor.Text);
                MessageBox.Show("Добавено упрешно!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = books.SelectedRows[0];

            string bookName = row.Cells["Книга"].Value.ToString();
            string authorName = row.Cells["Автор"].Value.ToString();

            if (books.SelectedRows.Count > 0)
            {
                if (MessageBox.Show($"Книгата '{bookName}' на автора {authorName}?",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    books.Rows.Remove(row);
                }
            }
        }
    }
}
