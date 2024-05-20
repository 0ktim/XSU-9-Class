Console.Write("Pens - ");
int pens = int.Parse(Console.ReadLine());
Console.Write("Markers - ");
int markers = int.Parse(Console.ReadLine());
Console.Write("Litres - ");
int litresForBoard = int.Parse(Console.ReadLine());
Console.Write("Discount - ");
int discount = int.Parse(Console.ReadLine());

double onePen = 5.80;
double oneMarker = 7.20;
double oneLiter = 1.20;

double allPens = onePen * pens;
double allMarkers = oneMarker * markers;
double allLitres = oneLiter * litresForBoard;
double sum = (allLitres + allMarkers + allPens);
double sumDiscount = sum - sum * 0.25;
Console.WriteLine(sumDiscount);