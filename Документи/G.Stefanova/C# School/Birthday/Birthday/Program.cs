namespace Birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                int[] nums = new int[50];
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("Пожелание");
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.SetCursorPosition(40, 7);
                    Console.WriteLine(
                              @"Честит рожден ден! Най-готиния клас
                                        поздравява най-готиния учител!
                                        Нека срещу Вас винаги да стоят
                                        жадни за знания ученици, с които
                                        работата ви да спори и да бъде
                                        истинско удоволствие! Бъдете здрав,
                                        щастлив, все така усмихнат и много
                                        обичан! Пожелаваме Ви да сте все така
                                        усмихнат и лъчезарен!");
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
                        Console.SetCursorPosition(50, 0);
                        Console.WriteLine("Пожелание");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.SetCursorPosition(40, 7);
                        Console.WriteLine(
                                  @"Честит рожден ден! Най-готиния клас
                                        поздравява най-готиния учител!
                                        Нека срещу Вас винаги да стоят
                                        жадни за знания ученици, с които
                                        работата ви да спори и да бъде
                                        истинско удоволствие! Бъдете здрав,
                                        щастлив, все така усмихнат и много
                                        обичан! Пожелаваме Ви да сте все така
                                        усмихнат и лъчезарен!");
                        Console.SetCursorPosition(42, 20);
                        Console.WriteLine("Happy Birthday Mr.Zhelev!");
                    }
                }
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.SetCursorPosition(80, 23);
                Console.WriteLine(@"                                                                                                                                       9а клас");
            }
        }
    }
}

