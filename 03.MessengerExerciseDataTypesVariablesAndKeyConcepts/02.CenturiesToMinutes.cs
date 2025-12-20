// Input
int centuriesForConversion = int.Parse(Console.ReadLine());

//Logic
int centuriesToYears = centuriesForConversion * 100;
int yearsToDays = (int)(centuriesToYears * 365.2422);
int daysToHours = yearsToDays * 24;
int hoursToMinutes = daysToHours * 60;

;

//Output
Console.WriteLine($"{centuriesForConversion} centuries = {centuriesToYears} years = {yearsToDays} days = {daysToHours} hours = {hoursToMinutes} minutes");