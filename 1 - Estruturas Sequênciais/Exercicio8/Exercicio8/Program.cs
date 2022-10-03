using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca1Cod, peca1Num, peca2Cod, peca2Num;
            double peca1Preco, peca2Preco, precoTotal;

            string[] vet1 = Console.ReadLine().Split(' ');
            peca1Cod = int.Parse(vet1[0]);
            peca1Num = int.Parse(vet1[1]);
            peca1Preco = double.Parse(vet1[2]);

            string[] vet2 = Console.ReadLine().Split(' ');
            peca2Cod = int.Parse(vet2[0]);
            peca2Num = int.Parse(vet2[1]);
            peca2Preco = double.Parse(vet2[2]);

            precoTotal = (peca1Num * peca1Preco) + (peca2Num * peca2Preco);

            Console.WriteLine($"VALOR A PAGAR: R$ {precoTotal:F2}");
        }
    }
}
