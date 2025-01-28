namespace TicTacToe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            btnNewGame = new Button();
            btnReset = new Button();
            btnExit = new Button();
            button10 = new Button();
            button11 = new Button();
            btnPlayerX = new Button();
            btnPlayerO = new Button();
            btnCurrentPlayer = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold);
            button1.ForeColor = Color.Salmon;
            button1.Location = new Point(418, 144);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaShell;
            button2.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold);
            button2.ForeColor = Color.Salmon;
            button2.Location = new Point(524, 144);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaShell;
            button3.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold);
            button3.ForeColor = Color.Salmon;
            button3.Location = new Point(630, 144);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaShell;
            button4.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold);
            button4.ForeColor = Color.Salmon;
            button4.Location = new Point(418, 250);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaShell;
            button5.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold);
            button5.ForeColor = Color.Salmon;
            button5.Location = new Point(524, 250);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SeaShell;
            button6.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold);
            button6.ForeColor = Color.Salmon;
            button6.Location = new Point(630, 250);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.SeaShell;
            button7.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold);
            button7.ForeColor = Color.Salmon;
            button7.Location = new Point(418, 356);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.SeaShell;
            button8.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold);
            button8.ForeColor = Color.Salmon;
            button8.Location = new Point(524, 356);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.SeaShell;
            button9.Font = new Font("Segoe UI Black", 33F, FontStyle.Bold);
            button9.ForeColor = Color.Salmon;
            button9.Location = new Point(630, 356);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(232, 22);
            label1.Name = "label1";
            label1.Size = new Size(334, 84);
            label1.TabIndex = 9;
            label1.Text = "Морски шах";
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.Location = new Point(34, 313);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(308, 68);
            btnNewGame.TabIndex = 11;
            btnNewGame.Text = "NEW GAME";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold);
            btnReset.Location = new Point(34, 387);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(145, 68);
            btnReset.TabIndex = 12;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold);
            btnExit.Location = new Point(199, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 68);
            btnExit.TabIndex = 13;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold);
            button10.Location = new Point(34, 203);
            button10.Name = "button10";
            button10.Size = new Size(192, 49);
            button10.TabIndex = 14;
            button10.Text = "Player X:";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold);
            button11.Location = new Point(34, 258);
            button11.Name = "button11";
            button11.Size = new Size(192, 49);
            button11.TabIndex = 15;
            button11.Text = "Player O:";
            button11.UseVisualStyleBackColor = true;
            // 
            // btnPlayerX
            // 
            btnPlayerX.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold);
            btnPlayerX.Location = new Point(232, 203);
            btnPlayerX.Name = "btnPlayerX";
            btnPlayerX.Size = new Size(110, 49);
            btnPlayerX.TabIndex = 16;
            btnPlayerX.Text = "0";
            btnPlayerX.UseVisualStyleBackColor = true;
            // 
            // btnPlayerO
            // 
            btnPlayerO.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold);
            btnPlayerO.Location = new Point(232, 258);
            btnPlayerO.Name = "btnPlayerO";
            btnPlayerO.Size = new Size(110, 49);
            btnPlayerO.TabIndex = 17;
            btnPlayerO.Text = "0";
            btnPlayerO.UseVisualStyleBackColor = true;
            // 
            // btnCurrentPlayer
            // 
            btnCurrentPlayer.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCurrentPlayer.Location = new Point(34, 145);
            btnCurrentPlayer.Name = "btnCurrentPlayer";
            btnCurrentPlayer.Size = new Size(308, 52);
            btnCurrentPlayer.TabIndex = 19;
            btnCurrentPlayer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 530);
            ControlBox = false;
            Controls.Add(btnCurrentPlayer);
            Controls.Add(btnPlayerO);
            Controls.Add(btnPlayerX);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnNewGame);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Button btnNewGame;
        private Button btnReset;
        private Button btnExit;
        private Button button10;
        private Button button11;
        private Button btnPlayerX;
        private Button btnPlayerO;
        private Button btnCurrentPlayer;
    }
}
