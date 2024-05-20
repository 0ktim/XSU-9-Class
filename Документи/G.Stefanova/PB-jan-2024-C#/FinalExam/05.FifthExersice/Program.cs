string input = Console.ReadLine();
int ages = 0;
int toyPrice = 5;
int sweaterPrice = 15;
int kids = 0;
int adults = 0;
int toysMoney = 0;
int sweaterMoney = 0;

while (input != "Christmas")
{
    ages = int.Parse(input);

    if (ages <= 16)
    {
        kids++;
        toysMoney += toyPrice;
    }
    else
    {
        adults++;
        sweaterMoney += sweaterPrice;
    }

    input = Console.ReadLine();

    if ("Christmas" == input)
    {
        break;
    }
}

Console.WriteLine($"Number of adults: {adults}");
Console.WriteLine($"Number of kids: {kids}");
Console.WriteLine($"Money for toys: {toysMoney}");
Console.WriteLine($"Money for sweaters: {sweaterMoney}");