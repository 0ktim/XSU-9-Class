double budget = double.Parse(Console.ReadLine());
int videocards = int.Parse(Console.ReadLine());
int cpu = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

double videocardsCost = videocards * 250;
double cpuPricePerOne = videocardsCost * 0.35;
double cpuPrice = cpuPricePerOne * cpu;
double ramPricePerOne = videocardsCost * 0.10;
double ramPrice = ramPricePerOne * ram;

double sumNeed = videocardsCost + cpuPrice + ramPrice;

if (videocards > cpu)
{
    sumNeed = sumNeed - (sumNeed * 0.15);
}
if (sumNeed < budget)
{
    Console.WriteLine($"You have {Math.Abs(sumNeed - budget):f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(budget - sumNeed):f2} leva more!");
}