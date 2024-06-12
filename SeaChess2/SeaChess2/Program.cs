namespace SeaChess2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] SeaChess = {
                                  {"  ", "1 ", "2 ", "3 " },
                                     {"1 ", "_ ", "_ ", "_ " },
                                     {"2 ", "_ ", "_ ", "_ "  },
                                     {"3 ", "_ ", "_ ", "_ " }};
            string currentPlayer = "X";
            bool GameWon = false;
            while (!GameWon)
            {
                DrawSeaChess();
                PlayerMove();
                GameWon = CheckForWinner();
                if (!GameWon)
                {
                    SwitchPlayer();
                }
            }

            DrawSeaChess();
            Console.WriteLine($"Играч {currentPlayer} печели!");
        }

        static void DrawSeaChess()
        {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(SeaChess[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void PlayerMove()
        {
            bool validMove = false;
            while (!validMove)
            {
                Console.WriteLine($"Играч {currentPlayer}, въведете ход (например 12 за ред 1, колона 2): ");
                string playerMove = Console.ReadLine();
                if (playerMove.Length == 2)
                {
                    try
                    {
                        int row = int.Parse(playerMove[0].ToString());
                        int col = int.Parse(playerMove[1].ToString());

                        if (row >= 1 && row <= 3 && col >= 1 && col <= 3 && SeaChess[row, col] == "_ ")
                        {
                            SeaChess[row, col] = currentPlayer + " ";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("Невалиден ход! Полето е заето или извън границите. Опитайте отново.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Невалиден вход! Въведете два номера (например 12). Опитайте отново.");
                    }
                }
                else
                {
                    Console.WriteLine("Невалиден вход! Въведете два номера (например 12). Опитайте отново.");
                }
            }
        }

        static void SwitchPlayer()
        {
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }
        }

        static bool CheckForWinner()
        {
            for (int i = 1; i < 4; i++)
            {
                // Проверка на редове и колони
                if ((SeaChess[i, 1] == SeaChess[i, 2] && SeaChess[i, 2] == SeaChess[i, 3] && SeaChess[i, 1] != "_ ") ||
                    (SeaChess[1, i] == SeaChess[2, i] && SeaChess[2, i] == SeaChess[3, i] && SeaChess[1, i] != "_ "))
                {
                    return true;
                }
            }

            // Проверка на диагонали
            if ((SeaChess[1, 1] == SeaChess[2, 2] && SeaChess[2, 2] == SeaChess[3, 3] && SeaChess[1, 1] != "_ ") ||
                (SeaChess[1, 3] == SeaChess[2, 2] && SeaChess[2, 2] == SeaChess[3, 1] && SeaChess[1, 3] != "_ "))
            {
                return true;
            }

            return false;
        }
    }
    }
}
