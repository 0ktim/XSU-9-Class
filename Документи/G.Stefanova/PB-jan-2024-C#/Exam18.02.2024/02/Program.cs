double money = double.Parse(Console.ReadLine());
double moneyPerDay = double.Parse(Console.ReadLine());
double minusMoney = double.Parse(Console.ReadLine());
double giftPrice = double.Parse(Console.ReadLine());

double savedMoney = 5 * money;
double winMoney = 5 * moneyPerDay;
double allMoney = savedMoney + winMoney;
double minusAllMoney = allMoney - minusMoney;

if (minusAllMoney >= giftPrice)
{
    Console.WriteLine($"Profit: {minusAllMoney:f2} BGN, the gift has been purchased.");
}

else
{
    double needMoney = giftPrice - minusAllMoney;
    Console.WriteLine($"Insufficient money: {needMoney:f2} BGN.");
}