namespace Pizza_Menu
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
            chCheese = new CheckBox();
            choils = new CheckBox();
            chmushrooms = new CheckBox();
            chcorn = new CheckBox();
            chbekon = new CheckBox();
            chpeperoni = new CheckBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            chmayonnaise = new CheckBox();
            chketchup = new CheckBox();
            chmustard = new CheckBox();
            RBsmallpizza = new RadioButton();
            RBbigpizza = new RadioButton();
            RBmiddlepizza = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            labelfinalprice = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chCheese
            // 
            chCheese.AutoSize = true;
            chCheese.BackColor = Color.Transparent;
            chCheese.ForeColor = Color.White;
            chCheese.Location = new Point(300, 151);
            chCheese.Name = "chCheese";
            chCheese.Size = new Size(83, 24);
            chCheese.TabIndex = 0;
            chCheese.Text = "Сирене";
            chCheese.UseVisualStyleBackColor = false;
            // 
            // choils
            // 
            choils.AutoSize = true;
            choils.BackColor = Color.Transparent;
            choils.ForeColor = Color.White;
            choils.Location = new Point(300, 181);
            choils.Name = "choils";
            choils.Size = new Size(94, 24);
            choils.TabIndex = 1;
            choils.Text = "Маслини";
            choils.UseVisualStyleBackColor = false;
            // 
            // chmushrooms
            // 
            chmushrooms.AutoSize = true;
            chmushrooms.BackColor = Color.Transparent;
            chmushrooms.ForeColor = Color.White;
            chmushrooms.Location = new Point(300, 211);
            chmushrooms.Name = "chmushrooms";
            chmushrooms.Size = new Size(65, 24);
            chmushrooms.TabIndex = 2;
            chmushrooms.Text = "Гъби";
            chmushrooms.UseVisualStyleBackColor = false;
            // 
            // chcorn
            // 
            chcorn.AutoSize = true;
            chcorn.BackColor = Color.Transparent;
            chcorn.ForeColor = Color.White;
            chcorn.Location = new Point(300, 241);
            chcorn.Name = "chcorn";
            chcorn.Size = new Size(101, 24);
            chcorn.TabIndex = 3;
            chcorn.Text = "Царевица\r\n";
            chcorn.UseVisualStyleBackColor = false;
            // 
            // chbekon
            // 
            chbekon.AutoSize = true;
            chbekon.BackColor = Color.Transparent;
            chbekon.ForeColor = Color.White;
            chbekon.Location = new Point(300, 271);
            chbekon.Name = "chbekon";
            chbekon.Size = new Size(73, 24);
            chbekon.TabIndex = 4;
            chbekon.Text = "Бекон";
            chbekon.UseVisualStyleBackColor = false;
            // 
            // chpeperoni
            // 
            chpeperoni.AutoSize = true;
            chpeperoni.BackColor = Color.Transparent;
            chpeperoni.ForeColor = Color.White;
            chpeperoni.Location = new Point(300, 301);
            chpeperoni.Name = "chpeperoni";
            chpeperoni.Size = new Size(103, 24);
            chpeperoni.TabIndex = 5;
            chpeperoni.Text = "Пеперони";
            chpeperoni.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 240);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(347, 101);
            label2.Name = "label2";
            label2.Size = new Size(184, 30);
            label2.TabIndex = 8;
            label2.Text = "Добавки за пица";
            // 
            // chmayonnaise
            // 
            chmayonnaise.AutoSize = true;
            chmayonnaise.BackColor = Color.Transparent;
            chmayonnaise.ForeColor = Color.White;
            chmayonnaise.Location = new Point(486, 151);
            chmayonnaise.Name = "chmayonnaise";
            chmayonnaise.Size = new Size(102, 24);
            chmayonnaise.TabIndex = 9;
            chmayonnaise.Text = "Майонеза";
            chmayonnaise.UseVisualStyleBackColor = false;
            chmayonnaise.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // chketchup
            // 
            chketchup.AutoSize = true;
            chketchup.BackColor = Color.Transparent;
            chketchup.ForeColor = Color.White;
            chketchup.Location = new Point(486, 181);
            chketchup.Name = "chketchup";
            chketchup.Size = new Size(78, 24);
            chketchup.TabIndex = 10;
            chketchup.Text = "Кетчуп";
            chketchup.UseVisualStyleBackColor = false;
            // 
            // chmustard
            // 
            chmustard.AutoSize = true;
            chmustard.BackColor = Color.Transparent;
            chmustard.ForeColor = Color.White;
            chmustard.Location = new Point(486, 211);
            chmustard.Name = "chmustard";
            chmustard.Size = new Size(90, 24);
            chmustard.TabIndex = 11;
            chmustard.Text = "Горчица";
            chmustard.UseVisualStyleBackColor = false;
            // 
            // RBsmallpizza
            // 
            RBsmallpizza.AutoSize = true;
            RBsmallpizza.BackColor = Color.Transparent;
            RBsmallpizza.ForeColor = Color.White;
            RBsmallpizza.Location = new Point(22, 332);
            RBsmallpizza.Name = "RBsmallpizza";
            RBsmallpizza.Size = new Size(113, 24);
            RBsmallpizza.TabIndex = 12;
            RBsmallpizza.TabStop = true;
            RBsmallpizza.Text = "Малка пица\r\n";
            RBsmallpizza.UseVisualStyleBackColor = false;
            // 
            // RBbigpizza
            // 
            RBbigpizza.AutoSize = true;
            RBbigpizza.BackColor = Color.Transparent;
            RBbigpizza.ForeColor = Color.White;
            RBbigpizza.Location = new Point(22, 398);
            RBbigpizza.Name = "RBbigpizza";
            RBbigpizza.Size = new Size(120, 24);
            RBbigpizza.TabIndex = 13;
            RBbigpizza.TabStop = true;
            RBbigpizza.Text = "Голяма пица";
            RBbigpizza.UseVisualStyleBackColor = false;
            // 
            // RBmiddlepizza
            // 
            RBmiddlepizza.AutoSize = true;
            RBmiddlepizza.BackColor = Color.Transparent;
            RBmiddlepizza.ForeColor = Color.Transparent;
            RBmiddlepizza.Location = new Point(22, 362);
            RBmiddlepizza.Name = "RBmiddlepizza";
            RBmiddlepizza.Size = new Size(120, 24);
            RBmiddlepizza.TabIndex = 14;
            RBmiddlepizza.TabStop = true;
            RBmiddlepizza.Text = "Средна пица";
            RBmiddlepizza.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(219, 383);
            button1.Name = "button1";
            button1.Size = new Size(146, 62);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(486, 252);
            button2.Name = "button2";
            button2.Size = new Size(78, 73);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelfinalprice
            // 
            labelfinalprice.AutoSize = true;
            labelfinalprice.BackColor = Color.Transparent;
            labelfinalprice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelfinalprice.ForeColor = Color.Transparent;
            labelfinalprice.Location = new Point(537, 404);
            labelfinalprice.Name = "labelfinalprice";
            labelfinalprice.Size = new Size(58, 32);
            labelfinalprice.TabIndex = 17;
            labelfinalprice.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(384, 404);
            label3.Name = "label3";
            label3.Size = new Size(147, 30);
            label3.TabIndex = 18;
            label3.Text = "Крайна цена:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(338, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 46);
            label1.TabIndex = 19;
            label1.Text = "PIZZA MENU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(128, 338);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 20;
            label4.Text = ".......10.00лв";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(114, 404);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(135, 368);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 22;
            label6.Text = ".......12.00лв";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(135, 404);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 23;
            label7.Text = ".......15.00лв";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(385, 186);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 24;
            label8.Text = ".......1.00лв";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(392, 246);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 25;
            label9.Text = ".......0.60лв";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(357, 216);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 26;
            label10.Text = ".......1.10лв";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(375, 156);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 27;
            label11.Text = ".......1.20лв";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(579, 156);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 28;
            label12.Text = ".......0.90лв";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Transparent;
            label13.Location = new Point(394, 306);
            label13.Name = "label13";
            label13.Size = new Size(62, 15);
            label13.TabIndex = 29;
            label13.Text = ".......2.50лв";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(364, 276);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 30;
            label14.Text = ".......1.70лв";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(569, 216);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 31;
            label15.Text = ".......0.75лв";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Transparent;
            label16.Location = new Point(559, 186);
            label16.Name = "label16";
            label16.Size = new Size(62, 15);
            label16.TabIndex = 32;
            label16.Text = ".......0.80лв";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(999, 487);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(labelfinalprice);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RBmiddlepizza);
            Controls.Add(RBbigpizza);
            Controls.Add(RBsmallpizza);
            Controls.Add(chmustard);
            Controls.Add(chketchup);
            Controls.Add(chmayonnaise);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(chpeperoni);
            Controls.Add(chbekon);
            Controls.Add(chcorn);
            Controls.Add(chmushrooms);
            Controls.Add(choils);
            Controls.Add(chCheese);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chCheese;
        private CheckBox choils;
        private CheckBox chmushrooms;
        private CheckBox chcorn;
        private CheckBox chbekon;
        private CheckBox chpeperoni;
        private PictureBox pictureBox1;
        private Label label2;
        private CheckBox chmayonnaise;
        private CheckBox chketchup;
        private CheckBox chmustard;
        private RadioButton RBsmallpizza;
        private RadioButton RBbigpizza;
        private RadioButton RBmiddlepizza;
        private Button button1;
        private Button button2;
        private Label labelfinalprice;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}