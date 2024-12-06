namespace Compare_numbers
{
    public partial class Form1 : Form
    {
        private Numbers maxNum;
        public Form1()
        {
            InitializeComponent();
            maxNum = new Numbers();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;
            int result1;
            int result2;

            bool isNumber1 = int.TryParse(num1,out result1);  
            bool isNumber2 = int.TryParse(num2,out result2);  
            int maxNumber = maxNum.FindMax(result1, result2);

            if (isNumber1 && isNumber2)
                label1.Text = maxNumber.ToString();
            else
                MessageBox.Show("Моля, въведете число!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
