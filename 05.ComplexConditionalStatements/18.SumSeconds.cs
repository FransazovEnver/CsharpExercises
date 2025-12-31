//Input
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

//Logic
int timeInSecond = firstNumber + secondNumber + thirdNumber;

int minutes = timeInSecond / 60;
int seconds = timeInSecond % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}