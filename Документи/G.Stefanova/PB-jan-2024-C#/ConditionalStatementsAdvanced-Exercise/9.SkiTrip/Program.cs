//50% working...
int days = int.Parse(Console.ReadLine());
string room = Console.ReadLine();
string opinion = Console.ReadLine();

double price = 0.00;
double nights = days - 1;
double totalPrice = 0;

if (room == "room for one person")
{
    price = 18;
    totalPrice = nights * price;
}
else if (room == "apartment")
{
    price = 25;
    if (days <= 10)
    {
        price *= 0.70;
    }
    else if (days <= 15 || days >= 10)
    {
        price *= 0.65;
    }
    else if (days > 15)
    {
        price *= 0.50;
    }
    totalPrice = nights * price;
}
else if (room == "president apartment")
{
    if (days <= 10)
    {
        price *= 0.90;
    }
    else if (days < 15 || days > 10)
    {
        price *= 0.85;
    }
    else 
    {
        price *= 0.80;
    }
    totalPrice = nights * price;
}

if (opinion == "positive")
{
    totalPrice = totalPrice + 0.25 * totalPrice;
    Console.WriteLine($"{totalPrice:f2}");
}
else if (opinion == "negative")
{
    totalPrice = totalPrice - 0.10 * totalPrice;
    Console.WriteLine($"{totalPrice:f2}");
}

