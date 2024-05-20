string typeFlower = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double pricePerOneRose = 5.00;
double pricePerOneTulip = 2.80;
double pricePerOneNarcis = 3.00;
double discount = 0.00;

if (typeFlower == "Рози")
{
	if (quantity >= 80)
	{
        discount = pricePerOneRose * 0.9;
	}
    else
    {
        discount = pricePerOneRose * quantity;
    }
}
if (typeFlower == "Лалета")
{
    if (quantity >= 50)
    {
        discount = pricePerOneTulip * 0.85;
    }
    else
    {
        discount = pricePerOneTulip * quantity;
    }
}
if (typeFlower == "Нарциси")
{
    if (quantity <= 120)
    {
        discount = pricePerOneNarcis * 1.15;
    }
    else
    {
        discount = pricePerOneNarcis * quantity;
    }
}
double finalPrice = discount * quantity;
if (budget >= finalPrice)
{
    Console.WriteLine($"Ще имате страхотна градина с {quantity} {typeFlower} на цена {finalPrice:f2} лв.");
}

else if (budget < finalPrice)
{
    double needMoney = finalPrice - budget;
    Console.WriteLine($"Парите не са достатъчни, липсват ви {needMoney:f2} лв.");
}