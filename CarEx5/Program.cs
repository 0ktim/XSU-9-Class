using CarEx5;

CarClass car1 = new CarClass();
Console.WriteLine("Напишете името на човека: ");
car1.Marka = Console.ReadLine();
Console.WriteLine("Напишете годините на човека: ");
car1.Model = Console.ReadLine();
Console.WriteLine("Напишете пола на човека: ");
car1.GodinaNaProizvodstvo = double.Parse(Console.ReadLine());
car1.WholeHuman();