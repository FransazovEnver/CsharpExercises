/*
//Input
int currentDay = int.Parse(Console.ReadLine());

//Logic

for (int num = currentDay; currentDay >= 1; currentDay--)
{
    Console.WriteLine($"{currentDay} days before the exam");
}
Console.WriteLine("The exam has come");
*/

//Input
int number = 1;
int currentDay = int.Parse(Console.ReadLine());
                                                     
//Logic

for (int num = number; number <= currentDay; currentDay--)
{
    Console.WriteLine($"{currentDay} days before the exam");
    if (currentDay == 0)
    {
        break;
    }
}
Console.WriteLine("The exam has come");