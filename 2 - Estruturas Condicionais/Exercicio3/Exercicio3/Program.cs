using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valor;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    valor = quantidade * 4.0;
                    Console.WriteLine($"Total: R$ {valor:F2}", CultureInfo.InvariantCulture);
                    break;

                case 2:
                    valor = quantidade * 4.5;
                    Console.WriteLine($"Total: R$ {valor:F2}", CultureInfo.InvariantCulture);
                    break;

                case 3:
                    valor = quantidade * 5.0;
                    Console.WriteLine($"Total: R$ {valor:F2}", CultureInfo.InvariantCulture);
                    break;

                case 4:
                    valor = quantidade * 2.0;
                    Console.WriteLine($"Total: R$ {valor:F2}", CultureInfo.InvariantCulture);
                    break;

                case 5:
                    valor = quantidade * 1.5;
                    Console.WriteLine($"Total: R$ {valor:F2}", CultureInfo.InvariantCulture);
                    break;
            }
        }
    }
}
