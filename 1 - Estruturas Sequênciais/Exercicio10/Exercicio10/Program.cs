using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;
            
            string[] numbers = Console.ReadLine().Split(' ');

            A = double.Parse(numbers[0]);
            B = double.Parse(numbers[1]);
            C = double.Parse(numbers[2]);

            triangulo = (A * C) / 2.0;
            circulo = Math.Pow(C, 2) * 3.14159;
            trapezio = ((A + B) * C) / 2.0;
            quadrado = Math.Pow(B, 2);
            retangulo = A * B;

            Console.WriteLine($"TRIANGULO = {triangulo:F3}");
            Console.WriteLine($"CIRCULO = {circulo:F3}");
            Console.WriteLine($"TRAPEZIO = {trapezio:F3}");
            Console.WriteLine($"QUADRADO = {quadrado:F3}");
            Console.WriteLine($"RETANGULO = {retangulo:F3}");
        }
    }
}
