//Input
int numberN = int.Parse(Console.ReadLine());
int numberP = int.Parse(Console.ReadLine());

//logic

int result = 1;

for (int i = 0; i < numberP; i++)
{
    result *= numberN;
}

Console.WriteLine(result);