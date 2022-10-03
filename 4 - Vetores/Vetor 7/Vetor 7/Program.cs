using System;

namespace Vetor_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), i;
            double[] PrimeiraNota = new double[N];
            double[] SegundaNota = new double[N];
            string[] Nomes = new string[N];
            string[] vet = new string[3];

            for (i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                Nomes[i] = vet[0];
                PrimeiraNota[i] = double.Parse(vet[1]);
                SegundaNota[i] = double.Parse(vet[2]);
            }

            double media;
            Console.WriteLine("Alunos aprovados:");
            
            for (i = 0; i < N; i++)
            {
                media = (PrimeiraNota[i] + SegundaNota[i]) / 2;
                if (media >= 6)
                {
                    Console.WriteLine(Nomes[i]);
                }
            }
        }
    }
}
