int[] num = { 2, 1, 3, 7, 5 };
int maxNum = 0;
foreach (int i in num)
{
    if (i > maxNum)
    {
        maxNum = i;
    }
}
    Console.WriteLine(maxNum);