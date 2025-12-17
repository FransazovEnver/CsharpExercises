//Read four floating-point numbers

double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

//Calculate the total cost of the production by given quantities and prices

double tomatoSum = tomatoPrice  * tomatoQuantity;
double cucumberSum = cucumberPrice * cucumberQuantity;
double totalCost = tomatoSum + cucumberSum;

//Print the total cost, formatted to the 2nd digit

Console.WriteLine($"{totalCost:F2}");