//Input 
string season = Console.ReadLine();
string type = Console.ReadLine();
int countOfTheDays = int.Parse(Console.ReadLine());

double discount = 0;
int priceForDay = 0;

//Logic
if (type == "Hotel")
{
    if (season == "Spring")
    {
        priceForDay = 30;
        discount = 20;
    }
    else if (season == "Summer")
    {
        priceForDay = 50;
    }
    else if (season == "Autumn")
    {
        priceForDay = 20;
        discount = 30;
    }
    else if (season == "Winter")
    {
        priceForDay = 40;
        discount = 10;
    }
}
else if (type == "Camping")
{
    if (season == "Spring")
    {
        priceForDay = 10;
        discount = 20;
    }
    else if (season == "Summer")
    {
        priceForDay = 30;
    }
    else if (season == "Autumn")
    {
        priceForDay = 15;
        discount = 30;
    }
    else if (season == "Winter")
    {
        priceForDay = 10;
        discount = 10;
    }
}

//Output
double result = priceForDay * countOfTheDays * (1 - (discount / 100));
Console.WriteLine($"{result:F2}");

/*
if (season == "Summer")
{
    double result = priceForDay * countOfTheDays;
    Console.WriteLine($"{result:F2}");
}
else
{
    double result = priceForDay * countOfTheDays * (1 - (discount / 100));
    Console.WriteLine($"{result:F2}");
}
*/

