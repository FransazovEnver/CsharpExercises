double depositedAmount = double.Parse(Console.ReadLine()); 
int termDeposit = int.Parse(Console.ReadLine()); 
double interestRate = double.Parse(Console.ReadLine()) / 100;

double totalamount = depositedAmount + termDeposit * (depositedAmount * interestRate) / 12;


Console.WriteLine($"{totalamount:F2}"); 