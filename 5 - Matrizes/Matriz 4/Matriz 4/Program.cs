using System;

namespace Matriz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }
            int soma = 0, diagonal = 1;
            for(int i = 0; i < N; i++)
            {
                for (int j = diagonal; j < N; j++)
                {
                    soma += matriz[i, j];
                }
                diagonal++;
            }
            Console.WriteLine(soma);
        }
    }
}
