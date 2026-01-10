//Input

int n = int.Parse(Console.ReadLine());

//Logic

for (int number = 1 ;number <= n ; number = number * 2 + 1)
{
    Console.WriteLine(number);
}