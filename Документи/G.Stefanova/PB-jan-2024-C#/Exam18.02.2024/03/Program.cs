int people = int.Parse(Console.ReadLine());
string season = Console.ReadLine();

double price = 0;

switch (season)
{
	case "spring":
		if (people <= 5)
			price = 50.00;
		else
			price = 48.00;
		break;
	case "summer":
        if (people <= 5)
            price = 48.50 * 0.85;
        else
            price = 45.00 * 0.85;
        break;
    case "autumn":
        if (people <= 5)
            price = 60.00;
        else
            price = 49.50;
        break;
    case "winter":
        if (people <= 5)
            price = 86.00 * 1.08;
        else
            price = 85.00 * 1.08;
        break;
}
double sum = people * price;
Console.WriteLine($"{sum:f2} leva.");