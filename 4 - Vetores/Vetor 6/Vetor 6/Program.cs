using System;

namespace Vetor_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), i, maior = 0, number = 0;
            string[] nomes = new string[N];
            int[] idades = new int[N];
            string[] vet = new string[2];

            for (i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                idades[i] = int.Parse(vet[1]);
            }

            for (i = 0; i < N; i++)
            {
                if (idades[i] > maior)
                {
                    maior = idades[i];
                    number = i;
                }
            }

            Console.WriteLine($"Pessoa mais velha: {nomes[number]}");
        }
    }
}
