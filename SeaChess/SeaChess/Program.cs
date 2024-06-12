namespace SeaChess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] SeaChess = { {" ", "1", "2", "3" },
                                   {"1", "_ ", "_ ", "_ " },
                                   {"2", "_ ", "_ ", "_ "  },
                                   {"3", "_ ", "_ ", "_ " } };
            DrawSeaChess();





             void DrawSeaChess() 
            {
                for (int i = 0; i < 4; i++) 
                {
                    for (int j = 0; j < 4; j++) 
                    {
                        Console.WriteLine(SeaChess[i,j]);
                    }
                }
                Console.WriteLine();
            }
    }
        }
}
