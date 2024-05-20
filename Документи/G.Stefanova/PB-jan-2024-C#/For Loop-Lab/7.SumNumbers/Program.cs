int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum += currentNumber;
}
Console.WriteLine(sum);