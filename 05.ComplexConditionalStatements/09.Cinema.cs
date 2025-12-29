//Input
string movieType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

double moveiPrice = 0;
//Logic
if (movieType == "Premiere")
{
    moveiPrice = 12.00;
}
else if (movieType == "Normal")
{
    moveiPrice = 7.50;
}
else if (movieType == "Discount")
{
    moveiPrice = 5.00;
}

double totalAllSeats = rows * seats * moveiPrice;

Console.WriteLine($"{totalAllSeats:F2}");