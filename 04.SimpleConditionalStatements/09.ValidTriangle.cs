//Input
int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());
int sideC = int.Parse(Console.ReadLine());

//Logic
if (sideA < sideB + sideC && sideC < sideA + sideB && sideB < sideA + sideC)
{
    Console.WriteLine("Valid Triangle");
}
else 
{
    Console.WriteLine("Invalid Triangle");
}
