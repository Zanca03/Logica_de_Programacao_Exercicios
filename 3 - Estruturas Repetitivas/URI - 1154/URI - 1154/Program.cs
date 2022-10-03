using System;

namespace URI___1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, divisor = 0;
            double media, total = 0;

            idade = int.Parse(Console.ReadLine());

            while (idade > 0) 
            {
                total += idade;
                divisor += 1;
                idade = int.Parse(Console.ReadLine());
            }

            media = total / divisor;
            Console.WriteLine(media.ToString("F2"));
        }
    }
}
