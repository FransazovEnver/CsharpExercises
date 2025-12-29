//Input
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

//Logic
if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine(firstNumber);
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.WriteLine(secondNumber);
}
else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    Console.WriteLine(thirdNumber);
}