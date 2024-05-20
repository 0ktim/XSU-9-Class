//class FiveSpecialLetters 
//{
//    public static List<char> chars = new List<char> { 'a', 'b', 'c', 'd', 'e' };
//    public static List<int> weights = new List<int> { 5, -12, 47, 7, -32 };
//    static void Main(string[] args)
//    {
//        int firstLetter = int.Parse(Console.ReadLine());
//        int lastLetter = int.Parse(Console.ReadLine());
//        bool answer = false;

//        for (char a = 'a'; a < 'e'; a++)
//        {
//            for (char b = 'b'; b < 'e'; b++)
//            {
//                for (char c = 'c'; c < 'e'; c++)
//                {
//                    for (char d = 'd'; d < 'e'; d++)
//                    {
//                        for (char e = 'e'; e < 'e'; e++)
//                        {
//                            string specialLetters = a.ToString() + b.ToString() + c.ToString() + d.ToString() + e.ToString();
//                            if (answer(CalculateWeight(specialLetters), firstLetter, lastLetter))
//                            {
//                                answer = true;
//                                Console.Write(specialLetters + " ");
//                            }
//                    }
//                }
//            }
//        }
//    }
//}


////int firstNumber = int.Parse(Console.ReadLine());
////int secondNumber = int.Parse(Console.ReadLine());

////for (int i = 0; i < 5; i++)
////{
////	for (int k = 0; k < 5; k++)
////	{
////		for (int j = 0; j < 5; j++)
////		{
////            for (int p = 0; p < 5; p++)
////            {
////                for (int t = 0; t < 5; t++)
////                {
////                    string pattern = "abcde";
////                    string current = "" +
////                        pattern[i] +
////                        pattern[k] +
////                        pattern[j] +
////                        pattern[p] +
////                        pattern[t];

////                    string unique = "" + current[0];
////                    if (unique.IndexOf(current[1] == -1)
////                    {

////                    }
////                }
////            }
////        }
////	}
////}