//1.Необходимо количество найлон(в кв.м.) -цяло число в интервала [1... 100]
//2.Необходимо количество боя(в литри) -цяло число в интервала [1…100]
//3.Количество разредител(в литри) - цяло число в интервала [1…30]
//4.Часовете, за които майсторите ще свършат работата - цяло число в интервала [1…9]
//•	Предпазен найлон - 1.50 лв. за кв. метър
//•	Боя - 14.50 лв. за литър
//•	Разредител за боя - 5.00 лв. за литър



double nylon = double.Parse(Console.ReadLine());
double paint = double.Parse(Console.ReadLine());
double thiner = double.Parse(Console.ReadLine());
double hours = double.Parse(Console.ReadLine());

double priceNylon = (nylon * 1.50) + 3;
double pricePaint = paint * 14.50;
double priceThiner = thiner * 5;
double bag = 0.40;
double pPaint = pricePaint * 0.1;
double priceAllMats = priceNylon + pricePaint + pPaint + priceThiner + bag;
double oneHourWork = priceAllMats * 0.3;
double priceWorkers = oneHourWork * hours;
double all = priceAllMats + priceWorkers;
Console.WriteLine(all);