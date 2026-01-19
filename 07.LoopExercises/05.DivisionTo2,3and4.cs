//Input

int num = int.Parse(Console.ReadLine());

//Logic
int countDiBy2 = 0;
int countDiBy3 = 0;
int countDiBy4 = 0;

for (int i = 0; i < num; i++)
{
    int curNum = int.Parse(Console.ReadLine());
    if (curNum % 2 == 0)
    {
        countDiBy2++;
    }
    if (curNum % 3 == 0)
    {
        countDiBy3++;
    }
    if (curNum % 4 == 0)
    {
        countDiBy4++;
    }
}
double perDivBy2 = (double)countDiBy2 / num * 100;
double perDivBy3 = (double)countDiBy3 / num * 100;
double perDivBy4 = (double)countDiBy4 / num * 100;

Console.WriteLine($"{perDivBy2:F2}%");
Console.WriteLine($"{perDivBy3:F2}%");
Console.WriteLine($"{perDivBy4:F2}%");