using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = int.Parse(Console.ReadLine());
            int veloMedia = int.Parse(Console.ReadLine());
            double litrosGasolina = (horas * veloMedia) / 12.0;

            Console.WriteLine(litrosGasolina.ToString("F3"));
        }
    }
}
