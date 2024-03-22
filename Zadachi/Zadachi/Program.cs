// See https://aka.ms/new-console-template for more information
Console.WriteLine("Въведете векове");
int centuries = int.Parse(Console.ReadLine());
int years = centuries * 100;
int days = (int)(years * 365.2422);
int hours = days * 24;
int minutes = hours * 60;
Console.Write($"centuries  {centuries} = years  {years} = days  {days} = minutes  {minutes}");

