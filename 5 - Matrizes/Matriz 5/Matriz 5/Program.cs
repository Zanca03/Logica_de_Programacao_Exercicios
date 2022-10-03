using System;

namespace Matriz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);
            int[,] matriz1 = new int[M, N];
            int[,] matriz2 = new int[M, N];
            int[,] MatrizFinal = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    matriz1[i, j] = int.Parse(vet[j]);
                }
            }
            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz2[i, j] = int.Parse(vet[j]);
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    MatrizFinal[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(MatrizFinal[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
