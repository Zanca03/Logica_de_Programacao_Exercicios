using System;

namespace URI___1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 0;

            for (int i = 1; i <= entrada; i++)
            {
                Console.Write($"{a} ");
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}
