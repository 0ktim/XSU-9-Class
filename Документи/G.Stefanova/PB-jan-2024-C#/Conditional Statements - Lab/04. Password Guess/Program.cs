//1. Четем от конолата вида на фигурата (square, rectangle, circle or triangle)
string figure = Console.ReadLine();
//Създаваме променлива за лицето на фигурата
double area = 0;
//2. Проверяваме какъв е вида на фигурата
// => "square"
if (figure == "square")
{
    double a = int.Parse(Console.ReadLine());
    area = a * a;
}
//=> ако не е "square" проверяваме дали е "rectangle"
else if (figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    area = a * b;
}
//=> ако не е "rectangle" проверяваме дали е "circle"
else if (figure == "circle")
{
    double r = double.Parse(Console.ReadLine());
    area = Math.PI * r * r;
}
//=> ако не е "circle" проверяваме дали е "triangle"
else
{
    double a = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    area = a * h / 2;
}

//3. Oтпечатваме лицето на фигурата
Console.WriteLine($"{area:f3}");