namespace MenuApp
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pbSwitchImage = new PictureBox();
            rbSmallPizza = new RadioButton();
            rbMediumPizza = new RadioButton();
            rbLargePizza = new RadioButton();
            lbComponentsOfPizzaNepoletana = new Label();
            lbOurMenu = new Label();
            lbPizza = new Label();
            lbSeparation = new Label();
            lbComponentsOfPizzaPeperoni = new Label();
            lbComponentsOfPizzaHawaiian = new Label();
            lbSeparation1 = new Label();
            lbSeparate2 = new Label();
            lbComponentsOfPizzaCapricciosa = new Label();
            lbPriceOfPizzaNepoletana = new Label();
            lbPriceOfPizzaPeperoni = new Label();
            lbPriceOfPizzaHawaiian = new Label();
            lbPriceOfPizzaCapricciosa = new Label();
            btnCalculateFinalPrice = new Button();
            lbFinal = new Label();
            lbFinalPrice = new Label();
            rbPizzaPeperoni = new RadioButton();
            rbPizzaHawaiian = new RadioButton();
            rbPizzaCapricciosa = new RadioButton();
            pnlSize = new Panel();
            rbPizzaNepoletana = new RadioButton();
            pnlSort = new Panel();
            lbPizzaToppings = new Label();
            chMushrooms = new CheckBox();
            chOnion = new CheckBox();
            chOlives = new CheckBox();
            chYellowCheese = new CheckBox();
            chTunaFish = new CheckBox();
            chShrimps = new CheckBox();
            lbPriceOfMushrooms = new Label();
            lbPriceOfOnion = new Label();
            lbPriceOfYellowCheese = new Label();
            lbPriceOfOlives = new Label();
            lbPriceOfTunaFish = new Label();
            lbPriceOfShrimps = new Label();
            lbSousage = new Label();
            lbPriceOfBarbeq = new Label();
            lbPriceOfMayonese = new Label();
            lbPriceOfKetchup = new Label();
            chBarbeq = new CheckBox();
            chMayonese = new CheckBox();
            chKetchup = new CheckBox();
            lbMax = new Label();
            btnTrashCan = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSwitchImage).BeginInit();
            pnlSize.SuspendLayout();
            pnlSort.SuspendLayout();
            SuspendLayout();
            // 
            // pbSwitchImage
            // 
            pbSwitchImage.BackColor = Color.Transparent;
            pbSwitchImage.BackgroundImageLayout = ImageLayout.Stretch;
            pbSwitchImage.Location = new Point(177, 588);
            pbSwitchImage.Name = "pbSwitchImage";
            pbSwitchImage.Size = new Size(314, 287);
            pbSwitchImage.TabIndex = 0;
            pbSwitchImage.TabStop = false;
            pbSwitchImage.Click += pbSwitchImage_Click;
            // 
            // rbSmallPizza
            // 
            rbSmallPizza.AutoSize = true;
            rbSmallPizza.Font = new Font("ЗМД", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbSmallPizza.Location = new Point(11, 14);
            rbSmallPizza.Name = "rbSmallPizza";
            rbSmallPizza.Size = new Size(136, 40);
            rbSmallPizza.TabIndex = 1;
            rbSmallPizza.TabStop = true;
            rbSmallPizza.Text = "Малка";
            rbSmallPizza.UseVisualStyleBackColor = true;
            // 
            // rbMediumPizza
            // 
            rbMediumPizza.AutoSize = true;
            rbMediumPizza.Font = new Font("ЗМД", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMediumPizza.Location = new Point(153, 14);
            rbMediumPizza.Name = "rbMediumPizza";
            rbMediumPizza.Size = new Size(148, 40);
            rbMediumPizza.TabIndex = 2;
            rbMediumPizza.TabStop = true;
            rbMediumPizza.Text = "Средна";
            rbMediumPizza.UseVisualStyleBackColor = true;
            rbMediumPizza.CheckedChanged += MediumPizza_CheckedChanged;
            // 
            // rbLargePizza
            // 
            rbLargePizza.AutoSize = true;
            rbLargePizza.Font = new Font("ЗМД", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbLargePizza.Location = new Point(307, 14);
            rbLargePizza.Name = "rbLargePizza";
            rbLargePizza.Size = new Size(153, 40);
            rbLargePizza.TabIndex = 3;
            rbLargePizza.TabStop = true;
            rbLargePizza.Text = "Голяма";
            rbLargePizza.UseVisualStyleBackColor = true;
            rbLargePizza.CheckedChanged += LargePizza_CheckedChanged;
            // 
            // lbComponentsOfPizzaNepoletana
            // 
            lbComponentsOfPizzaNepoletana.AutoSize = true;
            lbComponentsOfPizzaNepoletana.Font = new Font("ЗМД", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbComponentsOfPizzaNepoletana.Location = new Point(4, 52);
            lbComponentsOfPizzaNepoletana.Name = "lbComponentsOfPizzaNepoletana";
            lbComponentsOfPizzaNepoletana.Size = new Size(282, 21);
            lbComponentsOfPizzaNepoletana.TabIndex = 5;
            lbComponentsOfPizzaNepoletana.Text = "Доматен сос, чесън и риган";
            // 
            // lbOurMenu
            // 
            lbOurMenu.AutoSize = true;
            lbOurMenu.BackColor = Color.Transparent;
            lbOurMenu.Font = new Font("ЗМД", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOurMenu.ForeColor = Color.White;
            lbOurMenu.Location = new Point(497, 9);
            lbOurMenu.Name = "lbOurMenu";
            lbOurMenu.Size = new Size(368, 53);
            lbOurMenu.TabIndex = 6;
            lbOurMenu.Text = "Нашето меню";
            // 
            // lbPizza
            // 
            lbPizza.AutoSize = true;
            lbPizza.BackColor = Color.Transparent;
            lbPizza.Font = new Font("ЗМД", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPizza.ForeColor = Color.White;
            lbPizza.Location = new Point(701, 93);
            lbPizza.Name = "lbPizza";
            lbPizza.Size = new Size(147, 57);
            lbPizza.TabIndex = 7;
            lbPizza.Text = "Пици";
            // 
            // lbSeparation
            // 
            lbSeparation.AutoSize = true;
            lbSeparation.Font = new Font("ЗМД", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSeparation.Location = new Point(3, 73);
            lbSeparation.Name = "lbSeparation";
            lbSeparation.Size = new Size(290, 24);
            lbSeparation.TabIndex = 9;
            lbSeparation.Text = "----------------------------";
            // 
            // lbComponentsOfPizzaPeperoni
            // 
            lbComponentsOfPizzaPeperoni.AutoSize = true;
            lbComponentsOfPizzaPeperoni.Font = new Font("ЗМД", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbComponentsOfPizzaPeperoni.Location = new Point(4, 130);
            lbComponentsOfPizzaPeperoni.Name = "lbComponentsOfPizzaPeperoni";
            lbComponentsOfPizzaPeperoni.Size = new Size(347, 21);
            lbComponentsOfPizzaPeperoni.TabIndex = 10;
            lbComponentsOfPizzaPeperoni.Text = "Доматен цос, моцарела и пеперони";
            lbComponentsOfPizzaPeperoni.Click += ComponentsOfPizzaPeperoni_Click;
            // 
            // lbComponentsOfPizzaHawaiian
            // 
            lbComponentsOfPizzaHawaiian.AutoSize = true;
            lbComponentsOfPizzaHawaiian.Font = new Font("ЗМД", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbComponentsOfPizzaHawaiian.Location = new Point(3, 208);
            lbComponentsOfPizzaHawaiian.Name = "lbComponentsOfPizzaHawaiian";
            lbComponentsOfPizzaHawaiian.Size = new Size(400, 21);
            lbComponentsOfPizzaHawaiian.TabIndex = 12;
            lbComponentsOfPizzaHawaiian.Text = "Доматен цос, моцарела, шунка и ананас";
            // 
            // lbSeparation1
            // 
            lbSeparation1.AutoSize = true;
            lbSeparation1.Font = new Font("ЗМД", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSeparation1.Location = new Point(3, 151);
            lbSeparation1.Name = "lbSeparation1";
            lbSeparation1.Size = new Size(290, 24);
            lbSeparation1.TabIndex = 13;
            lbSeparation1.Text = "----------------------------";
            lbSeparation1.Click += label1_Click;
            // 
            // lbSeparate2
            // 
            lbSeparate2.AutoSize = true;
            lbSeparate2.Font = new Font("ЗМД", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSeparate2.Location = new Point(4, 229);
            lbSeparate2.Name = "lbSeparate2";
            lbSeparate2.Size = new Size(290, 24);
            lbSeparate2.TabIndex = 16;
            lbSeparate2.Text = "----------------------------";
            // 
            // lbComponentsOfPizzaCapricciosa
            // 
            lbComponentsOfPizzaCapricciosa.AutoSize = true;
            lbComponentsOfPizzaCapricciosa.Font = new Font("ЗМД", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbComponentsOfPizzaCapricciosa.Location = new Point(4, 288);
            lbComponentsOfPizzaCapricciosa.Name = "lbComponentsOfPizzaCapricciosa";
            lbComponentsOfPizzaCapricciosa.Size = new Size(569, 21);
            lbComponentsOfPizzaCapricciosa.TabIndex = 15;
            lbComponentsOfPizzaCapricciosa.Text = "Доматен цос, моцарела, шунка, артишок, гъби и маслини";
            // 
            // lbPriceOfPizzaNepoletana
            // 
            lbPriceOfPizzaNepoletana.AutoSize = true;
            lbPriceOfPizzaNepoletana.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfPizzaNepoletana.Location = new Point(292, 55);
            lbPriceOfPizzaNepoletana.Name = "lbPriceOfPizzaNepoletana";
            lbPriceOfPizzaNepoletana.Size = new Size(291, 22);
            lbPriceOfPizzaNepoletana.TabIndex = 17;
            lbPriceOfPizzaNepoletana.Text = "............4 лв. / 6 лв. / 8 лв.";
            // 
            // lbPriceOfPizzaPeperoni
            // 
            lbPriceOfPizzaPeperoni.AutoSize = true;
            lbPriceOfPizzaPeperoni.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfPizzaPeperoni.Location = new Point(357, 130);
            lbPriceOfPizzaPeperoni.Name = "lbPriceOfPizzaPeperoni";
            lbPriceOfPizzaPeperoni.Size = new Size(298, 22);
            lbPriceOfPizzaPeperoni.TabIndex = 18;
            lbPriceOfPizzaPeperoni.Text = "............6 лв. / 9 лв. / 12 лв.";
            // 
            // lbPriceOfPizzaHawaiian
            // 
            lbPriceOfPizzaHawaiian.AutoSize = true;
            lbPriceOfPizzaHawaiian.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfPizzaHawaiian.Location = new Point(409, 208);
            lbPriceOfPizzaHawaiian.Name = "lbPriceOfPizzaHawaiian";
            lbPriceOfPizzaHawaiian.Size = new Size(305, 22);
            lbPriceOfPizzaHawaiian.TabIndex = 19;
            lbPriceOfPizzaHawaiian.Text = "............8 лв. / 12 лв. / 15 лв.";
            // 
            // lbPriceOfPizzaCapricciosa
            // 
            lbPriceOfPizzaCapricciosa.AutoSize = true;
            lbPriceOfPizzaCapricciosa.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfPizzaCapricciosa.Location = new Point(572, 288);
            lbPriceOfPizzaCapricciosa.Name = "lbPriceOfPizzaCapricciosa";
            lbPriceOfPizzaCapricciosa.Size = new Size(298, 22);
            lbPriceOfPizzaCapricciosa.TabIndex = 20;
            lbPriceOfPizzaCapricciosa.Text = "............5 лв. / 7 лв. / 10 лв.";
            // 
            // btnCalculateFinalPrice
            // 
            btnCalculateFinalPrice.BackColor = Color.Transparent;
            btnCalculateFinalPrice.BackgroundImage = (Image)resources.GetObject("btnCalculateFinalPrice.BackgroundImage");
            btnCalculateFinalPrice.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalculateFinalPrice.Cursor = Cursors.Hand;
            btnCalculateFinalPrice.FlatAppearance.BorderSize = 0;
            btnCalculateFinalPrice.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCalculateFinalPrice.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCalculateFinalPrice.FlatStyle = FlatStyle.Flat;
            btnCalculateFinalPrice.Location = new Point(400, 857);
            btnCalculateFinalPrice.Name = "btnCalculateFinalPrice";
            btnCalculateFinalPrice.Size = new Size(277, 120);
            btnCalculateFinalPrice.TabIndex = 21;
            btnCalculateFinalPrice.UseVisualStyleBackColor = false;
            btnCalculateFinalPrice.Click += btnCalculateFinalPrice_Click;
            // 
            // lbFinal
            // 
            lbFinal.AutoSize = true;
            lbFinal.BackColor = Color.Transparent;
            lbFinal.Font = new Font("ЗМД", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFinal.ForeColor = Color.White;
            lbFinal.Location = new Point(718, 890);
            lbFinal.Name = "lbFinal";
            lbFinal.Size = new Size(260, 41);
            lbFinal.TabIndex = 22;
            lbFinal.Text = "Крайна сума:";
            // 
            // lbFinalPrice
            // 
            lbFinalPrice.AutoSize = true;
            lbFinalPrice.BackColor = Color.Transparent;
            lbFinalPrice.Font = new Font("ЗМД", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFinalPrice.ForeColor = Color.White;
            lbFinalPrice.Location = new Point(984, 890);
            lbFinalPrice.Name = "lbFinalPrice";
            lbFinalPrice.Size = new Size(177, 41);
            lbFinalPrice.TabIndex = 23;
            lbFinalPrice.Text = "0,00 лв.";
            // 
            // rbPizzaPeperoni
            // 
            rbPizzaPeperoni.AutoSize = true;
            rbPizzaPeperoni.Font = new Font("ЗМД", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPizzaPeperoni.Location = new Point(4, 88);
            rbPizzaPeperoni.Name = "rbPizzaPeperoni";
            rbPizzaPeperoni.Size = new Size(301, 40);
            rbPizzaPeperoni.TabIndex = 25;
            rbPizzaPeperoni.TabStop = true;
            rbPizzaPeperoni.Text = "Пица Пеперони ";
            rbPizzaPeperoni.UseVisualStyleBackColor = true;
            // 
            // rbPizzaHawaiian
            // 
            rbPizzaHawaiian.AutoSize = true;
            rbPizzaHawaiian.Font = new Font("ЗМД", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPizzaHawaiian.Location = new Point(4, 165);
            rbPizzaHawaiian.Name = "rbPizzaHawaiian";
            rbPizzaHawaiian.Size = new Size(228, 40);
            rbPizzaHawaiian.TabIndex = 26;
            rbPizzaHawaiian.TabStop = true;
            rbPizzaHawaiian.Text = "Пица Хавай";
            rbPizzaHawaiian.UseVisualStyleBackColor = true;
            rbPizzaHawaiian.CheckedChanged += rbPizzaHawaiian_CheckedChanged;
            // 
            // rbPizzaCapricciosa
            // 
            rbPizzaCapricciosa.AutoSize = true;
            rbPizzaCapricciosa.Font = new Font("ЗМД", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPizzaCapricciosa.Location = new Point(3, 245);
            rbPizzaCapricciosa.Name = "rbPizzaCapricciosa";
            rbPizzaCapricciosa.Size = new Size(300, 40);
            rbPizzaCapricciosa.TabIndex = 27;
            rbPizzaCapricciosa.TabStop = true;
            rbPizzaCapricciosa.Text = "Пица Капричоза";
            rbPizzaCapricciosa.UseVisualStyleBackColor = true;
            // 
            // pnlSize
            // 
            pnlSize.BackColor = Color.Transparent;
            pnlSize.Controls.Add(rbLargePizza);
            pnlSize.Controls.Add(rbMediumPizza);
            pnlSize.Controls.Add(rbSmallPizza);
            pnlSize.ForeColor = Color.White;
            pnlSize.Location = new Point(862, 93);
            pnlSize.Name = "pnlSize";
            pnlSize.Size = new Size(472, 71);
            pnlSize.TabIndex = 28;
            // 
            // rbPizzaNepoletana
            // 
            rbPizzaNepoletana.AutoSize = true;
            rbPizzaNepoletana.Font = new Font("ЗМД", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPizzaNepoletana.Location = new Point(6, 9);
            rbPizzaNepoletana.Name = "rbPizzaNepoletana";
            rbPizzaNepoletana.Size = new Size(328, 40);
            rbPizzaNepoletana.TabIndex = 30;
            rbPizzaNepoletana.TabStop = true;
            rbPizzaNepoletana.Text = "Пица Неполетана";
            rbPizzaNepoletana.UseVisualStyleBackColor = true;
            // 
            // pnlSort
            // 
            pnlSort.BackColor = Color.Transparent;
            pnlSort.Controls.Add(lbComponentsOfPizzaCapricciosa);
            pnlSort.Controls.Add(rbPizzaCapricciosa);
            pnlSort.Controls.Add(lbSeparate2);
            pnlSort.Controls.Add(lbPriceOfPizzaCapricciosa);
            pnlSort.Controls.Add(lbComponentsOfPizzaHawaiian);
            pnlSort.Controls.Add(rbPizzaHawaiian);
            pnlSort.Controls.Add(lbComponentsOfPizzaPeperoni);
            pnlSort.Controls.Add(lbSeparation1);
            pnlSort.Controls.Add(rbPizzaPeperoni);
            pnlSort.Controls.Add(lbSeparation);
            pnlSort.Controls.Add(lbPriceOfPizzaHawaiian);
            pnlSort.Controls.Add(lbComponentsOfPizzaNepoletana);
            pnlSort.Controls.Add(rbPizzaNepoletana);
            pnlSort.Controls.Add(lbPriceOfPizzaNepoletana);
            pnlSort.Controls.Add(lbPriceOfPizzaPeperoni);
            pnlSort.ForeColor = Color.White;
            pnlSort.Location = new Point(445, 187);
            pnlSort.Name = "pnlSort";
            pnlSort.Size = new Size(870, 338);
            pnlSort.TabIndex = 31;
            // 
            // lbPizzaToppings
            // 
            lbPizzaToppings.AutoSize = true;
            lbPizzaToppings.BackColor = Color.Transparent;
            lbPizzaToppings.Font = new Font("ЗМД", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPizzaToppings.ForeColor = Color.White;
            lbPizzaToppings.Location = new Point(397, 528);
            lbPizzaToppings.Name = "lbPizzaToppings";
            lbPizzaToppings.Size = new Size(468, 57);
            lbPizzaToppings.TabIndex = 32;
            lbPizzaToppings.Text = "Добавки за Пица";
            // 
            // chMushrooms
            // 
            chMushrooms.AutoSize = true;
            chMushrooms.BackColor = Color.Transparent;
            chMushrooms.Font = new Font("ЗМД", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chMushrooms.ForeColor = Color.White;
            chMushrooms.Location = new Point(499, 603);
            chMushrooms.Name = "chMushrooms";
            chMushrooms.Size = new Size(92, 32);
            chMushrooms.TabIndex = 33;
            chMushrooms.Text = "Гъби";
            chMushrooms.UseVisualStyleBackColor = false;
            // 
            // chOnion
            // 
            chOnion.AutoSize = true;
            chOnion.BackColor = Color.Transparent;
            chOnion.Font = new Font("ЗМД", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chOnion.ForeColor = Color.White;
            chOnion.Location = new Point(499, 641);
            chOnion.Name = "chOnion";
            chOnion.Size = new Size(77, 32);
            chOnion.TabIndex = 34;
            chOnion.Text = "Лук";
            chOnion.UseVisualStyleBackColor = false;
            // 
            // chOlives
            // 
            chOlives.AutoSize = true;
            chOlives.BackColor = Color.Transparent;
            chOlives.Font = new Font("ЗМД", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chOlives.ForeColor = Color.White;
            chOlives.Location = new Point(499, 717);
            chOlives.Name = "chOlives";
            chOlives.Size = new Size(133, 32);
            chOlives.TabIndex = 35;
            chOlives.Text = "Маслини";
            chOlives.UseVisualStyleBackColor = false;
            chOlives.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chYellowCheese
            // 
            chYellowCheese.AutoSize = true;
            chYellowCheese.BackColor = Color.Transparent;
            chYellowCheese.Font = new Font("ЗМД", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chYellowCheese.ForeColor = Color.White;
            chYellowCheese.Location = new Point(499, 679);
            chYellowCheese.Name = "chYellowCheese";
            chYellowCheese.Size = new Size(150, 32);
            chYellowCheese.TabIndex = 36;
            chYellowCheese.Text = "Кашкавал";
            chYellowCheese.UseVisualStyleBackColor = false;
            // 
            // chTunaFish
            // 
            chTunaFish.AutoSize = true;
            chTunaFish.BackColor = Color.Transparent;
            chTunaFish.Font = new Font("ЗМД", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chTunaFish.ForeColor = Color.White;
            chTunaFish.Location = new Point(497, 755);
            chTunaFish.Name = "chTunaFish";
            chTunaFish.Size = new Size(152, 32);
            chTunaFish.TabIndex = 37;
            chTunaFish.Text = "Риба тон";
            chTunaFish.UseVisualStyleBackColor = false;
            // 
            // chShrimps
            // 
            chShrimps.AutoSize = true;
            chShrimps.BackColor = Color.Transparent;
            chShrimps.Font = new Font("ЗМД", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chShrimps.ForeColor = Color.White;
            chShrimps.Location = new Point(497, 793);
            chShrimps.Name = "chShrimps";
            chShrimps.Size = new Size(129, 32);
            chShrimps.TabIndex = 38;
            chShrimps.Text = "Скариди";
            chShrimps.UseVisualStyleBackColor = false;
            // 
            // lbPriceOfMushrooms
            // 
            lbPriceOfMushrooms.AutoSize = true;
            lbPriceOfMushrooms.BackColor = Color.Transparent;
            lbPriceOfMushrooms.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfMushrooms.ForeColor = Color.White;
            lbPriceOfMushrooms.Location = new Point(597, 612);
            lbPriceOfMushrooms.Name = "lbPriceOfMushrooms";
            lbPriceOfMushrooms.Size = new Size(167, 22);
            lbPriceOfMushrooms.TabIndex = 39;
            lbPriceOfMushrooms.Text = "...............0.88 лв.";
            // 
            // lbPriceOfOnion
            // 
            lbPriceOfOnion.AutoSize = true;
            lbPriceOfOnion.BackColor = Color.Transparent;
            lbPriceOfOnion.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfOnion.ForeColor = Color.White;
            lbPriceOfOnion.Location = new Point(589, 652);
            lbPriceOfOnion.Name = "lbPriceOfOnion";
            lbPriceOfOnion.Size = new Size(167, 22);
            lbPriceOfOnion.TabIndex = 40;
            lbPriceOfOnion.Text = "...............0.49 лв.";
            // 
            // lbPriceOfYellowCheese
            // 
            lbPriceOfYellowCheese.AutoSize = true;
            lbPriceOfYellowCheese.BackColor = Color.Transparent;
            lbPriceOfYellowCheese.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfYellowCheese.ForeColor = Color.White;
            lbPriceOfYellowCheese.Location = new Point(666, 692);
            lbPriceOfYellowCheese.Name = "lbPriceOfYellowCheese";
            lbPriceOfYellowCheese.Size = new Size(161, 22);
            lbPriceOfYellowCheese.TabIndex = 41;
            lbPriceOfYellowCheese.Text = "...............1.75 лв.";
            // 
            // lbPriceOfOlives
            // 
            lbPriceOfOlives.AutoSize = true;
            lbPriceOfOlives.BackColor = Color.Transparent;
            lbPriceOfOlives.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfOlives.ForeColor = Color.White;
            lbPriceOfOlives.Location = new Point(651, 725);
            lbPriceOfOlives.Name = "lbPriceOfOlives";
            lbPriceOfOlives.Size = new Size(161, 22);
            lbPriceOfOlives.TabIndex = 42;
            lbPriceOfOlives.Text = "...............1.59 лв.";
            // 
            // lbPriceOfTunaFish
            // 
            lbPriceOfTunaFish.AutoSize = true;
            lbPriceOfTunaFish.BackColor = Color.Transparent;
            lbPriceOfTunaFish.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfTunaFish.ForeColor = Color.White;
            lbPriceOfTunaFish.Location = new Point(651, 759);
            lbPriceOfTunaFish.Name = "lbPriceOfTunaFish";
            lbPriceOfTunaFish.Size = new Size(167, 22);
            lbPriceOfTunaFish.TabIndex = 43;
            lbPriceOfTunaFish.Text = "...............2.09 лв.";
            // 
            // lbPriceOfShrimps
            // 
            lbPriceOfShrimps.AutoSize = true;
            lbPriceOfShrimps.BackColor = Color.Transparent;
            lbPriceOfShrimps.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfShrimps.ForeColor = Color.White;
            lbPriceOfShrimps.Location = new Point(643, 799);
            lbPriceOfShrimps.Name = "lbPriceOfShrimps";
            lbPriceOfShrimps.Size = new Size(167, 22);
            lbPriceOfShrimps.TabIndex = 44;
            lbPriceOfShrimps.Text = "...............2.09 лв.";
            // 
            // lbSousage
            // 
            lbSousage.AutoSize = true;
            lbSousage.BackColor = Color.Transparent;
            lbSousage.Font = new Font("ЗМД", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSousage.ForeColor = Color.White;
            lbSousage.Location = new Point(1015, 528);
            lbSousage.Name = "lbSousage";
            lbSousage.Size = new Size(199, 57);
            lbSousage.TabIndex = 45;
            lbSousage.Text = "Сосове";
            // 
            // lbPriceOfBarbeq
            // 
            lbPriceOfBarbeq.AutoSize = true;
            lbPriceOfBarbeq.BackColor = Color.Transparent;
            lbPriceOfBarbeq.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfBarbeq.ForeColor = Color.White;
            lbPriceOfBarbeq.Location = new Point(1056, 685);
            lbPriceOfBarbeq.Name = "lbPriceOfBarbeq";
            lbPriceOfBarbeq.Size = new Size(167, 22);
            lbPriceOfBarbeq.TabIndex = 51;
            lbPriceOfBarbeq.Text = "...............2.50 лв.";
            // 
            // lbPriceOfMayonese
            // 
            lbPriceOfMayonese.AutoSize = true;
            lbPriceOfMayonese.BackColor = Color.Transparent;
            lbPriceOfMayonese.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfMayonese.ForeColor = Color.White;
            lbPriceOfMayonese.Location = new Point(1069, 647);
            lbPriceOfMayonese.Name = "lbPriceOfMayonese";
            lbPriceOfMayonese.Size = new Size(161, 22);
            lbPriceOfMayonese.TabIndex = 50;
            lbPriceOfMayonese.Text = "...............1.50 лв.";
            // 
            // lbPriceOfKetchup
            // 
            lbPriceOfKetchup.AutoSize = true;
            lbPriceOfKetchup.BackColor = Color.Transparent;
            lbPriceOfKetchup.Font = new Font("ЗМД", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriceOfKetchup.ForeColor = Color.White;
            lbPriceOfKetchup.Location = new Point(1047, 613);
            lbPriceOfKetchup.Name = "lbPriceOfKetchup";
            lbPriceOfKetchup.Size = new Size(161, 22);
            lbPriceOfKetchup.TabIndex = 49;
            lbPriceOfKetchup.Text = "...............1.00 лв.";
            // 
            // chBarbeq
            // 
            chBarbeq.AutoSize = true;
            chBarbeq.BackColor = Color.Transparent;
            chBarbeq.Font = new Font("ЗМД", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chBarbeq.ForeColor = Color.White;
            chBarbeq.Location = new Point(913, 679);
            chBarbeq.Name = "chBarbeq";
            chBarbeq.Size = new Size(137, 32);
            chBarbeq.TabIndex = 48;
            chBarbeq.Text = "Барбекю";
            chBarbeq.UseVisualStyleBackColor = false;
            // 
            // chMayonese
            // 
            chMayonese.AutoSize = true;
            chMayonese.BackColor = Color.Transparent;
            chMayonese.Font = new Font("ЗМД", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chMayonese.ForeColor = Color.White;
            chMayonese.Location = new Point(917, 641);
            chMayonese.Name = "chMayonese";
            chMayonese.Size = new Size(146, 32);
            chMayonese.TabIndex = 47;
            chMayonese.Text = "Майонеза";
            chMayonese.UseVisualStyleBackColor = false;
            // 
            // chKetchup
            // 
            chKetchup.AutoSize = true;
            chKetchup.BackColor = Color.Transparent;
            chKetchup.Font = new Font("ЗМД", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chKetchup.ForeColor = Color.White;
            chKetchup.Location = new Point(917, 607);
            chKetchup.Name = "chKetchup";
            chKetchup.Size = new Size(124, 32);
            chKetchup.TabIndex = 46;
            chKetchup.Text = "Кетчуп";
            chKetchup.UseVisualStyleBackColor = false;
            // 
            // lbMax
            // 
            lbMax.AutoSize = true;
            lbMax.BackColor = Color.Transparent;
            lbMax.Font = new Font("ЗМД", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMax.ForeColor = Color.White;
            lbMax.Location = new Point(1069, 801);
            lbMax.Name = "lbMax";
            lbMax.Size = new Size(184, 24);
            lbMax.TabIndex = 52;
            lbMax.Text = "Max: 3 добавки";
            // 
            // btnTrashCan
            // 
            btnTrashCan.BackColor = Color.Transparent;
            btnTrashCan.BackgroundImage = (Image)resources.GetObject("btnTrashCan.BackgroundImage");
            btnTrashCan.BackgroundImageLayout = ImageLayout.Stretch;
            btnTrashCan.Cursor = Cursors.Hand;
            btnTrashCan.FlatAppearance.BorderSize = 0;
            btnTrashCan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTrashCan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTrashCan.FlatStyle = FlatStyle.Popup;
            btnTrashCan.Location = new Point(1203, 880);
            btnTrashCan.Name = "btnTrashCan";
            btnTrashCan.Size = new Size(112, 97);
            btnTrashCan.TabIndex = 53;
            btnTrashCan.UseVisualStyleBackColor = false;
            btnTrashCan.Click += btnTrashCan_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1327, 989);
            Controls.Add(btnTrashCan);
            Controls.Add(lbMax);
            Controls.Add(lbPriceOfBarbeq);
            Controls.Add(lbPriceOfMayonese);
            Controls.Add(lbPriceOfKetchup);
            Controls.Add(chBarbeq);
            Controls.Add(chMayonese);
            Controls.Add(chKetchup);
            Controls.Add(lbSousage);
            Controls.Add(lbPriceOfShrimps);
            Controls.Add(lbPriceOfTunaFish);
            Controls.Add(lbPriceOfOlives);
            Controls.Add(lbPriceOfYellowCheese);
            Controls.Add(lbPriceOfOnion);
            Controls.Add(lbPriceOfMushrooms);
            Controls.Add(chShrimps);
            Controls.Add(chTunaFish);
            Controls.Add(chYellowCheese);
            Controls.Add(chOlives);
            Controls.Add(chOnion);
            Controls.Add(chMushrooms);
            Controls.Add(lbPizzaToppings);
            Controls.Add(pbSwitchImage);
            Controls.Add(lbFinalPrice);
            Controls.Add(lbFinal);
            Controls.Add(btnCalculateFinalPrice);
            Controls.Add(lbPizza);
            Controls.Add(lbOurMenu);
            Controls.Add(pnlSize);
            Controls.Add(pnlSort);
            Name = "Menu";
            Text = "Pizza Menu";
            ((System.ComponentModel.ISupportInitialize)pbSwitchImage).EndInit();
            pnlSize.ResumeLayout(false);
            pnlSize.PerformLayout();
            pnlSort.ResumeLayout(false);
            pnlSort.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSwitchImage;
        private RadioButton rbSmallPizza;
        private RadioButton rbMediumPizza;
        private RadioButton rbLargePizza;
        private Label lbComponentsOfPizzaNepoletana;
        private Label lbOurMenu;
        private Label lbPizza;
        private Label lbSeparation;
        private Label lbComponentsOfPizzaPeperoni;
        private Label lbComponentsOfPizzaHawaiian;
        private Label lbSeparation1;
        private Label lbSeparate2;
        private Label lbComponentsOfPizzaCapricciosa;
        private Label lbPriceOfPizzaNepoletana;
        private Label lbPriceOfPizzaPeperoni;
        private Label lbPriceOfPizzaHawaiian;
        private Label lbPriceOfPizzaCapricciosa;
        private Button btnCalculateFinalPrice;
        private Label lbFinal;
        private Label lbFinalPrice;
        private RadioButton rbPizzaPeperoni;
        private RadioButton rbPizzaHawaiian;
        private RadioButton rbPizzaCapricciosa;
        private Panel pnlSize;
        private RadioButton rbPizzaNepoletana;
        private Panel pnlSort;
        private Label lbPizzaToppings;
        private CheckBox chMushrooms;
        private CheckBox chOnion;
        private CheckBox chOlives;
        private CheckBox chYellowCheese;
        private CheckBox chTunaFish;
        private CheckBox chShrimps;
        private Label lbPriceOfMushrooms;
        private Label lbPriceOfOnion;
        private Label lbPriceOfYellowCheese;
        private Label lbPriceOfOlives;
        private Label lbPriceOfTunaFish;
        private Label lbPriceOfShrimps;
        private Label lbSousage;
        private Label lbPriceOfBarbeq;
        private Label lbPriceOfMayonese;
        private Label lbPriceOfKetchup;
        private CheckBox chBarbeq;
        private CheckBox chMayonese;
        private CheckBox chKetchup;
        private Label lbMax;
        private Button btnTrashCan;
    }
}
