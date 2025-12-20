
//Variables
double chicken = 10.35; 
double fish = 12.40;
double vegetarian = 8.15;

//Input
int chickenMenus = int.Parse(Console.ReadLine());
int menuswithFish = int.Parse(Console.ReadLine());
int vegetarianMenus= int.Parse(Console.ReadLine());

//Logic
double priceForChikenMenus = chickenMenus * chicken;
double priceForFishMenus = menuswithFish * fish;
double priceForVegetarianMenus = vegetarianMenus * vegetarian;
double priceTotalCostMenu = priceForChikenMenus + priceForFishMenus + priceForVegetarianMenus;
double priceForDessert = priceTotalCostMenu * 0.2;
double totalOrder = priceTotalCostMenu + priceForDessert + 2.50;

//Output
Console.WriteLine(totalOrder);
