int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

for (int j = 2; j <= firstNumber; j+=2)
{
    for (int l = 2; l <= secondNumber; l++)
    {
        if (l == 2 || l == 3 || l == 5 || l == 7)
        {
            for (int k = 2; k <= thirdNumber; k += 2)
            {
                Console.WriteLine($"{j} {l} {k} ");
            }
        }
    }
}