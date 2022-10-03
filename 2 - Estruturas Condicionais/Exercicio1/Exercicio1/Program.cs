using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, X1, X2;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2.0) - 4.0 * A * C;

            if (A == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                X1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                X2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine($"R1 = {X1:F5}", CultureInfo.InvariantCulture);
                Console.WriteLine($"R2 = {X2:F5}", CultureInfo.InvariantCulture);
            }
        
        }
    }
}
