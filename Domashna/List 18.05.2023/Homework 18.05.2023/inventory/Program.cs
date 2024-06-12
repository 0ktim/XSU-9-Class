using System.Diagnostics;
using System.Xml.Linq;

namespace inventory
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
          item item = new item("one",2,3);
            Console.WriteLine("Всички налични елементи:");
            List<item> elements = new List<item>();
            elements.Add(new item("Iphone", 2500, 10000));
            elements.Add(new item("Samsung", 2000, 60000));
            elements.Add(new item("Xiaomi", 1750, 75000));
            elements.Add(new item("Huawei", 750, 5000));
            Console.WriteLine("За показване на всички елементи, натиснете 1, за добавяне на елемент, натиснете 2, за изтриване на елемент, натиснете 3, за обновяване на елемнт, натиснете 4!");
            item.answer = int.Parse(Console.ReadLine());
            while (item.answer == 1) 
            {
                List<item> list = new List<item>();
                Console.WriteLine("Въведете име,цена и количество:");
                list.Add(new item(Console.WriteLine("Въведете име на продукт:"),Console.ReadLine(), Console.WriteLine("Въведете цена на продукт:"), int.Parse(Console.ReadLine()),  int.Parse(Console.ReadLine()))); ;
                Console.WriteLine("Успешно влизане!");
                Thread.Sleep(1000);
              ;

            }
        }
    }
}