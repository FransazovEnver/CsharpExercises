//Input
double protectiveNylon = 1.50;
double paint = 14.50;
double paintThinner  = 5.00;
double bags = 0.4;

int amountOfNylon = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int quantityOfThinner = int.Parse(Console.ReadLine());
int neededHourToCraftsmen = int.Parse(Console.ReadLine());

//Logic
double priceNylon = (amountOfNylon + 2) * protectiveNylon;
double pricePaint = amountOfPaint * 1.1 * paint;
double priceThinner = quantityOfThinner * paintThinner;

double totalSumMaterials = priceNylon + pricePaint + priceThinner + bags;
double amountForCraftsmen = (totalSumMaterials * 0.3) * neededHourToCraftsmen;
double totalAll = totalSumMaterials + amountForCraftsmen;

//Output
Console.WriteLine(totalAll);

