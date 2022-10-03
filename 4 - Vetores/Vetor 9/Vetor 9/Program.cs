using System;

namespace Vetor_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), i, abaixo = 0, entre = 0, acima = 0;
            double ValorCompra = 0, ValorVenda = 0, Lucro;
            string[] produto = new string[N];
            double[] compra = new double[N];
            double[] venda = new double[N];
            string[] vet = new string[3];

            for (i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                produto[i] = vet[1];
                compra[i] = double.Parse(vet[1]);
                venda[i] = double.Parse(vet[2]);

                ValorCompra += compra[i];
                ValorVenda += venda[i];
            }

            for (i = 0; i < N; i++)
            {
                if ((venda[i] * 100) / compra[i] < 110)
                {
                    abaixo++;
                }
                if ((venda[i] * 100) / compra[i] >= 110 && (venda[i] * 100) / compra[i] <= 120)
                {
                    entre++;
                }
                if((venda[i] * 100) / compra[i] > 120)
                {
                    acima++;
                }
            }
            Lucro = ValorVenda - ValorCompra;

            Console.WriteLine($"Lucro abaixo de 10%: {abaixo}");
            Console.WriteLine($"Lucro entre 10% e 20%: {entre}");
            Console.WriteLine($"Lucro acima de 20%: {acima}");
            Console.WriteLine($"Valor total de compra: {ValorCompra.ToString("F2")}");
            Console.WriteLine($"Valor total de venda: {ValorVenda.ToString("F2")}");
            Console.WriteLine($"Lucro total: {Lucro.ToString("F2")}");
        }
    }
}
