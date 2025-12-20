
//Input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage  = double.Parse(Console.ReadLine());

//Logic
int volumeOfTheAquarium = length *  width * height;
double volumeLiters = volumeOfTheAquarium * 0.001;
double occupiedspace = percentage / 100;
double requiredLiters = volumeLiters * (1 - (percentage / 100));

//Output
Console.WriteLine(Math.Round(requiredLiters,2));