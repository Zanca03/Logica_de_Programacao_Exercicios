using System;

namespace URI___1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1;
            
            for (double divisor = 2; divisor <= 100; divisor++)
            {
                S += (1 / divisor);
            }
            Console.WriteLine(S.ToString("F2"));
        }
    }
}
