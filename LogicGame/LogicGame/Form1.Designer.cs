namespace LogicGame
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
            lbQuestion = new Label();
            rbWrondAnswer = new RadioButton();
            rbRightAnsw1 = new RadioButton();
            rbWrongAnswer = new RadioButton();
            btnNextQuestion = new Button();
            lbScore = new Label();
            lbWarning = new Label();
            SuspendLayout();
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.Font = new Font("Sylfaen", 9.6F);
            lbQuestion.Location = new Point(61, 89);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(628, 66);
            lbQuestion.TabIndex = 0;
            lbQuestion.Text = resources.GetString("lbQuestion.Text");
            // 
            // rbWrondAnswer
            // 
            rbWrondAnswer.AutoSize = true;
            rbWrondAnswer.Font = new Font("Sylfaen", 9F, FontStyle.Italic);
            rbWrondAnswer.Location = new Point(61, 192);
            rbWrondAnswer.Name = "rbWrondAnswer";
            rbWrondAnswer.Size = new Size(375, 23);
            rbWrondAnswer.TabIndex = 1;
            rbWrondAnswer.TabStop = true;
            rbWrondAnswer.Text = "Казал е \"Царят е най-милостивият човек на света!\".";
            rbWrondAnswer.UseVisualStyleBackColor = true;
            // 
            // rbRightAnsw1
            // 
            rbRightAnsw1.AutoSize = true;
            rbRightAnsw1.Font = new Font("Sylfaen", 9F, FontStyle.Italic);
            rbRightAnsw1.Location = new Point(61, 238);
            rbRightAnsw1.Name = "rbRightAnsw1";
            rbRightAnsw1.Size = new Size(323, 23);
            rbRightAnsw1.TabIndex = 2;
            rbRightAnsw1.TabStop = true;
            rbRightAnsw1.Text = "Казал е \"Нека най-грозната от вас ме убие\".";
            rbRightAnsw1.UseVisualStyleBackColor = true;
            // 
            // rbWrongAnswer
            // 
            rbWrongAnswer.AutoSize = true;
            rbWrongAnswer.Font = new Font("Sylfaen", 9F, FontStyle.Italic);
            rbWrongAnswer.Location = new Point(61, 284);
            rbWrongAnswer.Name = "rbWrongAnswer";
            rbWrongAnswer.Size = new Size(392, 23);
            rbWrongAnswer.TabIndex = 3;
            rbWrongAnswer.TabStop = true;
            rbWrongAnswer.Text = " Казал е \"Аз съм пратеник на боговете, пощадете ме!\".";
            rbWrongAnswer.UseVisualStyleBackColor = true;
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.Font = new Font("Sylfaen", 9F);
            btnNextQuestion.Location = new Point(541, 359);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(172, 29);
            btnNextQuestion.TabIndex = 4;
            btnNextQuestion.Text = "Следващ въпрос >";
            btnNextQuestion.TextAlign = ContentAlignment.BottomCenter;
            btnNextQuestion.UseVisualStyleBackColor = true;
            btnNextQuestion.Click += btnNextQuestion_Click;
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbScore.ForeColor = Color.LightSeaGreen;
            lbScore.Location = new Point(123, 36);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(24, 28);
            lbScore.TabIndex = 5;
            lbScore.Text = "0";
            // 
            // lbWarning
            // 
            lbWarning.AutoSize = true;
            lbWarning.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbWarning.ForeColor = Color.Red;
            lbWarning.Location = new Point(267, 9);
            lbWarning.Name = "lbWarning";
            lbWarning.Size = new Size(0, 28);
            lbWarning.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbWarning);
            Controls.Add(lbScore);
            Controls.Add(btnNextQuestion);
            Controls.Add(rbWrongAnswer);
            Controls.Add(rbRightAnsw1);
            Controls.Add(rbWrondAnswer);
            Controls.Add(lbQuestion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbQuestion;
        private RadioButton rbWrondAnswer;
        private RadioButton rbRightAnsw1;
        private RadioButton rbWrongAnswer;
        private Button btnNextQuestion;
        private Label lbScore;
        private Label lbWarning;
    }
}
