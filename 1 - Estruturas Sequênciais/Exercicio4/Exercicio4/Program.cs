using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;
            A = double.Parse(Console.ReadLine()) * 3.5;
            B = double.Parse(Console.ReadLine()) * 7.5;
            MEDIA = (A + B) / 11;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F5")}");
        }
    }
}
