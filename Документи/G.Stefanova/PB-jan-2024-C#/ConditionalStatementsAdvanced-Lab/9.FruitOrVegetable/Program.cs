string fruitsOrVegs = Console.ReadLine();

if (fruitsOrVegs == "banana" || fruitsOrVegs == "apple" || fruitsOrVegs  == "kiwi" || fruitsOrVegs == "cherry" || fruitsOrVegs == "lemon" || fruitsOrVegs == "grapes")
    Console.WriteLine("fruit");
else if (fruitsOrVegs == "tomato" || fruitsOrVegs == "cucumber" || fruitsOrVegs == "pepper" || fruitsOrVegs == "carrot")
    Console.WriteLine("vegetable");
else
    Console.WriteLine("unknown");
