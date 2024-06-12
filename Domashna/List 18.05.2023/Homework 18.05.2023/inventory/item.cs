using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    internal class item
    {
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public int answer { get; set; }
        public string writeforname { get; set; }
        public int writeforprice { get; set; }
        public int writeforquantity { get; set; }

        public item( string name,  int price,  int quantity) {

            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.writeforname = writeforname;
            this.writeforprice = writeforprice;
            this.writeforquantity = quantity;

            Console.WriteLine($"{name}, price = {price}, quantity = {quantity}");






            /*
            void visititem() {
                Console.WriteLine($"{name}, price = {price}, quantity = {quantity}");
            }
            void additem() 
            {
            List<item> list = new List<item>();
                Console.WriteLine("Въведете име,цена и количество:");               
               list.Add( new item(Console.ReadLine(),int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                Console.WriteLine("Успешно влизане!");
                Thread.Sleep(1000);
                visititem();
            }
            */











        }
        
    }
}
