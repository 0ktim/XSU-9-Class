double budgetFilm = double.Parse(Console.ReadLine());
int statistics = int.Parse(Console.ReadLine());
double outfitPrice = double.Parse(Console.ReadLine());

double budgetDecor = budgetFilm * 0.1;
double priceClothes = statistics * outfitPrice;
if (statistics >= 150)
    {
      priceClothes = priceClothes * 0.9;
    }
double decorAndOutfit = budgetDecor + priceClothes;
if (decorAndOutfit > budgetFilm)
    {
    double need = decorAndOutfit - budgetFilm;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {need:f2} leva more.");
    }
else if (decorAndOutfit <= budgetFilm)
    {
    double left = budgetFilm - decorAndOutfit;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {left:f2} leva left.");
    }

