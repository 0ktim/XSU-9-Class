int dayOrNight = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

if (dayOrNight >= 10 && dayOrNight <= 18)
{
    switch (dayOfWeek)
    {
	    case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
        case "Saturday":
            Console.WriteLine("open");
            break;
        default:
            Console.WriteLine("closed");
            break;
    }
}
else
{
    Console.WriteLine("closed");
}