using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada;
            entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada >= 0.0 && entrada <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (entrada >= 25.00001 && entrada <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (entrada >= 50.00001 && entrada <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (entrada >= 75.00001 && entrada <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
