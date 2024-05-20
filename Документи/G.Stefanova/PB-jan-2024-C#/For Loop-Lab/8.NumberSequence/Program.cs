int n = int.Parse(Console.ReadLine());

int maxNumber = int.MinValue;
int minNumber = int.MaxValue;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

	if (currentNumber > maxNumber)
	{
		maxNumber = currentNumber;
	}

	if (currentNumber < minNumber)
	{
		minNumber = currentNumber;
	}
}

Console.WriteLine($"Max number: {maxNumber}");
Console.WriteLine($"Min number: {minNumber}");