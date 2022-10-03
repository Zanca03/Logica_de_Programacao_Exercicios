using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, Diference;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            Diference = A * B - C * D;

            Console.WriteLine($"DIFERENCA = {Diference}");
        }
    }
}
