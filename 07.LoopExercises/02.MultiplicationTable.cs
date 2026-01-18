//Input
int number = int.Parse(Console.ReadLine());

//Logic

for (int i = 1; i <= 10; i++)
{
    int result = number * i;
    Console.WriteLine($"{number} x {i} = {result}");
}

