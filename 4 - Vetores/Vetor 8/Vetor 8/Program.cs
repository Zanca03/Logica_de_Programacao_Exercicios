using System;

namespace Vetor_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), i;
            double[] altura = new double[N];
            char[] sexo = new char[N];
            string[] vet = new string[2];
            
            for(i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vet[0]);
                sexo[i] = char.Parse(vet[1]);
            }

            double media, soma = 0, divisor = 0, maior = 0, menor = 100;
            int homens = 0;

            for (i = 0; i < N; i++)
            {
                if (maior < altura[i])
                {
                    maior = altura[i];
                }
                else if (menor > altura[i])
                {
                    menor = altura[i];
                }
                if (sexo[i] == 'F')
                {
                    soma += altura[i];
                    divisor++;
                }
                else if (sexo[i] == 'M')
                {
                    homens++;
                }
            }

            media = (double) soma / divisor;

            Console.WriteLine($"Menor altura = {menor}");
            Console.WriteLine($"Maior altura = {maior}");
            Console.WriteLine($"Media das alturas das mulheres = {media.ToString("F2")}");
            Console.WriteLine($"Numero de homens = {homens}");
        }
    }
}
