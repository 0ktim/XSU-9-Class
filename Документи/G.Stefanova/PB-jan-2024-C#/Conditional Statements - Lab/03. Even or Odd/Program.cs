int number = int.Parse(Console.ReadLine());
//1.2 => 0 (1); 2/2 = 1 (0); 3/2 => 1(1); 4/2 => 2(0); 5/2 => 2(1)

if (number % 2 == 0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}