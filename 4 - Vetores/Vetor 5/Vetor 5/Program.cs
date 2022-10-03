using System;

namespace Vetor_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), i;
            int[] vet = new int[N];
            string[] vet2 = Console.ReadLine().Split(' ');
            int media, soma = 0, divisor = 0;

            for (i = 0; i < N; i++)
            {
                vet[i] = int.Parse(vet2[i]);

                if (vet[i] % 2 == 0)
                {
                    soma += vet[i];
                    divisor++;
                }
            }
            media = soma / divisor;
            Console.WriteLine(media.ToString("F1"));
        }
    }
}
