//Input
int number = int.Parse(Console.ReadLine());
string condition = "";


//Logic
while ((condition = Console.ReadLine()) != "End")
{
    if(condition == "Inc")
    {
        number +=1;
    }
    else if(condition == "Dec")
    {
        number -= 1;
    }
}
Console.WriteLine(number);