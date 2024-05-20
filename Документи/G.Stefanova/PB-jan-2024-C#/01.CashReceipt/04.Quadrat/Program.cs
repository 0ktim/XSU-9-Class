int input = int.Parse(Console.ReadLine());
PrintHeaderFooter(input);
PrintMiddleRow(input);
PrintFloorFooter(input);
static void PrintHeaderFooter(int n)
{
    Console.WriteLine(new string('-', 2 * n));
}
static void PrintMiddleRow(int n)
{
    Console.Write("-");
    for (int i = 0; i < n - 1; i++)
    {
        Console.Write("\\/");
    }
    Console.Write("-");
    Console.WriteLine();
}
static void PrintFloorFooter(int n)
{
    Console.WriteLine(new string('-', 2 * n));
}