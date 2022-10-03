using System;

namespace URI___1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);

            while (M > 0 && M != 0 && N > 0 && N != 0)
            {
                int soma = 0;
                int temp = M;

                if (M > N)
                {
                    M = N;
                    N = temp;
                }

                for (int i = M; i <= N; i++)
                {
                    Console.Write($"{i} ");
                    soma += i;
                }
                Console.WriteLine($"Sum={soma}");

                vet = Console.ReadLine().Split(' ');
                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);
            }
        }
    }
}
