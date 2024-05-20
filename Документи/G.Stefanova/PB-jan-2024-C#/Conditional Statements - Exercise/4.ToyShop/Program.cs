using System.ComponentModel.Design;

double priceTrip = double.Parse(Console.ReadLine());
int puzzle = int.Parse(Console.ReadLine());
int doll = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int camions = int.Parse(Console.ReadLine());

//double puzzlePrice = 2.60;
//double dollPrice = 3.00;
//double bearsPrice = 4.10;
//double minionsPrice = 8.20;
//double camionsPrice = 2.00;

double allPuzzles = puzzle * 2.60;
double allDolls = doll * 3.00;
double allBears = bears * 4.10;
double allMinons = minions * 8.20;
double allCamions = camions * 2.00;
double toysPrice = allPuzzles + allDolls + allBears + allMinons + allCamions;
int allToys = puzzle + doll + bears + minions + camions;
if (allToys >= 50)
{
    toysPrice = 0.75 * toysPrice;
}
double naem = toysPrice * 0.10;
toysPrice = toysPrice - naem;
if (toysPrice >= priceTrip)
{
    double leftMoney = toysPrice - priceTrip;
    Console.WriteLine($"Yes! {Math.Abs(leftMoney):f2} lv left.");
}
else
{
    double needMoney = priceTrip - toysPrice;
    Console.WriteLine($"Not enough money! {Math.Abs(needMoney):f2} lv needed.");
}
//if (allSumToys >= 50)
//{
//    realPrice = 0.75 * realPrice;
//    if (priceTrip <= realPrice)
//    {
//        Console.WriteLine($"Yes! {realPrice - priceTrip} lv left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money! {priceTrip - realPrice} lv needed.");
//    }
//}

//else
//{
//    realPrice = allSumToys - allToys * 0.1;
//    if (priceTrip <= realPrice)
//    {
//        Console.WriteLine($"Yes! {realPrice - priceTrip} lv left.");
//    }
//    else
//    {
//        Console.WriteLine($"Not enough money! {priceTrip - realPrice} lv needed.");
//    }
//}