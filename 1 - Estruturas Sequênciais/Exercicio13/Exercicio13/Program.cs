using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, result;
            
            string[] p1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(p1 [0]);
            y1 = double.Parse(p1 [1]);
            
            string[] p2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(p2 [0]);
            y2 = double.Parse(p2 [1]);
            
            result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(result.ToString("F4"));
        }
    }
}
