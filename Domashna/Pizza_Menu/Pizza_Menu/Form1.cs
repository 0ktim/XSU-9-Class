namespace Pizza_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseprice = 0.00;
            if (RBsmallpizza.Checked)
            {
                baseprice = 10;
            }
            else if (RBmiddlepizza.Checked)
            {
                baseprice = 12;
            }
            else if (RBbigpizza.Checked)
            {
                baseprice = 15;
            }
            if (chCheese.Checked)
            {
                baseprice += 1.2;
            }
            if (choils.Checked)
            {
                baseprice += 1;
            }
            if (chmushrooms.Checked)
            {
                baseprice += 1.1;
            }
            if (chcorn.Checked)
            {
                baseprice += 0.6;
            }
            if (chbekon.Checked)
            {
                baseprice += 1.7;
            }
            if (chpeperoni.Checked)
            {
                baseprice += 2.50;
            }
            if (chmayonnaise.Checked)
            {
                baseprice += 0.9;
            }
            if (chketchup.Checked)
            {
                baseprice += 0.8;
            }
            if (chmustard.Checked)
            {
                baseprice += 0.75;

            }




            labelfinalprice.Text = baseprice.ToString("0.00 ыт");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RBsmallpizza.Checked = false;
            RBmiddlepizza.Checked = false;
            RBbigpizza.Checked = false;
            chCheese.Checked = false;
            choils.Checked = false;
            chmushrooms.Checked = false;
            chcorn.Checked = false;
            chbekon.Checked = false;
            chpeperoni.Checked = false;
            chmayonnaise.Checked = false;
            chketchup.Checked = false;
            chmustard.Checked = false;
            labelfinalprice.Text = "0,00 ыт";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
