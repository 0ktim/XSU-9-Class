namespace convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberHex = Console.ReadLine();
            int number10 = Convert.ToInt32(numberHex, 16);
            Console.WriteLine(number10);
            string numberDecimal = Console.ReadLine();
            int numberTo10 = Convert.ToInt32(numberDecimal, 2);
            Console.WriteLine(numberTo10);
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexadecimalNumber = decimalNumber.ToString("X");
            Console.WriteLine(hexadecimalNumber);
      
        }
    }
}
