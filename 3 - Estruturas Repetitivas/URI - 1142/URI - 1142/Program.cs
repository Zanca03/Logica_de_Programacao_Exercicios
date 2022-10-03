using System;

namespace URI___1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int a = 1, b = 2, c = 3;

            for (int i = 1; i <= entrada; i++)
            {
                Console.WriteLine($"{a} {b} {c} PUM");
                a += 4;
                b += 4;
                c += 4;
            }
        }
    }
}
