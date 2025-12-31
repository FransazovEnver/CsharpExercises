//Input
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int fourthNumber = int.Parse(Console.ReadLine());
int fifthNumber  = int.Parse(Console.ReadLine());

//Logic
if (firstNumber > secondNumber && firstNumber > thirdNumber &&
    firstNumber > fourthNumber && firstNumber > fifthNumber)
{
    Console.WriteLine(firstNumber);
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber &&
    secondNumber > fourthNumber && secondNumber > fifthNumber)
{
    Console.WriteLine(secondNumber);
}
else if (thirdNumber > secondNumber && thirdNumber > firstNumber &&
    thirdNumber > fourthNumber && thirdNumber > fifthNumber)
{
    Console.WriteLine(thirdNumber);
}
else if (fourthNumber > firstNumber && fourthNumber > secondNumber &&
    fourthNumber > thirdNumber && fourthNumber > fifthNumber)
{
    Console.WriteLine(fourthNumber);
}
else if (fifthNumber > firstNumber && fifthNumber > secondNumber &&
    fifthNumber > thirdNumber && fifthNumber > fourthNumber)
{
    Console.WriteLine(fifthNumber);
}