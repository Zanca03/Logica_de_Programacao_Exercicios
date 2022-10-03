using System;

namespace Matriz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }
            for (int i = 0; i < N; i++)
            {
                int valor = 0;
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] > valor)
                    {
                        valor = matriz[i, j];
                    }
                }
                Console.WriteLine(valor);
            }
        }
    }
}
