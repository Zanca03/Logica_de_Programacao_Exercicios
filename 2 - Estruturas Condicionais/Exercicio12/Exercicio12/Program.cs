using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            float A = float.Parse(vet[0]);
            float B = float.Parse(vet[1]);
            float C = float.Parse(vet[2]);

            if ((A - B) < C && C < (A + B) && (B - C) < A && A < (B + C) && (A - C) < B && B < (A + C))
            {
                float perimeter = A + B + C;
                Console.WriteLine("Perimetro = " + perimeter.ToString("F1"));
            }
            else 
            {
                float area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1"));
            }
        }
    }
}
