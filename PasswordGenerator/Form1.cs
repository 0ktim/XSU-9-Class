using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {

        public PasswordGenerator()
        {
            InitializeComponent();
            Encoding utf8 = Encoding.UTF8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void cbDigit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, lbPassword.Text);
                MessageBox.Show("Паролата е запазена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int length = int.Parse(tbLenght.Text);
                bool includeDigits = cbDigit.Checked;
                bool includeUppercase = cbUpperCase.Checked;
                bool includeLowercase = cbLowerCase.Checked;
                bool includeSymbols = cbSymbol.Checked;

                if (!includeDigits && !includeUppercase && !includeLowercase && !includeSymbols)
                {
                    MessageBox.Show("Моля, изберете поне един критерий!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string password = GeneratePassword(length, includeDigits, includeUppercase, includeLowercase, includeSymbols);
                lbPassword.Text = password;
                EvaluatePasswordStrength(password);
            }
            catch (FormatException)
            {

                MessageBox.Show("Моля, въведете валидна дължина на паролата!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string GeneratePassword(int length, bool digits, bool uppercase, bool lowercase, bool symbols)
        {
            string digitChars = "0123456789";
            string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            string symbolChars = "!@#$%^&*()-_=+[]{}|;:,.<>?";

            StringBuilder charPool = new StringBuilder();
            if (digits) charPool.Append(digitChars);
            if (uppercase) charPool.Append(upperChars);
            if (lowercase) charPool.Append(lowerChars);
            if (symbols) charPool.Append(symbolChars);

            StringBuilder password = new StringBuilder();
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rand.Next(charPool.Length);
                password.Append(charPool[index]);
            }

            return password.ToString();
        }
        private void EvaluatePasswordStrength(string password)
        {
            int score = 0;

            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[0-9]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[!@#$%^&*()-_=+[]{}|;:,.<>?]")) score++;

            if (score <= 2)
                lbStrength.Text = "Слаба";
            else if (score <= 4)
                lbStrength.Text = "Средна";
            else
                lbStrength.Text = "Силна";
        }
        private void tbLenght_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbPassword.Text);
            MessageBox.Show("Паролата е копирана в клипборда!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
