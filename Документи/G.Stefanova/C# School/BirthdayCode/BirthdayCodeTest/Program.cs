namespace BirthdayCodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.CursorVisible = false;
            bool check = true;
            while (check)
            {
                int[] nums = new int[50];
                for (int i = 0; i < nums.Length; i++)
                {
                    ConsoleColor randomColor = (ConsoleColor)new Random().Next(16);
                    Console.ForegroundColor = randomColor;
                    if (randomColor == ConsoleColor.Black || randomColor == ConsoleColor.Gray || randomColor == ConsoleColor.DarkGray || randomColor == ConsoleColor.DarkGreen)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("Честит рожден ден! ");
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.SetCursorPosition(40, 7);
                    Console.WriteLine(
                           @"Най-готиния клас поздравява
                                    най-готиния учител! Нека 
                                    срещу Вас винаги да стоят
                                    жадни за знания ученици, с 
                                    които работата ви да спори и 
                                    да бъде истинско удоволствие!
                                    Бъдете здрав,щастлив, все така
                                    усмихнат и много обичан!");
                }
                break;
            }
            while (true)
            {

                int day = 7;
                string month = "May";
                if (month == "May")
                {
                    if (day == 7)
                    {
                        ConsoleColor randomColor = (ConsoleColor)new Random().Next(16);
                        Console.ForegroundColor = randomColor;
                        if (randomColor == ConsoleColor.Black || randomColor == ConsoleColor.Gray || randomColor == ConsoleColor.DarkGray || randomColor == ConsoleColor.DarkGreen)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.SetCursorPosition(50, 0);
                        Console.WriteLine("Честит рожден ден! ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.SetCursorPosition(40, 7);
                        Console.WriteLine(
                            @"Най-готиния клас поздравява
                                    най-готиния учител!
                                    Нека срещу Вас винаги да стоят
                                    жадни за знания ученици, с които
                                    работата ви да спори и да бъде
                                    истинско удоволствие! Бъдете здрав,
                                    щастлив, все така усмихнат и много
                                    обичан!");
                        Console.SetCursorPosition(42, 20);
                        Console.WriteLine("Happy Birthday Mr.Zhelev!");
                    }
                }
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.SetCursorPosition(80, 23);
                Console.WriteLine(" ");                                                                                                                                     9а клас")
            }
        }
    }
}
