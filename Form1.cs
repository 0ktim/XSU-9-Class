namespace domashna8._12
{
    public partial class Form1 : Form
    {
        private object num1;
        private object num2;
        internal class23 Max { get; }
        public Form1()
        {
            InitializeComponent();
            Max = new class23();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numbox1 = textBox1.Text;
            string numbox2 = textBox2.Text;

           

            int result1;
            int result2;

            bool isNumber1 = int.TryParse(numbox1, out result1);
            bool isNumber2 = int.TryParse(numbox2, out result2);

            if (isNumber1 && isNumber2)
            {
                int maxNumber = Max.FindNAibig(result1, result2);
                textBox3.Text = maxNumber.ToString();
            }
            else
            {
                MessageBox.Show("Въведете число", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}