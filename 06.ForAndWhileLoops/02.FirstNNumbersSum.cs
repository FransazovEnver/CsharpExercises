//Input
int startNum = 1;
int endNum = int.Parse(Console.ReadLine());

int sum = 0;


//Logic
for (int num = startNum; num <= endNum; num++)
{
    sum += num;
}
Console.Write(sum);