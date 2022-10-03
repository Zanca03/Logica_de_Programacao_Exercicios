using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media;
            A = double.Parse(Console.ReadLine()) * 2.0;
            B = double.Parse(Console.ReadLine()) * 3.0;
            C = double.Parse(Console.ReadLine()) * 5.0;
            media = (A + B + C) / 10.0;

            Console.WriteLine($"MEDIA = {media.ToString("F1")}");
        }
    }
}
