namespace LogicGame
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int currentQuestion = 0;

        private class Question
        {
            public string QuestionTxt { get; set; }
            public string RightAnswer { get; set; }
            public string WrongAnswer1 { get; set; }
            public string WrongAnswer2 { get; set; }
        }

        List<Question> questions = new List<Question>()
        {
           new Question
            {
                QuestionTxt = "���� ��� ����� �� ������ ���-����� ������?",
                RightAnswer = "���� ������",
                WrongAnswer1 = "���� ������",
                WrongAnswer2 = "���� ��������"
            },
            new Question
            {
                QuestionTxt = "���� ��� ���� ����� ����� ������ � ���� ����� ���� ������ � ���������.\r\n� ����� ���� � ��� �� �����, ����� ������ ������ �� ����� ���� �� ���������, �� �� \r\n� �������, �� �� ��� ��� ������ �� ���� � ��� ����?",
                RightAnswer = "3 ������",
                WrongAnswer1 = "2 ������",
                WrongAnswer2 = "4 ������"
            },
            new Question
            {
                QuestionTxt = "����� � 1/2 �� 2/3 �� 3/4 �� 800?",
                RightAnswer = "200",
                WrongAnswer1 = "300",
                WrongAnswer2 = "400"
            },
            new Question
            {
                QuestionTxt = "� ����� ��� 10 ������� � 10 ���� �������. ����� ���-����� ������� ������ �� ������� ��� �� �������, �� �� ��� �������, �� ����� ��� ������� �� ���� ����?",
                RightAnswer = "3 �������",
                WrongAnswer1 = "4 �������",
                WrongAnswer2 = "2 �������"
            },
            new Question
            {
                QuestionTxt = "��� ���� � �������, ��� ��� �� ���� ���� 100 ���?",
                RightAnswer = "���������",
                WrongAnswer1 = "�������",
                WrongAnswer2 = "�����"
            },
            new Question
            {
                QuestionTxt = "��� 5 ������ ������ 5 ������� �� 5 ������, ����� ����� �� ������ �� 1 ������ �� ������� 1 ������?",
                RightAnswer = "5 ������",
                WrongAnswer1 = "1 ������",
                WrongAnswer2 = "25 ������"
            },
            new Question
            {
                QuestionTxt = "� ���������� �� ������ ������������ ������ �� ����� �����. �� ��� ����� ��� ����?",
                RightAnswer = "����� �����",
                WrongAnswer1 = "����� �����",
                WrongAnswer2 = "����� �����"
            },
            new Question
            {
                QuestionTxt = "��� ����� 30 �� 1/2 � ������� 10, ����� �� �������?",
                RightAnswer = "70",
                WrongAnswer1 = "25",
                WrongAnswer2 = "40"
            },
            new Question
            {
                QuestionTxt = "� ���� ������� ��� 10 ������. ������� 4. ����� ������ �����?",
                RightAnswer = "4 ������",
                WrongAnswer1 = "6 ������",
                WrongAnswer2 = "10 ������"
            },
            new Question
            {
                QuestionTxt = "��� ����� � ��-����� � ��������: � �� � ��� � �� �?",
                RightAnswer = "� �� �",
                WrongAnswer1 = "� �� �",
                WrongAnswer2 = "������� �� ����������"
            },
            new Question
            {
                QuestionTxt = "���� ���� ������ �� ����� ��� ����� ��� ������� 60 ��/�. ���� ������ �� ����� ��� ����� ��� ������� 40 ��/�. ��� �� � ��-����� �� �����, ������ �� �������?",
                RightAnswer = "�� �� �� ������� ����������",
                WrongAnswer1 = "��-������� ����",
                WrongAnswer2 = "��-������� ����"
            },
            new Question
            {
                QuestionTxt = "����� �������� ���������� ����� ����� �� �� ������� ���� � ������� 1 � 2?",
                RightAnswer = "4 �����",
                WrongAnswer1 = "2 �����",
                WrongAnswer2 = "3 �����"
            },
            new Question
            {
                QuestionTxt = "��� ���������� ������� 3:15, ����� ������� � ������ ����� ���������?",
                RightAnswer = "7.5 �������",
                WrongAnswer1 = "15 �������",
                WrongAnswer2 = "45 �������"
            },
            new Question
            {
                QuestionTxt = "� ���� ��� 20 �������. ����� ����� �� ��� ������ � �����. ����� �� ���������� � 12. ����� ������� ��� � �����?",
                RightAnswer = "8 �������",
                WrongAnswer1 = "10 �������",
                WrongAnswer2 = "4 �������"
            },
            new Question
            {
                QuestionTxt = "����� 9 ������, ���� �� ����� � ������� � � ��-����. ����������� � �����. ����� ���-����� ����������� �� �����, �� �� �������� ��������� ������?",
                RightAnswer = "2 �����������",
                WrongAnswer1 = "3 �����������",
                WrongAnswer2 = "4 �����������"
            },
            new Question
            {
                QuestionTxt = "��� ����� ������ �� �� ������ ��� 1/3, �� �� �� ������ 1?",
                RightAnswer = "2/3",
                WrongAnswer1 = "1/3",
                WrongAnswer2 = "3/3"
            },
            new Question
            {
                QuestionTxt = "���� �������� ��� 10 ������� � ������ �� �� ������ � 5 ���� �� 4 ������� ��� ����� ���. ��� � �������� ����?",
                RightAnswer = "� ������",
                WrongAnswer1 = "���������� �",
                WrongAnswer2 = "� ����"
            },
            new Question
            {
                QuestionTxt = "��� 8 ���� �� ������� ������ ������� �� �� ������, ����� ������������� �� ��� ����?",
                RightAnswer = "28",
                WrongAnswer1 = "32",
                WrongAnswer2 = "24"
            },
            new Question
            {
                QuestionTxt = "����� ���� ��� � ���������� ����� �� ������� 100 ��������� (100!)?",
                RightAnswer = "24",
                WrongAnswer1 = "20",
                WrongAnswer2 = "18"
            },
            new Question
            {
                QuestionTxt = "�� ���� ���� ��� ������ ����� � ���� �����. ����� ���� ����� � ���� ���� ��� ���� � ����� ��� ���� �� ������� �� ������� ��, �� �� ���� ����� ���� � ��. ������� �����: '�� ���� ����� ���� � ����� �����'. ������� ������� ��������: '�� ���� ����� ���� � ����� �����'. ����� ���� � ������� �� ������?",
                RightAnswer = "������",
                WrongAnswer1 = "����",
                WrongAnswer2 = "�� ���� �� �� ��������"
            }
        };
        public Form1()
        {
            InitializeComponent();
            ApplyCustomStyle();
            lbScore.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbRightAnsw1.Checked)
            {
                score++;
                lbScore.Text = score.ToString();
                lbWarning.Text = "����� �������!";
            }
            else
            {
                lbWarning.Text = "������ �������! ������ ���!";
            }
        }
            private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            // ����� ����������� �������� �� ������� ������
            if (rbRightAnsw1.Checked)
            {
                score++;
                lbScore.Text = score.ToString();
            }
            else if (rbWrondAnswer.Checked || rbWrongAnswer.Checked)
            {
                lbWarning.Text = "������ �������!";
            }

            // ����������� ��� ��������� ������
            currentQuestion++;

            if (currentQuestion < questions.Count)
            {
                DisplayQuestion(currentQuestion);
            }
            else
            {
                ShowFinalScore();
            }
        }

        private void DisplayQuestion(int index)
        {
            Question currentQuestion = questions[index];

            lbQuestion.Text = currentQuestion.QuestionTxt;

            List<string> answers = new List<string>
            {
                currentQuestion.RightAnswer,
                currentQuestion.WrongAnswer1,
                currentQuestion.WrongAnswer2
            };
            Random rnd = new Random();
            answers = answers.OrderBy(x => rnd.Next()).ToList();

            rbRightAnsw1.Text = answers[0];
            rbWrondAnswer.Text = answers[1];
            rbWrongAnswer.Text = answers[2];

            rbRightAnsw1.Checked = false;
            rbWrondAnswer.Checked = false;
            rbWrongAnswer.Checked = false;
            lbWarning.Text = "";
        }

        private void ShowFinalScore()
        {
            lbQuestion.Text = $"������ ��������!\n������ ����� �������� �: {score} �� {questions.Count} �������� �����.";
            rbRightAnsw1.Visible = false;
            rbWrondAnswer.Visible = false;
            rbWrongAnswer.Visible = false;
            btnNextQuestion.Visible = false;
        }

        private void ApplyCustomStyle()
        {
            // ������� ��������� �� �������
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = ColorTranslator.FromHtml("#1e3c72");
            this.Size = new Size(800, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
           

            // ��������� ������ �����
            Panel mainPanel = new Panel();
            mainPanel.Size = new Size(750, 350);
            mainPanel.Location = new Point(25, 50);
            mainPanel.BackColor = Color.White;
            mainPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, mainPanel.Width, mainPanel.Height, 20, 20));
            this.Controls.Add(mainPanel);

            // ����� �� ���������
            Button closeButton = new Button();
            closeButton.Size = new Size(30, 30);
            closeButton.Location = new Point(this.Width - 40, 10);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Text = "X";
            closeButton.Font = new Font("Arial", 12, FontStyle.Bold);
            closeButton.ForeColor = Color.White;
            closeButton.BackColor = ColorTranslator.FromHtml("#2a5298");
            closeButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, closeButton.Width, closeButton.Height, 5, 5));
            closeButton.Click += (s, e) => this.Close();
            this.Controls.Add(closeButton);

            // Score label � ������ ��� ����
            lbScore.BackColor = ColorTranslator.FromHtml("#2a5298");
            lbScore.ForeColor = Color.White;
            lbScore.Font = new Font("Arial", 12, FontStyle.Bold);
            lbScore.Padding = new Padding(10);
            lbScore.AutoSize = true;
            lbScore.Location = new Point(25, 10);
            this.Controls.Add(lbScore);

            // Warning label ��� score
            lbWarning.ForeColor = Color.White;
            lbWarning.Font = new Font("Arial", 10);
            lbWarning.AutoSize = true;
            lbWarning.Location = new Point(120, 15);
            this.Controls.Add(lbWarning);

            // ������
            lbQuestion.BackColor = ColorTranslator.FromHtml("#f8f9fa");
            lbQuestion.Font = new Font("Arial", 12);
            lbQuestion.ForeColor = Color.Black;
            lbQuestion.AutoSize = false;
            lbQuestion.Size = new Size(700, 100);
            lbQuestion.Location = new Point(25, 20);
            lbQuestion.TextAlign = ContentAlignment.MiddleLeft;
            mainPanel.Controls.Add(lbQuestion);

            // ����� ������
            int startY = 140;
            int spacing = 50;

            rbRightAnsw1.Location = new Point(25, startY);
            rbWrondAnswer.Location = new Point(25, startY + spacing);
            rbWrongAnswer.Location = new Point(25, startY + spacing * 2);

            foreach (RadioButton rb in new[] { rbRightAnsw1, rbWrondAnswer, rbWrongAnswer })
            {
                rb.Font = new Font("Arial", 10);
                rb.ForeColor = Color.Black;
                rb.Size = new Size(700, 30);
                rb.FlatStyle = FlatStyle.Flat;
                rb.BackColor = ColorTranslator.FromHtml("#f8f9fa");
                mainPanel.Controls.Add(rb);
            }

            btnNextQuestion.Location = new Point(570, startY + spacing * 3 + 10);
            StyleButton(btnNextQuestion, "#e0e0e0", Color.Black);
            mainPanel.Controls.Add(btnNextQuestion);
        }

        private void StyleButton(Button btn, string backColor, Color foreColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = ColorTranslator.FromHtml(backColor);
            btn.ForeColor = foreColor;
            btn.Font = new Font("Arial", 10, FontStyle.Bold);
            btn.Size = new Size(150, 40);
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 10, 10));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
    }
}