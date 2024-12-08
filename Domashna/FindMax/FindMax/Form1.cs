using System.Text.RegularExpressions;

namespace FindMax
{
    public partial class Form1 : Form
    {
        private Find_max Max;
        public Form1()
        {
            InitializeComponent();
            Max = new Find_max();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numbox1 = num1.Text;
            string numbox2 = num2.Text;
            int result1;
            int result2;

            bool isNumber1 = int.TryParse(numbox1, out result1);
            bool isNumber2 = int.TryParse(numbox2, out result2);
            int maxNumber = Max.FindNAibig(result1, result2);

            if (isNumber1 && isNumber2)
                textBox3.Text = maxNumber.ToString();
            else
                MessageBox.Show("Въведете число", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}