//Input 
int num = int.Parse(Console.ReadLine());
int temp = num;

bool isSpecial = false;

while (temp > 0)
{
    int lastNumber = temp % 10;

    temp = temp / 10;

    if (num % lastNumber != 0)

        break;
}

if (isSpecial)
{
    Console.WriteLine($"{num} is special");
}
else
{
    Console.WriteLine($"{num} is not special");
}