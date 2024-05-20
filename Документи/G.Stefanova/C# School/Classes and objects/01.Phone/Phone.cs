using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phone
{
    internal class Phone
    {
        private string model { get; set; }
        private string manufacturer { get; set; }
        private int price { get; set; }
        private double size { get; set; }
        private string color { get; set; }
        private string owner { get; set; }
        
        public void PhoneInformation()
        {
            model = "IPhone";
            manufacturer = "Apple";
            price = 1460;
            size = 14;
            color = "Black";
            owner = "Olivia Rodrigo";
            Console.WriteLine(string.Join(", ", model, manufacturer, price, size, color, owner));
        }
        public void IPhoneInformation(string modelIPhone, string manufacturerIPhone, int priceIPhone, double sizeIPhone, string colorIPhone, string ownerIPhone)
        {
            model = modelIPhone;
            manufacturer = manufacturerIPhone;
            price = priceIPhone;
            size = sizeIPhone;
            color = colorIPhone;
            owner = ownerIPhone;
        }

    }
}
