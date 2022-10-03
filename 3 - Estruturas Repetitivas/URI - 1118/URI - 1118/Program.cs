using System;

namespace URI___1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, media;
            int comand = 1;

            while (comand == 1 && comand != 2)
            {
                x = double.Parse(Console.ReadLine());

                while (x < 0 || x > 10) 
                {
                        Console.WriteLine("nota invalida");
                        x = double.Parse(Console.ReadLine());
                }

                y = double.Parse(Console.ReadLine());

                while (y < 0 || y > 10)
                {
                    Console.WriteLine("nota invalida");
                    y = double.Parse(Console.ReadLine());
                }

                media = (x + y) / 2;

                Console.WriteLine($"media = {media.ToString("F2")}");
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                
                comand = int.Parse(Console.ReadLine());

                while (comand != 1 && comand != 2)
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        comand = int.Parse(Console.ReadLine());
                    }
            }
        }
    }
}
