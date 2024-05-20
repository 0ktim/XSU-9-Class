int paintings = int.Parse(Console.ReadLine());
int wallpapers = int.Parse(Console.ReadLine());
double gloves = double.Parse(Console.ReadLine());
double brushes = double.Parse(Console.ReadLine());

double paintPrice = 21.50 * paintings;
double wallpapersPrice = 5.20 * wallpapers;
double needGloves = Math.Ceiling(wallpapers - (wallpapers * 0.35));
double needBrushes = Math.Floor(paintings - (paintings * 0.48));
double glovesPrice = needGloves * gloves;
double brushesPrice = needBrushes * brushes;
double price = paintPrice + wallpapersPrice + glovesPrice + brushesPrice;
double deliveryPrice = price / 15;

Console.WriteLine($"This delivery will cost {deliveryPrice:f2} lv.");