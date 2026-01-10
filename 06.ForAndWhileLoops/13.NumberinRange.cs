//Input
int number = int.Parse(Console.ReadLine());

//Logic

while (number < 0 || number > 100)
{
	number = int.Parse(Console.ReadLine());
}
Console.WriteLine(number);