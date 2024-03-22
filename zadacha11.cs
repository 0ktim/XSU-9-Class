// See https://aka.ms/new-console-template for more information
int[] nums = { 2, 4, 6, 8, };
foreach (var item in nums)
{
    Console.WriteLine(item);
}
Console.WriteLine("Има ли в масиво числото:");
int number = int.Parse(Console.ReadLine());
foreach (var item in nums)
{
    if (number == item)
    {
        Console.WriteLine("True");
    }
    else if (number == item)
    {
        Console.WriteLine("False");
    }
}