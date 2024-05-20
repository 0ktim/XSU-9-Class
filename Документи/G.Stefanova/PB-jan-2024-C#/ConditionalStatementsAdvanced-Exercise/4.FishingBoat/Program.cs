//1. Четем вход от конзолата
//=> бюгжет
//=> сезон
//=> брой рибари
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double price = 0;
//2. Проверяваме какъв е сезона и начисляваме наема
switch (season)
{
	case "Spring":
		price = 3000;
		break;
	case "Summer":
	case "Autumn":
		price = 4200;
		break;
	case "Winter":
		price = 2600;
		break;
}

//3. проверяваме каква ще е отстъпката спрямо броя рибари
if (fishermen <= 6)
{
	price *= 0.9; //10% discount
}
else if (fishermen <= 11)
{
	price *= 0.85; //15% discount
}
else
{
	price *= 0.75; //25% discount
}

//4. Проверяваме дали ще имат допълнителна отстъпка, ако рибарите са четен брой и не е есен
if (fishermen % 2 == 0 && season != "Autumn")
{
	price *= 0.95; //5% discount
}

//5. Проверяваме дали бюджета е достатъчен 
//=> ако е: "Yes! You have {budget - price:f2} leva left."
//=> ако не е: "Not enough money! You need {Math.Abs(budget-price):f2} leva."
if (budget >= price)
{
    Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(budget-price):f2} leva.");
}

