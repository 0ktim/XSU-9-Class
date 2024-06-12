namespace chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string[,] Chess = {
                                  {"  ", "1 ", "2 ", "3 " },
                                     {"1 ", "_ ", "_ ", "_ " },
                                     {"2 ", "_ ", "_ ", "_ "  },
                                     {"3 ", "_ ", "_ ", "_ " }};
                string nowplayer = "v";
                bool Won = false;
                while (!Won)
                {
                    printirane();
                    player();
                    Won = proverkaforwinner();
                    if (!Won)
                    {
                        switchplayeronthechess();
                    }

                }



                void printirane()
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
                    Console.WriteLine("Моля въведете ход:");
                    string playerMove = Console.ReadLine();
                    int row = int.Parse(playerMove[0].ToString());
                    int col = int.Parse(playerMove[1].ToString());

                    if (row >= 1 && row <= 3 && col >= 1 && col <= 3 && Chess[row, col] == "_ ")
                    {
                        Chess[row, col] = nowplayer + " ";
                    }
                    else if (Chess[row, col] == "v " || Chess[row, col] == "O ")
                    {
                        Console.WriteLine("Моля въведете свободна колона или ред!");
                        Thread.Sleep(1456);
                    }
                }


                void switchplayeronthechess()
                {


                    if (nowplayer == "v")
                    {
                        nowplayer = "O";
                    }
                    else
                    {
                        nowplayer = "v";
                    }
                }
                bool proverkaforwinner()
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
                Console.WriteLine($"The big winner is: {nowplayer}!!!");

            }
        }
    }

}
    