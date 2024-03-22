int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

foreach (int i in num)
{
    Console.WriteLine(i);
}

Console.WriteLine();
Console.WriteLine("Въведете число:");

int number = int.Parse(Console.ReadLine());

bool check = false;
foreach (int n in num)
{
    if (n== number)
    {
        check = true;
    }
}

    if (check)
    {
        Console.WriteLine("Има");
    }

    else 
    {
        Console.WriteLine("Няма");
    }