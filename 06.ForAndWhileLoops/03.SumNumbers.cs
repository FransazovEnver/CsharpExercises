//Input
int number = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 1; i <= number; i++)
{
    double value = double.Parse(Console.ReadLine());
    sum += value;
}

Console.WriteLine(sum);