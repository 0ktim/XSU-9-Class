double pciPriceDollar = double.Parse(Console.ReadLine());
double vcardPriceDollar = double.Parse(Console.ReadLine());
double ramPriceDollar = double.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine());

double pciPrice = pciPriceDollar * 1.57;
double vcardPrice = vcardPriceDollar * 1.57;
double ramPrice = ramPriceDollar * 1.57;
double sumRamPrice = ramPrice * ram;
double pciDiscount = pciPrice - (pciPrice * discount);
double priceVCard = vcardPrice - (vcardPrice * discount);

double sum = pciDiscount + priceVCard + sumRamPrice;

Console.WriteLine($"Money needed - {sum:f2} leva.");