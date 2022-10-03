using System;

namespace URI___1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1, divisor = 2;
            for (double dividendo = 3; dividendo <= 39; dividendo += 2)
            {
                S += dividendo / divisor;
                divisor += divisor;
            }
            
            Console.WriteLine(S.ToString("F2"));
        }
    }
}
