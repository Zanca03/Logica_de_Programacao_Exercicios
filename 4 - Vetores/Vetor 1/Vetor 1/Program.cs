using System;
using System.Globalization;

namespace Vetor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), i, element = 0;
            double[] vet = new double[N];
            double number = 0;
            string[] vet2 = Console.ReadLine().Split(' ');

            for (i = 0; i < N; i++)
            {
                vet[i] = double.Parse(vet2[i], CultureInfo.InvariantCulture);
            }
            for (i = 0; i < N; i++)
            {
                if (vet[i] > number)
                {
                    number = vet[i];
                    element = i;
                }
            }
            Console.WriteLine(number.ToString("F1"), CultureInfo.InvariantCulture);
            Console.WriteLine(element);
        }
    }
}
