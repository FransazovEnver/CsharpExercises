//Input 
string ticketPrice = Console.ReadLine();

//Logic
if (ticketPrice == "student")
{
    Console.WriteLine("$1.00");
}
else if (ticketPrice == "regular")
{
    Console.WriteLine("$1.60");
}
else
{
    Console.WriteLine("Invalid ticket type!");
}