//Input
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
string mathOperator = Console.ReadLine();
double result = 0;

//Logic
switch (mathOperator)
{
	case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        result = num1 / num2;
        break;
}

//Output
Console.WriteLine($"{num1} {mathOperator} {num2} = {result:F2}");