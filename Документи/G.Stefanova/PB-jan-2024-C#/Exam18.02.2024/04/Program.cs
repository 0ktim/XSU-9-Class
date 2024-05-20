int days = int.Parse(Console.ReadLine());

double liter = 0;
double degrees = 0;
double litres = 0;
double totalDegrees = 0;
double drink = 0;
string result = " ";

for (int i = 0; i < days; i++)
{
    liter = double.Parse(Console.ReadLine());
    degrees = double.Parse(Console.ReadLine());

    drink += liter * degrees;
    litres += liter;
}

totalDegrees = drink / litres;

if (totalDegrees < 38)
{
    result = "Not good, you should baking!";
}
else if (totalDegrees >= 38 && totalDegrees <= 42)
{
    result = "Super!";
}
else
{
    result = "Dilution with distilled water!";
}

Console.WriteLine($"Liter: {litres:f2}");
Console.WriteLine($"Degrees: {totalDegrees:f2}");
Console.WriteLine(result);