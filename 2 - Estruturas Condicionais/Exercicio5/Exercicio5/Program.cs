using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A < B)
            {
                C = B - A;
                Console.WriteLine($"O JOGO DUROU {C} HORA(S)");
            }
            else
            {
                C = 24 - A + B;
                Console.WriteLine($"O JOGO DUROU {C} HORA(S)");
            }
        }
    }
}
