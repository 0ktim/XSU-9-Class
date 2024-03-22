int[] num1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

foreach (int i in num1)
{
    Console.WriteLine(i);
}
Console.WriteLine();
Console.WriteLine("Vuvedi mi chislo:");
int num2 = int.Parse(Console.ReadLine());
bool a = false;
foreach (int j in num1)
{
    if (j == num2)
    {
        a = true;
    }
}
if (a)
{ 
    Console.WriteLine("Ima!"); 
}
else
{
    Console.WriteLine("Nqma!");
}