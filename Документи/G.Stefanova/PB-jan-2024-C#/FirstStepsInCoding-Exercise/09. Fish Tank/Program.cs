double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());
double vAquarium = length * width * height;
double vLitres = vAquarium * 0.001;
double place = percent * 0.01;
double needLitres = vLitres * (1 - place);
Console.WriteLine(needLitres);