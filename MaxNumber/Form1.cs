namespace MaxNumber
{
    public partial class Form1 : Form
    {
        private number Max;
        public Form1()
        {
            InitializeComponent();
            Max = new number();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
            int numBox1 = int.Parse(textBox1.Text);
            int numBox2 = int.Parse(textBox2.Text);

            int MaxNum = Max.findMax(numBox1, numBox2);

            label3.Text = MaxNum.ToString();
            } 
            
            catch 
            {
                MessageBox.Show("Невалидни данни!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
