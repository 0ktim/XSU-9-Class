﻿namespace imdone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masiv1 = { 1, 2, 3 };
            int[] masiv2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int[] masiv3 = new int[masiv1.Length + masiv2.Length];
            for (int i = 0; i < masiv1.Length; i++) 
            {

                masiv3[i] = masiv1[i];
            
            }
            for (int j = 0; j < masiv2.Length; j++)
            {

                masiv3[masiv1.Length + j] = masiv2[j];

            }

            foreach (var m in masiv3)
            {
                Console.WriteLine(m);
            }

        }
    }
}
