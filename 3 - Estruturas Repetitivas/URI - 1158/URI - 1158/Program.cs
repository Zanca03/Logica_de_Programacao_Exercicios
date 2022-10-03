using System;

namespace URI___1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y, i, i2, soma;
            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                soma = 0;
                string[] vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                for (i2 = 1; i2 <= Y; i2++)
                {
                    if (X % 2 != 0)
                    {
                        soma += X;
                    }
                    else
                    {
                        X += 1;
                        soma += X;
                    }
                    X += 2;
                }
                Console.WriteLine(soma);
            }
        }
    }
}
