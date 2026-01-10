double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine()); //Read two floating-point numbers

double additionResult = firstNumber + secondNumber ;//4 arithmetic operations on the given 2 numbers
double subtractionResult = firstNumber - secondNumber ;
double multiplicationResult = firstNumber * secondNumber ;
double divisionResult = firstNumber / secondNumber ;


Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {additionResult:F2}");// results all formatted to the 2nd digit
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {subtractionResult:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {multiplicationResult:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {divisionResult:F2}");