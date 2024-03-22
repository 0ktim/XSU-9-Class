namespace _14._03._243
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            char h = 'b';
            bool b = false;
            foreach (var item in ch)
            {
                if (item == h)
                {
                    b = true;
                    break;
                }

            }
            if (b)
            {
                Console.WriteLine("Има");
            }
            else
            {
                Console.WriteLine("Няма");
            }
        }
    }
}

