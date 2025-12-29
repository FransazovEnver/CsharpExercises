//Input
string product = Console.ReadLine();
string day = Console.ReadLine();

//Logic
switch (product)
{
    case "Banana":
        if (day == "Weekday")
        {
            Console.WriteLine("2.50");
        }
        else
        {
            Console.WriteLine("2.70");
        }
        break;
    case "Apple":
        if (day == "Weekday")
        {
            Console.WriteLine("1.30");
        }
        else
        {
            Console.WriteLine("1.60");
        }
        break;
    case "Kiwi":
        if (day == "Weekday")
        {
            Console.WriteLine("2.20");
        }
        else
        {
            Console.WriteLine("3.00");
        }
        break;
}