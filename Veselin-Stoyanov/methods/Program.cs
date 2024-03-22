using System.Text;

Console.OutputEncoding = Encoding.UTF8;
while (true)
{

    menu(1);

}









static void outputSequentially1To24()
{

    Console.Write("Числата от 1 до 24 последователно са: ");

    for (int i = 1; i <= 24; i++)
    {

        if (i != 24)
        {

            Console.Write($"{i}, ");

        }
        else
        {

            Console.Write($"{i}.");

        }
    }
}









static void sum()
{

    Console.Write("Сбора на числата от 1 до 24 е: ");

    int result = 0;

    for (int i = 1; i <= 24; i++)
    {

        result = result + i;

    }

    Console.Write($"{result}");
}









static void even()
{

    Console.Write("Четните числа от 1 до 24 са: ");

    for (int i = 1; i <= 24; i++)
    {

        if (i % 2 == 0)
        {

            if (i != 24)
            {

                Console.Write($"{i}, ");

            }
            else
            {

                Console.WriteLine($"{i}.");

            }
        }
    }
}









static void odd()
{

    Console.Write("Нечетните числа от 1 до 24 са: ");

    for (int i = 1; i <= 24; i++)
    {

        if (i % 2 != 0)
        {

            if (i != 23)
            {

                Console.Write($"{i}, ");

            }
            else
            {

                Console.Write($"{i}.");

            }
        }
    }
}
static int menu(int a)
{
    Console.SetCursorPosition(26, 0);

    Console.WriteLine("Меню:");

    Console.WriteLine();

    Console.WriteLine("Натиснете 1 за извеждане на числата от 1 до 24. ");

    Console.WriteLine("Натиснете 2 за извеждане на сумата на числата от 1 до 24.");

    Console.WriteLine("Натиснете 3 за извеждане на четните числа от 1 до 24.");

    Console.WriteLine("Натиснете 4 за извеждане на нечетните числа от 1 до 24.");

    Console.Write("Въведете число от 1 до 4: ");

    a = int.Parse(Console.ReadLine());

    Console.WriteLine();

    Console.WriteLine();

    Thread.Sleep(500);

    Console.Clear();
    switch (a)
    {
        case 1:
            outputSequentially1To24();
            break;
        case 2:
            sum();
            break;
        case 3:
            even();
            break;
        case 4:
            odd();
            break;
        default:
            Console.Write("Грешка! Моля, въведете валидно число от 1 до 4.");
            break;
    }

    Thread.Sleep(10000);

    Console.Clear();

    return a;
}