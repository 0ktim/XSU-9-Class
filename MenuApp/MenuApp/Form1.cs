using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MenuApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void btnCalculateFinalPrice_Click(object sender, EventArgs e)
        {
            double StartPrice = 0.00;
            if (rbSmallPizza.Checked && rbPizzaNepoletana.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza1;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
            
                StartPrice += 4.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbMediumPizza.Checked && rbPizzaNepoletana.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza1;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 6.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            if (rbLargePizza.Checked && rbPizzaNepoletana.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza1;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 8.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbSmallPizza.Checked && rbPizzaPeperoni.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza2;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 6.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbMediumPizza.Checked && rbPizzaPeperoni.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza2;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 9.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbLargePizza.Checked && rbPizzaPeperoni.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza2;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 12.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbSmallPizza.Checked && rbPizzaHawaiian.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza3;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 6.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbMediumPizza.Checked && rbPizzaHawaiian.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza3;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 12.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbLargePizza.Checked && rbPizzaHawaiian.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza3;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 15.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbSmallPizza.Checked && rbPizzaCapricciosa.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza4;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 5.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbMediumPizza.Checked && rbPizzaCapricciosa.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza4;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 7.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
            }
            else if (rbLargePizza.Checked && rbPizzaCapricciosa.Checked)
            {
                pbSwitchImage.Image = MenuApp.Properties.Resources.Pizza4;
                pbSwitchImage.SizeMode = PictureBoxSizeMode.StretchImage;
                StartPrice += 10.00;
                if (chMushrooms.Checked)
                {
                    StartPrice += 0.88;
                }
                else if (chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                if (chMushrooms.Checked && chOnion.Checked)
                {
                    StartPrice += 0.49;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

                if (chMushrooms.Checked && chOnion.Checked && chYellowCheese.Checked)
                {
                    StartPrice += 1.75;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOnion.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chMushrooms.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chMushrooms.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chOlives.Checked)
                {
                    StartPrice += 1.59;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chYellowCheese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOnion.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOnion.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOnion.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chOlives.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chYellowCheese.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chYellowCheese.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chShrimps.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chTunaFish.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chOlives.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chOlives.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chOlives.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chOlives.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chTunaFish.Checked)
                {
                    StartPrice += 2.09;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chKetchup.Checked)
                {
                    StartPrice += 1.00;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chShrimps.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chTunaFish.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chTunaFish.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chMayonese.Checked)
                {
                    StartPrice += 1.50;
                }
                else if (chShrimps.Checked && chKetchup.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chShrimps.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }
                else if (chKetchup.Checked && chMayonese.Checked && chBarbeq.Checked)
                {
                    StartPrice += 2.50;
                }

            }
                if (rbLargePizza.Checked == false && rbMediumPizza.Checked == false && rbSmallPizza.Checked == false && rbPizzaCapricciosa.Checked == false && rbPizzaNepoletana.Checked == false && rbPizzaHawaiian.Checked == false && rbPizzaPeperoni.Checked == false)
                {
                    MessageBox.Show("Трябва да изберете пица", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                }
                lbFinalPrice.Text = Math.Round(StartPrice, 2) + " лв.";
        }

































































            






















                private void Form1_Load(object sender, EventArgs e)
                {

                }

                private void radioButton2_CheckedChanged(object sender, EventArgs e)
                {

                }

                private void PizzaNepoletana_CheckedChanged(object sender, EventArgs e)
                {

                }

                private void MediumPizza_CheckedChanged(object sender, EventArgs e)
                {

                }

                private void LargePizza_CheckedChanged(object sender, EventArgs e)
                {

                }

                private void ComponentsOfPizzaPeperoni_Click(object sender, EventArgs e)
                {

                }

                private void pbSwitchImage_Click(object sender, EventArgs e)
                {

                }

                private void label1_Click(object sender, EventArgs e)
                {

                }

                private void rbPizzaHawaiian_CheckedChanged(object sender, EventArgs e)
                {

                }

                private void checkBox3_CheckedChanged(object sender, EventArgs e)
                {

                }

                private void btnTrashCan_Click(object sender, EventArgs e)
                {
                    rbSmallPizza.Checked = false;
                    rbMediumPizza.Checked = false;
                    rbMediumPizza.Checked = false;
                    rbPizzaCapricciosa.Checked = false;
                    rbPizzaHawaiian.Checked = false;
                    rbPizzaNepoletana.Checked = false;
                    rbPizzaNepoletana.Checked = false;
                    chMushrooms.Checked = false;
                    chOnion.Checked = false;
                    chYellowCheese.Checked = false;
                    chOlives.Checked = false;
                    chTunaFish.Checked = false;
                    chShrimps.Checked = false;
                    chKetchup.Checked = false;
                    chMayonese.Checked = false;
                    chBarbeq.Checked = false;
                    lbFinalPrice.Text = "0.00 лв.";
                    pbSwitchImage.Visible = false;
                }
            }
        } 



