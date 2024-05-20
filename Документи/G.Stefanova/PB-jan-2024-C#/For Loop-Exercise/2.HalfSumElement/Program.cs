//1. Четем n от конзолата 
int n = int.Parse(Console.ReadLine());

//2. Създаваме 2 променливи, които да пазят сумата на всички числа и maxNum
int sum = 0;
int maxNum = int.MinValue;

//3. Създаваме цикъл, който да се изпълнява n на брой пъти 
for (int i = 1; i <= n; i++)
{
    //=> четем число от конзолата
    int num = int.Parse(Console.ReadLine());
    //=> добавяме числото към сумата на всички числа
    sum += num;
    //=> проверяваме дали е най-голямото число въведено до момента
    if (num > maxNum)
    {
    //====> ако е: maxNum = това число
        maxNum = num;
    }
}

//4. Проверяваме дали сумата на всички останали числа = maxNum
//===> всички числа - maxNum
sum -= maxNum;

//5. Проверяваме дали сумата на другите числа е равна на maxNum
if (sum == maxNum)
{
//==> ako e; "Yes {sum}"
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
//==> ако не е: "No, diff = {difference}"
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sum - maxNum)}");
}