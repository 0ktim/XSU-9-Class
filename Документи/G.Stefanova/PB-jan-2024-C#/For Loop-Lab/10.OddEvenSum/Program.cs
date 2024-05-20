int num = int.Parse(Console.ReadLine());
int sumEven = 0;
int sumOdd = 0;
for (int i = 0; i < num; i++)
{
    int typeNumber = int.Parse(Console.ReadLine());
	if (i % 2 == 0)
	{
		sumEven += typeNumber;
	}
	else if (i % 2 != 0)
	{
        sumOdd += typeNumber;
    }
}
if (sumEven == sumOdd)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sumEven}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sumEven - sumOdd)}");
}