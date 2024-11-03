namespace pizzaMenu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rbSmallPizza = new RadioButton();
            rbMidPizza = new RadioButton();
            rbLargePizza = new RadioButton();
            pictureBox1 = new PictureBox();
            cbPeperoni = new CheckBox();
            cbBecon = new CheckBox();
            cbMushroom = new CheckBox();
            cbCheese = new CheckBox();
            cbOlives = new CheckBox();
            cbPineapple = new CheckBox();
            cbHam = new CheckBox();
            cbChicken = new CheckBox();
            cbFish = new CheckBox();
            btnCalculate = new Button();
            btnDelete = new Button();
            lbTotalPriceChange = new Label();
            lbFinalprice1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(336, 54);
            label1.TabIndex = 0;
            label1.Text = "PizzaHub-Nikola";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(381, 123);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 1;
            label2.Text = "6.50 лв.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(601, 123);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 2;
            label3.Text = "9.00 лв.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(816, 123);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 3;
            label4.Text = "12.00 лв.";
            // 
            // rbSmallPizza
            // 
            rbSmallPizza.AutoSize = true;
            rbSmallPizza.BackColor = Color.Transparent;
            rbSmallPizza.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            rbSmallPizza.ForeColor = Color.White;
            rbSmallPizza.Location = new Point(309, 78);
            rbSmallPizza.Name = "rbSmallPizza";
            rbSmallPizza.Size = new Size(204, 42);
            rbSmallPizza.TabIndex = 4;
            rbSmallPizza.Text = "Малка пица";
            rbSmallPizza.UseVisualStyleBackColor = false;
            rbSmallPizza.CheckedChanged += rbSmallPizza_CheckedChanged;
            // 
            // rbMidPizza
            // 
            rbMidPizza.AutoSize = true;
            rbMidPizza.BackColor = Color.Transparent;
            rbMidPizza.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            rbMidPizza.ForeColor = Color.White;
            rbMidPizza.Location = new Point(528, 78);
            rbMidPizza.Name = "rbMidPizza";
            rbMidPizza.Size = new Size(212, 42);
            rbMidPizza.TabIndex = 5;
            rbMidPizza.Text = "Средна пица";
            rbMidPizza.UseVisualStyleBackColor = false;
            rbMidPizza.CheckedChanged += rbMidPizza_CheckedChanged;
            // 
            // rbLargePizza
            // 
            rbLargePizza.AutoSize = true;
            rbLargePizza.BackColor = Color.Transparent;
            rbLargePizza.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            rbLargePizza.ForeColor = Color.White;
            rbLargePizza.Location = new Point(756, 78);
            rbLargePizza.Name = "rbLargePizza";
            rbLargePizza.Size = new Size(213, 42);
            rbLargePizza.TabIndex = 6;
            rbLargePizza.Text = "Голяма пица";
            rbLargePizza.UseVisualStyleBackColor = false;
            rbLargePizza.CheckedChanged += rbLargePizza_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 314);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // cbPeperoni
            // 
            cbPeperoni.AutoSize = true;
            cbPeperoni.BackColor = Color.Transparent;
            cbPeperoni.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbPeperoni.Location = new Point(281, 188);
            cbPeperoni.Name = "cbPeperoni";
            cbPeperoni.Size = new Size(206, 29);
            cbPeperoni.TabIndex = 8;
            cbPeperoni.Text = "Пеперони - 1.10 лв.";
            cbPeperoni.UseVisualStyleBackColor = false;
            cbPeperoni.CheckedChanged += cbPeperoni_CheckedChanged;
            // 
            // cbBecon
            // 
            cbBecon.AutoSize = true;
            cbBecon.BackColor = Color.Transparent;
            cbBecon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbBecon.Location = new Point(281, 218);
            cbBecon.Name = "cbBecon";
            cbBecon.Size = new Size(171, 29);
            cbBecon.TabIndex = 9;
            cbBecon.Text = "Бекон - 1.00 лв.";
            cbBecon.UseVisualStyleBackColor = false;
            // 
            // cbMushroom
            // 
            cbMushroom.AutoSize = true;
            cbMushroom.BackColor = Color.Transparent;
            cbMushroom.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbMushroom.Location = new Point(281, 248);
            cbMushroom.Name = "cbMushroom";
            cbMushroom.Size = new Size(160, 29);
            cbMushroom.TabIndex = 10;
            cbMushroom.Text = "Гъби - 0.90 лв.";
            cbMushroom.UseVisualStyleBackColor = false;
            // 
            // cbCheese
            // 
            cbCheese.AutoSize = true;
            cbCheese.BackColor = Color.Transparent;
            cbCheese.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbCheese.Location = new Point(281, 278);
            cbCheese.Name = "cbCheese";
            cbCheese.Size = new Size(181, 29);
            cbCheese.TabIndex = 11;
            cbCheese.Text = "Сирене - 0.95 лв.";
            cbCheese.UseVisualStyleBackColor = false;
            // 
            // cbOlives
            // 
            cbOlives.AutoSize = true;
            cbOlives.BackColor = Color.Transparent;
            cbOlives.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbOlives.Location = new Point(281, 308);
            cbOlives.Name = "cbOlives";
            cbOlives.Size = new Size(197, 29);
            cbOlives.TabIndex = 12;
            cbOlives.Text = "Маслини - 0.70 лв.";
            cbOlives.UseVisualStyleBackColor = false;
            // 
            // cbPineapple
            // 
            cbPineapple.AutoSize = true;
            cbPineapple.BackColor = Color.Transparent;
            cbPineapple.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbPineapple.Location = new Point(281, 338);
            cbPineapple.Name = "cbPineapple";
            cbPineapple.Size = new Size(181, 29);
            cbPineapple.TabIndex = 13;
            cbPineapple.Text = "Ананас - 1.50 лв.";
            cbPineapple.UseVisualStyleBackColor = false;
            // 
            // cbHam
            // 
            cbHam.AutoSize = true;
            cbHam.BackColor = Color.Transparent;
            cbHam.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbHam.Location = new Point(281, 368);
            cbHam.Name = "cbHam";
            cbHam.Size = new Size(176, 29);
            cbHam.TabIndex = 14;
            cbHam.Text = "Шунка - 1.20 лв.";
            cbHam.UseVisualStyleBackColor = false;
            // 
            // cbChicken
            // 
            cbChicken.AutoSize = true;
            cbChicken.BackColor = Color.Transparent;
            cbChicken.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbChicken.Location = new Point(281, 398);
            cbChicken.Name = "cbChicken";
            cbChicken.Size = new Size(163, 29);
            cbChicken.TabIndex = 15;
            cbChicken.Text = "Пиле - 1.30 лв.";
            cbChicken.UseVisualStyleBackColor = false;
            // 
            // cbFish
            // 
            cbFish.AutoSize = true;
            cbFish.BackColor = Color.Transparent;
            cbFish.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            cbFish.Location = new Point(281, 428);
            cbFish.Name = "cbFish";
            cbFish.Size = new Size(160, 29);
            cbFish.TabIndex = 16;
            cbFish.Text = "Риба - 1.00 лв.";
            cbFish.UseVisualStyleBackColor = false;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Transparent;
            btnCalculate.BackgroundImage = (Image)resources.GetObject("btnCalculate.BackgroundImage");
            btnCalculate.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCalculate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.Transparent;
            btnCalculate.Location = new Point(22, 488);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.RightToLeft = RightToLeft.No;
            btnCalculate.Size = new Size(215, 103);
            btnCalculate.TabIndex = 17;
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(948, 494);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.No;
            btnDelete.Size = new Size(73, 90);
            btnDelete.TabIndex = 18;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbTotalPriceChange
            // 
            lbTotalPriceChange.AutoSize = true;
            lbTotalPriceChange.BackColor = Color.Transparent;
            lbTotalPriceChange.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbTotalPriceChange.ForeColor = Color.White;
            lbTotalPriceChange.Location = new Point(732, 186);
            lbTotalPriceChange.Name = "lbTotalPriceChange";
            lbTotalPriceChange.Size = new Size(98, 31);
            lbTotalPriceChange.TabIndex = 19;
            lbTotalPriceChange.Text = "0.00 лв.";
            // 
            // lbFinalprice1
            // 
            lbFinalprice1.AutoSize = true;
            lbFinalprice1.BackColor = Color.Transparent;
            lbFinalprice1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbFinalprice1.ForeColor = Color.White;
            lbFinalprice1.Location = new Point(528, 179);
            lbFinalprice1.Name = "lbFinalprice1";
            lbFinalprice1.Size = new Size(198, 38);
            lbFinalprice1.TabIndex = 20;
            lbFinalprice1.Text = "Крайна цена:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1046, 609);
            Controls.Add(lbFinalprice1);
            Controls.Add(lbTotalPriceChange);
            Controls.Add(btnDelete);
            Controls.Add(btnCalculate);
            Controls.Add(cbFish);
            Controls.Add(cbChicken);
            Controls.Add(cbHam);
            Controls.Add(cbPineapple);
            Controls.Add(cbOlives);
            Controls.Add(cbCheese);
            Controls.Add(cbMushroom);
            Controls.Add(cbBecon);
            Controls.Add(cbPeperoni);
            Controls.Add(pictureBox1);
            Controls.Add(rbLargePizza);
            Controls.Add(rbMidPizza);
            Controls.Add(rbSmallPizza);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "PizzaHub";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rbSmallPizza;
        private RadioButton rbMidPizza;
        private RadioButton rbLargePizza;
        private PictureBox pictureBox1;
        private CheckBox cbPeperoni;
        private CheckBox cbBecon;
        private CheckBox cbMushroom;
        private CheckBox cbCheese;
        private CheckBox cbOlives;
        private CheckBox cbPineapple;
        private CheckBox cbHam;
        private CheckBox cbChicken;
        private CheckBox cbFish;
        private Button btnCalculate;
        private Button btnDelete;
        private Label lbTotalPriceChange;
        private Label lbFinalprice1;
    }
}
