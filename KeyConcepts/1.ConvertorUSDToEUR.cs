double usdollar = double.Parse(Console.ReadLine()); //dollar to be converted 

double euro = usdollar * 0.88; //Convert dollars to euro (use fixed rate of dollars to euro: 0.88

Console.WriteLine($"{euro:F2}"); //Print the converted value in euro formatted to the 2nd digit