using System;

namespace Vetor_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), i;
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];
            string[] vet = new string[N];
            vet = Console.ReadLine().Split(' ');

            for (i = 0; i < N; i++)
            {
                A[i] = int.Parse(vet[i]);
            }

            vet = Console.ReadLine().Split(' ');

            for (i = 0; i < N; i++)
            {
                B[i] = int.Parse(vet[i]);
            }

            for (i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }
        }
    }
}
