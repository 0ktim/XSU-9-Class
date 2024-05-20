string cat = Console.ReadLine();
char gender = char.Parse(Console.ReadLine());
int age = 0;

switch (cat)
{
	case "British Shorthair":
		if (gender == 'm')
			age = 13;
		else
			age = 14;
		break;
    case "Siamese":
        if (gender == 'm')
            age = 15;
        else
            age = 16;
        break;
    case "Persian":
        if (gender == 'm')
            age = 14;
        else
            age = 15;
        break;
    case "Ragdoll":
        if (gender == 'm')
            age = 16;
        else
            age = 17;
        break;
    case "American Shorthair":
        if (gender == 'm')
            age = 12;
        else
            age = 13;
        break;
    case "Siberian":
        if (gender == 'm')
            age = 11;
        else
            age = 12;
        break;
    default:
        Console.WriteLine($"{cat} is invalid cat!");
        return;
}

double peopleMonth = age * 12;
double catMonths = peopleMonth / 6;

Console.WriteLine($"{catMonths} cat months");