PrintReceipt();
static void PrintReceipt()
{
    PrintReceiptHeader();
    PrintReceiptMiddle();
    PrintReceiptEnd();
}

static void PrintReceiptHeader()
{
    Console.WriteLine("CASH RECEIPT");
    Console.WriteLine("---------------------------------");
}
static void PrintReceiptMiddle()
{
    Console.WriteLine("Charged to_______________________");
    Console.WriteLine("Received to_______________________");
}
static void PrintReceiptEnd()
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("(c) SoftUni");
}