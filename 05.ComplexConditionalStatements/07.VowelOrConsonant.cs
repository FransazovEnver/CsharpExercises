//Input
char character = char.Parse(Console.ReadLine());

//A, a, E, e, I, i, O, o, U, u
//Logic
if (character == 'A' || character == 'a' || character == 'E' ||
    character == 'e' || character == 'I' || character == 'i' ||
    character == 'O' || character == 'o' || character == 'U' ||
    character == 'u' )
{
    Console.WriteLine("Vowel");
}
else
{
    Console.WriteLine("Consonant");
}