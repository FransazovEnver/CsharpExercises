//Input
int startNum = 1;
int endNum = int.Parse(Console.ReadLine());

int sum = 0;


//Logic
for (int num = startNum; num <= endNum; num++)
{
    if (num != endNum)
    {
        Console.Write(num + "+");
    }
    else
    {
        Console.Write(num + "=");
    }
    sum += num;
}
Console.Write(sum);