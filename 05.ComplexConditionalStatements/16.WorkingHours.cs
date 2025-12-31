//Input
int hourOfTheDay = int.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

//Logic

if (dayOfTheWeek == "Sunday" || hourOfTheDay < 10 || hourOfTheDay > 18)
{
    Console.WriteLine("closed");
}
else
{
    Console.WriteLine("open");
}