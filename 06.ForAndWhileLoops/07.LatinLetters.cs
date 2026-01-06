//Input
char letterFirst = char.Parse(Console.ReadLine());
char letterSecond = char.Parse(Console.ReadLine());

//Logic
for (char symbol = letterFirst; symbol <= letterSecond; symbol++)
{
    Console.Write(symbol + " ");
}