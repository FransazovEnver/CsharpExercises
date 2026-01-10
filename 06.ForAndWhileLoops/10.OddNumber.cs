//Input
int oddNumber = int.Parse(Console.ReadLine());

//Logic

for (int i = oddNumber; oddNumber % 2 == 0;)
{
    oddNumber = int.Parse(Console.ReadLine());
}
Console.WriteLine(oddNumber);