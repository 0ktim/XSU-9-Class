using static System.Formats.Asn1.AsnWriter;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool isXTurn = true; // ����� ��� � �� ���: true �� "X", false �� "O"
        private int moveCount = 0;   // ����� ���� �� �������� (�������� 9)
        private int scorePlayer1 = 0;
        private int scorePlayer2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            // �������� ���� ������� ���� � ��������
            if (button.Text != "")
                return;

            // ��������� �� "X" ��� "O"
            switch (isXTurn)
            {
                case true:
                    button.Text = "X";
                    break;
                case false:
                    button.Text = "O";
                    break;
            }

            moveCount++;

            // �������� �� ������
            if (CheckForWinner())
            {
                string winner;
                if (isXTurn)
                    winner = "X";
                else
                    winner = "O";

                MessageBox.Show($"����� {winner} ������!", "������");
                ResetGame();
                return;
            }

            // �������� �� ���������
            if (moveCount == 9)
            {
                MessageBox.Show("������ ������� �������!", "���������");
                ResetGame();
                return;
            }

            // ����� �� ����
            isXTurn = !isXTurn;
            CurrentPlayer();
        }

        private bool CheckForWinner()
        {
            // ��������� ��������
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                UpdateScore(button1.Text);
                return true;
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                UpdateScore(button4.Text);  
                return true;
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                UpdateScore(button7.Text);  
                return true;
            }

            // ��������� ��������
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                UpdateScore(button1.Text);
                return true;
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                UpdateScore(button2.Text);
                return true;
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                UpdateScore(button3.Text);  
                return true;
            }

            // ��������� �����������
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                UpdateScore(button1.Text);
                return true;
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                UpdateScore(button3.Text);
                return true;
            }

            return false;
        }
        private void UpdateScore(string winner)
        {
            if (winner != "X" && winner != "O")
            {
                MessageBox.Show("��������� ���������!", "������");
                return;
            }

            if (winner == "X")
            {
                scorePlayer1++;
            }
            else
            {
                scorePlayer2++;
            }

            btnPlayerX.Text = $"{scorePlayer1}";
            btnPlayerO.Text = $"{scorePlayer2}";
        }

        private void ResetGame()
        {
            // ���������� �� ������ ������
            Button[] gameButtons = new[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var button in gameButtons)
            {
                button.Text = string.Empty;
            }

            // �������� �� ������������
            isXTurn = true;
            moveCount = 0;

            btnPlayerX.Text = $"{scorePlayer1}";
            btnPlayerO.Text = $"{scorePlayer2}";

            CurrentPlayer();
        }

        private void CurrentPlayer()
        {
            btnCurrentPlayer.Text = $"�� ��� � �����: {(isXTurn ? "X" : "O")}";
            btnCurrentPlayer.ForeColor = isXTurn ? Color.Blue : Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            btnNewGame.Enabled = true;

            btnPlayerX.Text = $"{scorePlayer1 - scorePlayer1}";
            btnPlayerO.Text = $"{scorePlayer2 - scorePlayer2}";

            CurrentPlayer();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            CurrentPlayer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("������ �� �� ��������� ������?", "������ ���", MessageBoxButtons.YesNo);
                if (iExit == DialogResult.Yes) 
                    Application.Exit();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "������ ���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
