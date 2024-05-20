namespace Ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] numbers = { '1', '2', '3', '4', '5', '6'};
            char num = '1';

            foreach (var item in numbers)
            {
                if (num == item)
                {
                    Console.WriteLine("Ima takova element!");
                    break;
                }
                else
                {
                    Console.WriteLine("Nqma takova element!");
                    break;
                }
                
            }
        }
    }
}
