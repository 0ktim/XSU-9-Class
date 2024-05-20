int[] numbers = new int [1001];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i;
}

foreach (var n in numbers)
{
    Console.WriteLine(n);
}
	