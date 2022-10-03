using System;

namespace URI___1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int a = 1, b = 1, c = 1;

            for (int i = 1; i <= entrada; i++)
            {
                Console.WriteLine($"{a} {b} {c}");
                a++;
                b = a * a;
                c = a * b;
            }
        }
    }
}
