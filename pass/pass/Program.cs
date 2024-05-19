namespace pass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] symbals = {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c',
                'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C',
                'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '!', '@', '#',
                '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '[', ']',
                '{', '}', ';', ':', ',', '.', '<', '>', '/', '?', '|', '\\', '~', '\''
            };
            Console.CursorVisible = false;
            string target = "Veselin&123";
            char[] guess = new char[target.Length];
            for (int i = 0; i < target.Length; i++)
            {
                guess[i] = '0';
            }
            while (true)
            {
                if (new string(guess) == target)
                {
                    Console.Clear();
                    Console.WriteLine("Correct password!");
                    Console.WriteLine(new string(guess));
                    break;
                }
                for (int i = guess.Length - 1; i >= 0; i--)
                {
                    if (guess[i] == symbals[symbals.Length - 1])
                    {
                        guess[i] = symbals[0];
                    }
                    else
                    {
                        guess[i] = symbals[Array.IndexOf(symbals, guess[i] + 1)];
                        Console.Write(new string(guess) + "\r");
                        break;
                    }
                }
            }

        }
    }
}
