using Microsoft.VisualBasic.ApplicationServices;

namespace pizzaMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbSmallPizza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMidPizza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLargePizza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            rbSmallPizza.Checked = false;
            rbMidPizza.Checked = false;
            rbLargePizza.Checked = false;
            cbBecon.Checked = false;
            cbCheese.Checked = false;
            cbChicken.Checked = false;
            cbFish.Checked = false;
            cbHam.Checked = false;
            cbMushroom.Checked = false;
            cbOlives.Checked = false;
            cbPineapple.Checked = false;
            cbPeperoni.Checked = false;
            lbTotalPriceChange.Text = "0.00 ыт.";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Price = 0.00;

            if (rbSmallPizza.Checked)
            {
                Price += 6.50;
            }
            if (rbMidPizza.Checked)
            {
                Price += 9.00;
            }
            if (rbLargePizza.Checked)
            {
                Price += 12.00;
            }
            if (cbPeperoni.Checked)
            {
                Price += 1.10;
            }
            if (cbBecon.Checked)
            {
                Price += 1.00;
            }
            if (cbMushroom.Checked)
            {
                Price += 0.90;
            }
            if (cbCheese.Checked)
            {
                Price += 0.95;
            }
            if (cbOlives.Checked)
            {
                Price += 0.70;
            }
            if (cbPineapple.Checked)
            {
                Price += 1.50;
            }
            if (cbHam.Checked)
            {
                Price += 1.20;
            }
            if (cbChicken.Checked)
            {
                Price += 1.30;
            }
            if (cbFish.Checked)
            {
                Price += 1.00;
            }

            lbTotalPriceChange.Text = Math.Round(Price, 2) + 0.00 + " ыт.";


        }

        private void cbPeperoni_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnPep_Click(object sender, EventArgs e)
        {
            
        }
    }
}
