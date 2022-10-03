using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            double litros = double.Parse(Console.ReadLine());
            double resultado = distancia / litros;

            Console.WriteLine($"{resultado:F3} km/l");
        }
    }
}
