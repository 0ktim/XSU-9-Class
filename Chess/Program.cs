namespace _01.Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] chess = { {"_ ", "_ ", "_" },
                                {"_ ", "_ ", "_"},
                                {"_ ", "_ ", "_"} };

            string player = "X";
            bool winner = false;
            string move = string.Empty;
            int row;
            int col;

            while (!winner)
            {
                Print(chess);
                Player();
                Winner();
                if (winner)
                {
                    break;
                }
            }

            void Print(string[,] chess)
            {
                Console.Clear();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(chess[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            void Player()
            {
                move = Console.ReadLine();
                row = int.Parse(move.Substring(0, 1));
                col = int.Parse(move.Substring(0, 1));

                if (row >= 1 && row <= 3 && col >= 1 && col <= 3 && chess[row, col] == "_ ")
                {
                    chess[row, col] = player + " ";
                }
                else if (chess[row, col] == "X " || chess[row, col] == "O")
                {
                    Console.WriteLine("Грешка!");
                }
            }

            void Winner()
            {
                for (int i = 0; i < 3; i++)
                {
                    if (chess[i, 0] == move && chess[i, 1] == move && chess[i, 2] == move)
                    {
                        Console.WriteLine($"Winner: {player}");
                    }
                }
                for (int j = 0; j < 3; j++)
                {
                    if (chess[j, 0] == move && chess[j, 1] == move && chess[j, 2] == move)
                    {
                        Console.WriteLine($"Winner: {player}");
                    }
                }
                Console.WriteLine($"Winner: {player}");
            }
        }
    }
}
