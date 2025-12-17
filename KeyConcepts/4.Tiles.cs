double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth  = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomHeight * 1.1; // 1.1 is the whole bathroomAreaa plus 10 percent(%) for tile
double tileArea = tileWidth * tileHeight;
double neededTiles = bathroomArea / tileArea;

Console.WriteLine(Math.Round(neededTiles));