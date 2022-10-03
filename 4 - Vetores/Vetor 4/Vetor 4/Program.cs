using System;

namespace Vetor_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), i;
            string[] vet = new string[N];
            double[] vet2 = new double[N];
            vet = Console.ReadLine().Split(' ');

            for (i = 0; i < N; i++)
            {
                vet2[i] = double.Parse(vet[i]);
            }

            double soma = 0, media;
            
            for (i = 0; i < N; i++)
            {
                soma += vet2[i];
            }

            media = soma / N;
            Console.WriteLine(media.ToString("F3"));

            for (i = 0; i < N; i++)
            {
                if (vet2[i] < media)
                {
                    Console.WriteLine(vet2[i].ToString("F1"));
                }
            }
        }
    }
}
