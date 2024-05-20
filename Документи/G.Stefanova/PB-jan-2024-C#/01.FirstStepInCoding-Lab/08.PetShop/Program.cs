int foodForDogs = int.Parse(Console.ReadLine());
int foodForCats = int.Parse(Console.ReadLine());
double dogsFood = 2.50;
double catsFood = 4.00;
double allFoodDogs = dogsFood * foodForDogs;
double allFoodCats = catsFood * foodForCats;
double allFood = allFoodCats + allFoodDogs;
Console.WriteLine($"{allFood} lv.");