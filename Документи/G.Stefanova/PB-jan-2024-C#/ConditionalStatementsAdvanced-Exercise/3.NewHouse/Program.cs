double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double summerPrice = 0;
double winterPrice = 0;
if (season == "summer")
{
    if (budget <= 100)
    {
        summerPrice = budget - (budget * 0.70);
        Console.WriteLine($"Somewhere in Bulgaria.");
        Console.WriteLine($"Camp - {summerPrice:f2}");
    }
    else if (budget <= 1000)
    {
        summerPrice = budget - (budget * 0.60);
        Console.WriteLine($"Somewhere in Balkans.");
        Console.WriteLine($"Camp - {summerPrice:f2}");
    }
    else
    {
        summerPrice = budget - (budget * 0.10);
        Console.WriteLine($"Somewhere in Europe.");
        Console.WriteLine($"Camp - {summerPrice:f2}");

    }
}
else if (season == "winter")
{
    if (budget <= 100)
    {
        winterPrice = budget - (budget * 0.30);
        Console.WriteLine($"Somewhere in Bulgaria.");
        Console.WriteLine($"Hotel - {winterPrice:f2}");
    }
    else if (budget <= 1000)
    {
        winterPrice = budget - (budget * 0.20);
        Console.WriteLine($"Somewhere in Balkans.");
        Console.WriteLine($"Hotel - {winterPrice:f2}");
    }
    else
    {
        winterPrice = budget - (budget * 0.10);
        Console.WriteLine($"Somewhere in Europe.");
        Console.WriteLine($"Hotel - {winterPrice:f2}");
    }
}