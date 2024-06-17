namespace zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Chess = {
                                  {"  ", "1 ", "2 ", "3 " },
                                     {"1 ", "_ ", "_ ", "_ " },
                                     {"2 ", "_ ", "_ ", "_ "  },
                                     {"3 ", "_ ", "_ ", "_ " }};
            string player2 = "X";
            bool Won = false;
            while (!Won)
            {
                print();
                player();
                Won = proverka();
                if (!Won)
                {
                    switchplayer();
                }

            }



            void print()
            {

                Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(Chess[i, j]);
                    }
                    Console.WriteLine();
                }

            }
            void player()
            {
                Console.WriteLine("Въведете ход:");
                string Move = Console.ReadLine();
                int row = int.Parse(Move[0].ToString());
                int col = int.Parse(Move[1].ToString());

                if (row >= 1 && row <= 3 && col >= 1 && col <= 3 && Chess[row, col] == "_ ")
                {
                    Chess[row, col] = player2 + " ";
                }
                else if (Chess[row, col] == "X " || Chess[row, col] == "O ")
                {
                    Console.WriteLine("Въведете свободна колона или ред!");
                    Thread.Sleep(1000);
                }
            }


            void switchplayer()
            {


                if (player2 == "X")
                {
                    player2 = "O";
                }
                else
                {
                    player2 = "X";
                }
            }
            bool proverka()
            {

                for (int i = 1; i < 4; i++)
                {

                    if ((Chess[i, 1] == Chess[i, 2] && Chess[i, 2] == Chess[i, 3] && Chess[i, 1] != "_ ") ||
                    (Chess[1, i] == Chess[2, i] && Chess[2, i] == Chess[3, i] && Chess[1, i] != "_ "))
                    {
                        return true;
                    }
                }

                if ((Chess[1, 1] == Chess[2, 2] && Chess[2, 2] == Chess[3, 3] && Chess[1, 1] != "_ ") ||
                (Chess[1, 3] == Chess[2, 2] && Chess[2, 2] == Chess[3, 1] && Chess[1, 3] != "_ "))
                {
                    return true;
                }
                return false;
            }
            Console.WriteLine($"Победителя е: {player2}!");
        }
    }
}