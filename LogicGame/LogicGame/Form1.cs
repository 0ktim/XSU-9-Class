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
                QuestionTxt = "През кой сезон се раждат най-много бебета?",
                RightAnswer = "През лятото",
                WrongAnswer1 = "През зимата",
                WrongAnswer2 = "През пролетта"
            },
            new Question
            {
                QuestionTxt = "Пешо има шест чифта черни чорапи и шест чифта бели чорапи в гардероба.\r\nВ пълен мрак и без да гледа, колко чорапи трябва да вземе Пешо от гардероба, за да \r\nе сигурен, че ще има два чорапа от един и същ цвят?",
                RightAnswer = "3 чорапа",
                WrongAnswer1 = "2 чорапа",
                WrongAnswer2 = "4 чорапа"
            },
            new Question
            {
                QuestionTxt = "Колко е 1/2 от 2/3 от 3/4 от 800?",
                RightAnswer = "200",
                WrongAnswer1 = "300",
                WrongAnswer2 = "400"
            },
            new Question
            {
                QuestionTxt = "В кутия има 10 червени и 10 сини топчета. Колко най-малко топчета трябва да извадим без да гледаме, за да сме сигурни, че имаме две топчета от един цвят?",
                RightAnswer = "3 топчета",
                WrongAnswer1 = "4 топчета",
                WrongAnswer2 = "2 топчета"
            },
            new Question
            {
                QuestionTxt = "Ако днес е вторник, кой ден ще бъде след 100 дни?",
                RightAnswer = "Четвъртък",
                WrongAnswer1 = "Вторник",
                WrongAnswer2 = "Сряда"
            },
            new Question
            {
                QuestionTxt = "Ако 5 машини правят 5 детайла за 5 минути, колко време ще отнеме на 1 машина да направи 1 детайл?",
                RightAnswer = "5 минути",
                WrongAnswer1 = "1 минута",
                WrongAnswer2 = "25 минути"
            },
            new Question
            {
                QuestionTxt = "В състезание по бягане изпреварвате бегача на второ място. На кое място сте сега?",
                RightAnswer = "Второ място",
                WrongAnswer1 = "Първо място",
                WrongAnswer2 = "Трето място"
            },
            new Question
            {
                QuestionTxt = "Ако делим 30 на 1/2 и добавим 10, колко ще получим?",
                RightAnswer = "70",
                WrongAnswer1 = "25",
                WrongAnswer2 = "40"
            },
            new Question
            {
                QuestionTxt = "В една кошница има 10 ябълки. Взимате 4. Колко ябълки имате?",
                RightAnswer = "4 ябълки",
                WrongAnswer1 = "6 ябълки",
                WrongAnswer2 = "10 ябълки"
            },
            new Question
            {
                QuestionTxt = "Коя буква е по-близо в азбуката: К до М или М до О?",
                RightAnswer = "К до М",
                WrongAnswer1 = "М до О",
                WrongAnswer2 = "Еднакво са отдалечени"
            },
            new Question
            {
                QuestionTxt = "Един влак тръгва от София към Варна със скорост 60 км/ч. Друг тръгва от Варна към София със скорост 40 км/ч. Кой ще е по-близо до София, когато се срещнат?",
                RightAnswer = "Ще са на еднакво разстояние",
                WrongAnswer1 = "По-бързият влак",
                WrongAnswer2 = "По-бавният влак"
            },
            new Question
            {
                QuestionTxt = "Колко различни двуцифрени числа могат да се напишат само с цифрите 1 и 2?",
                RightAnswer = "4 числа",
                WrongAnswer1 = "2 числа",
                WrongAnswer2 = "3 числа"
            },
            new Question
            {
                QuestionTxt = "Ако часовникът показва 3:15, колко градуса е ъгълът между стрелките?",
                RightAnswer = "7.5 градуса",
                WrongAnswer1 = "15 градуса",
                WrongAnswer2 = "45 градуса"
            },
            new Question
            {
                QuestionTxt = "В клас има 20 ученици. Всяко момче си има сестра в класа. Броят на момичетата е 12. Колко момчета има в класа?",
                RightAnswer = "8 момчета",
                WrongAnswer1 = "10 момчета",
                WrongAnswer2 = "4 момчета"
            },
            new Question
            {
                QuestionTxt = "Имате 9 монети, една от които е фалшива и е по-лека. Разполагате с везна. Колко най-малко претегляния са нужни, за да намерите фалшивата монета?",
                RightAnswer = "2 претегляния",
                WrongAnswer1 = "3 претегляния",
                WrongAnswer2 = "4 претегляния"
            },
            new Question
            {
                QuestionTxt = "Кое число трябва да се добави към 1/3, за да се получи 1?",
                RightAnswer = "2/3",
                WrongAnswer1 = "1/3",
                WrongAnswer2 = "3/3"
            },
            new Question
            {
                QuestionTxt = "Един градинар има 10 дървета и трябва да ги засади в 5 реда по 4 дървета във всеки ред. Как е възможно това?",
                RightAnswer = "В звезда",
                WrongAnswer1 = "Невъзможно е",
                WrongAnswer2 = "В кръг"
            },
            new Question
            {
                QuestionTxt = "Ако 8 души си стиснат ръцете помежду си по веднъж, колко ръкостискания ще има общо?",
                RightAnswer = "28",
                WrongAnswer1 = "32",
                WrongAnswer2 = "24"
            },
            new Question
            {
                QuestionTxt = "Колко нули има в десетичния запис на числото 100 факториел (100!)?",
                RightAnswer = "24",
                WrongAnswer1 = "20",
                WrongAnswer2 = "18"
            },
            new Question
            {
                QuestionTxt = "На една маса има зелена шапка и синя шапка. Двама души седят с гръб един към друг и всеки има една от шапките на главата си, но не знае какъв цвят е тя. Първият казва: 'Не знам какъв цвят е моята шапка'. Вторият веднага отговаря: 'Аз знам какъв цвят е моята шапка'. Какъв цвят е шапката на втория?",
                RightAnswer = "Зелена",
                WrongAnswer1 = "Синя",
                WrongAnswer2 = "Не може да се определи"
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
                lbWarning.Text = "Верен отговор!";
            }
            else
            {
                lbWarning.Text = "Грешен отговор! Опитай пак!";
            }
        }
            private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            // Първо проверяваме отговора на текущия въпрос
            if (rbRightAnsw1.Checked)
            {
                score++;
                lbScore.Text = score.ToString();
            }
            else if (rbWrondAnswer.Checked || rbWrongAnswer.Checked)
            {
                lbWarning.Text = "Грешен отговор!";
            }

            // Преминаваме към следващия въпрос
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
            lbQuestion.Text = $"Играта приключи!\nВашият краен резултат е: {score} от {questions.Count} възможни точки.";
            rbRightAnsw1.Visible = false;
            rbWrondAnswer.Visible = false;
            rbWrongAnswer.Visible = false;
            btnNextQuestion.Visible = false;
        }

        private void ApplyCustomStyle()
        {
            // Основни настройки на формата
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = ColorTranslator.FromHtml("#1e3c72");
            this.Size = new Size(800, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
           

            // Създаваме главен панел
            Panel mainPanel = new Panel();
            mainPanel.Size = new Size(750, 350);
            mainPanel.Location = new Point(25, 50);
            mainPanel.BackColor = Color.White;
            mainPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, mainPanel.Width, mainPanel.Height, 20, 20));
            this.Controls.Add(mainPanel);

            // Бутон за затваряне
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

            // Score label в горния ляв ъгъл
            lbScore.BackColor = ColorTranslator.FromHtml("#2a5298");
            lbScore.ForeColor = Color.White;
            lbScore.Font = new Font("Arial", 12, FontStyle.Bold);
            lbScore.Padding = new Padding(10);
            lbScore.AutoSize = true;
            lbScore.Location = new Point(25, 10);
            this.Controls.Add(lbScore);

            // Warning label под score
            lbWarning.ForeColor = Color.White;
            lbWarning.Font = new Font("Arial", 10);
            lbWarning.AutoSize = true;
            lbWarning.Location = new Point(120, 15);
            this.Controls.Add(lbWarning);

            // Въпрос
            lbQuestion.BackColor = ColorTranslator.FromHtml("#f8f9fa");
            lbQuestion.Font = new Font("Arial", 12);
            lbQuestion.ForeColor = Color.Black;
            lbQuestion.AutoSize = false;
            lbQuestion.Size = new Size(700, 100);
            lbQuestion.Location = new Point(25, 20);
            lbQuestion.TextAlign = ContentAlignment.MiddleLeft;
            mainPanel.Controls.Add(lbQuestion);

            // Радио бутони
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