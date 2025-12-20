// Input
int basketballTrainingFee = int.Parse(Console.ReadLine());

//Logic
double sneakers = basketballTrainingFee - (basketballTrainingFee * 0.4);
double uniform = sneakers - (sneakers * 0.2);
double ball = uniform * 0.25;
double accessories = ball * 0.2;

double total = basketballTrainingFee + sneakers + uniform + ball + accessories;

//Output
Console.WriteLine(total);


