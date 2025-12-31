//Input
int balance = int.Parse(Console.ReadLine());
int withdraw = int.Parse(Console.ReadLine()); 
int limit  = int.Parse(Console.ReadLine());

//Logic
if (balance > withdraw + limit && limit > withdraw)
{
    Console.WriteLine("The withdraw was successful.");
}
else if (balance < withdraw && balance < limit && withdraw > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else if (balance < limit && limit > withdraw )
{
    Console.WriteLine("Insufficient availability.");
}