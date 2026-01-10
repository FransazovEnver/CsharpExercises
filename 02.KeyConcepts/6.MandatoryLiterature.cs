int numberOfPages = int.Parse(Console.ReadLine()); 
int pages = int.Parse(Console.ReadLine()); 
int numberOfDays= int.Parse(Console.ReadLine());

int totalTimeReading = numberOfPages / pages;
int hoursPerDays = totalTimeReading / numberOfDays;

Console.WriteLine(hoursPerDays);