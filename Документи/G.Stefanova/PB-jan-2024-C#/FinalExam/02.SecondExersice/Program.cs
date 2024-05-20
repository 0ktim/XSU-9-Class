double width = double.Parse(Console.ReadLine());
double length = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double peopleHigh = double.Parse(Console.ReadLine());

double spaceship = width * length * height;
double room = (peopleHigh + 0.40) * 2 * 2;
double space = Math.Floor(spaceship / room);

if (space < 3)
{
    Console.WriteLine($"The spacecraft is too small.");
}
else if (space > 10)
{
    Console.WriteLine($"The spacecraft is too big.");
}
else if (space < 10  || space > 3)
{
    Console.WriteLine($"The spacecraft holds {space} astronauts.");
}