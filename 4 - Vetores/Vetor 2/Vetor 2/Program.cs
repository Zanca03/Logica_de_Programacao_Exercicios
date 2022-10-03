using System;

namespace Vetor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), i, total = 0;
            int[] vet = new int[N];
            string[] vet2 = Console.ReadLine().Split(' ');

            for (i = 0; i < N; i++)
            {
                vet[i] = int.Parse(vet2[i]);
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    total += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine(total);
        }
    }
}
