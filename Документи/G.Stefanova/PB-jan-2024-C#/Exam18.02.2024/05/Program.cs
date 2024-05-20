double startHeight = 5364;
double endHeight = 8848;
double currentHeight = 0;
int days = 1;
string input = " ";

while (input != "END")
{
    input = Console.ReadLine();

    if (input == "END")
    {
        break;
    }

    if (input == "Yes")
    {
        days++;
    }

    int metres = int.Parse(Console.ReadLine());
    currentHeight += metres;

    if (currentHeight + startHeight >= endHeight) 
    {
        break;
    }
    if (days >= 5)
    {
        break;
    }

}

if (startHeight + currentHeight < endHeight)
    {
    Console.WriteLine("Failed!");
    double meter = startHeight + currentHeight;
    Console.WriteLine($"{meter}");
    }
else
   {
    Console.WriteLine($"Goal reached for {days} days!");
   }