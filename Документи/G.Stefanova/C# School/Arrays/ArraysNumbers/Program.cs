int[] numbers = new int[5];

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}

for (int i = numbers.Length - 1; i >= 0; i--)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

foreach (var num in numbers)
{
    if (num == numbers[numbers.Length - 1])
    {
        Console.Write($"{num}.");
    }
    else
    {
        Console.Write($"{num},");
    }
}