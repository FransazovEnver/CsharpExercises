//Input
int numberStart = 7;
int numberEnding = int.Parse(Console.ReadLine());


//Logic
for (int number = numberStart; number <= numberEnding; number+=10)
{
    Console.WriteLine(number);
}