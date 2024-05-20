int tabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int tab = 0; tab <= tabs; tab++)
{
    string site = Console.ReadLine();

    switch (site)
    {
        case "Facebook":
            salary -= 150;
            break;
        case "Instagram":
            salary -= 100;
            break;
        case "Redit":
            salary -= 50;
            break;
        default:
            break;
    }

    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }

}

