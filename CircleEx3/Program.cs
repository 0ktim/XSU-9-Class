using CircleEx3;

Console.WriteLine("Радиус:");
double radius = double.Parse(Console.ReadLine());
CircleClass circle = new CircleClass(radius);
double obikolka = circle.Obikolka();
double lice = circle.Lice();
Console.WriteLine($"Обиколка: {obikolka}");
Console.WriteLine($"Лице: {lice}");
Console.ReadLine();