int[] num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Console.WriteLine($"min = {num.Min()}");
Console.WriteLine($"max = {num.Max()}");
Console.WriteLine($"sum = {num.Sum()}");
Console.WriteLine($"Average = {num.Average()}");