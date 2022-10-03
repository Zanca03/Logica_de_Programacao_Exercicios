using System;

namespace URI___1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int coelho = 0, sapo = 0, rato = 0;
            double soma, porcentagemC, porcentagemS, porcentagemR;

            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada; i++)
            {
                string [] vet = Console.ReadLine().Split(' ');
                int a = int.Parse(vet[0]);
                char b = char.Parse(vet[1]);

                if (b == 'C')
                {
                    coelho += a;
                }
                else if (b == 'R')
                {
                    rato += a;
                }
                else if (b == 'S')
                {
                    sapo += a;
                }
            }

            soma = rato + sapo + coelho;
            Console.WriteLine($"Total: {soma} cobaias");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato}");
            Console.WriteLine($"Total de sapos: {sapo}");
            porcentagemC = (coelho * 100) / soma;
            porcentagemR = (rato * 100) / soma;
            porcentagemS = (sapo * 100) / soma;
            Console.WriteLine($"Percentual de coelhos: {porcentagemC.ToString("F2")} %");
            Console.WriteLine($"Percentual de ratos: {porcentagemR.ToString("F2")} %");
            Console.WriteLine($"Percentual de sapos: {porcentagemS.ToString("F2")} %");
        }
    }
}
