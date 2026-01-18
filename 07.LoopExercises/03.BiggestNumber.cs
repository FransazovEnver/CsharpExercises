//Input
int num = int.Parse(Console.ReadLine());
int biggestNumber = int.MinValue;

//Logic

for (int i = 0; i < num; i++)
{
    int currNum = int.Parse(Console.ReadLine());
    if (currNum > biggestNumber)
    { 
        biggestNumber = currNum; 
    }
}
Console.WriteLine(biggestNumber);