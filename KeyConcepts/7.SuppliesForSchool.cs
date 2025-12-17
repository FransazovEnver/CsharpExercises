
double packageOfPens = 5.80; // This is a price list
double packageOfMarkers = 7.20;
double boardCleaner = 1.20;


double numberOfPackagespens = double.Parse(Console.ReadLine()); // A variables who help to 
double numberOfPacketsMarkers = double.Parse(Console.ReadLine()); // solve the problem
double litersOfBoardCleaner = double.Parse(Console.ReadLine());
double discountPercentage = double.Parse(Console.ReadLine()) / 100;

double pricePens = numberOfPackagespens * packageOfPens;// The logics to calculate
double priceMarkers = numberOfPacketsMarkers * packageOfMarkers; // materials
double priceBoardClean = litersOfBoardCleaner * boardCleaner;
double priceOfMaterials = pricePens + priceMarkers + priceBoardClean;
double priceAfterDiscount = priceOfMaterials - (priceOfMaterials * discountPercentage);


Console.WriteLine(priceAfterDiscount);