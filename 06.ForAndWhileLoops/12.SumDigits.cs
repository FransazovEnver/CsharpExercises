//Input
int digit = int.Parse(Console.ReadLine());

//Logic
int sum = 0;

while (digit > 0)
{
    int lastDigit = digit % 10;
    sum += lastDigit;
    digit /= 10;
}

Console.WriteLine(sum);

