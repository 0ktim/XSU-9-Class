Console.Write("Chicken menus: ");
int chickenMenus = int.Parse(Console.ReadLine());
Console.Write("Fish menus: ");
int fishMenus = int.Parse(Console.ReadLine());
Console.Write("Vegetarenian menus: ");
int vegetarenianMenus = int.Parse(Console.ReadLine());

double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarenianMenuPrice = 8.15;

double allChickenMenus = chickenMenus * chickenMenuPrice;
double allfishMenus = fishMenus * fishMenuPrice;
double allvegetarenianMenus = vegetarenianMenus * vegetarenianMenuPrice;
double allMenus = allChickenMenus + allfishMenus + allvegetarenianMenus;
double priceDessert = allMenus * 0.2;
double allOrder = allMenus + priceDessert + 2.50;

Console.WriteLine(allOrder);