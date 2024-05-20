//1.Четем число от конзолата
int n = int.Parse(Console.ReadLine());

//2.Създаваме променливи за броя на числата
int countP1 = 0;
int countP2 = 0;
int countP3 = 0;
int countP4 = 0;
int countP5 = 0;

//3.Създаваме цикъл, който да се изпълнява n брой пъти
for (int i = 1; i <= n; i++)
{
//=> четем число от конзолата
    int num = int.Parse(Console.ReadLine());
//=> проверяваме в кой диапазон попада
//===> 1-199 => р1++
	if (num < 200)
	{
		countP1++;
	}
//===> 200-399 => р2++
	else if (num < 400)
	{
		countP2++;
	}
//===> 400-599 => р3++
    else if (num < 600)
    {
        countP3++;
    }
//===> 600-799 => р4++
    else if (num < 800)
    {
        countP4++;
    }
//===> 800-1000 => р5++
	else
	{
		countP5++;
	}
}

//4.Отпечатваме резултата на конзолата в %
//==> р1 / 28 * 100 = Result: {f2}%
Console.WriteLine($"{(double)countP1/n*100:f2}%");
Console.WriteLine($"{(double)countP2/n*100:f2}%");
Console.WriteLine($"{(double)countP3/n*100:f2}%");
Console.WriteLine($"{(double)countP4/n*100:f2}%");
Console.WriteLine($"{(double)countP5/n*100:f2}%");