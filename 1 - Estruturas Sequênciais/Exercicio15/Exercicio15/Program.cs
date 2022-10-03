using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada, horas, resto, minutos, segundos;
            entrada = int.Parse(Console.ReadLine());
            horas = entrada / 3600;
            resto = entrada % 3600;
            
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
