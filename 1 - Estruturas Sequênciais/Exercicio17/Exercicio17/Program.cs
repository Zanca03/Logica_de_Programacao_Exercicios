using System;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada, ano, mes, dia, resto;
            entrada = int.Parse(Console.ReadLine());
            
            ano = entrada / 365;
            Console.WriteLine($"{ano} ano(s)");

            resto = entrada % 365;
            mes = resto / 30;
            Console.WriteLine($"{mes} mes(es)");

            dia = (resto % 30) / 1;
            Console.WriteLine($"{dia} dia(s)");
        }
    }
}
