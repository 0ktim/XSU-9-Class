Console.Write("Въведете тип прожекция: ");
string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());
double price = 0;

if (type == "Premiere")
{
    price = 12.00;
}
else if (type == "Normal")
{
    price = 7.50;
}
else if (type == "Discount")
{
    price = 5.00;
}

double income = price * (rows * cols);
Console.WriteLine($"{income:f2}");