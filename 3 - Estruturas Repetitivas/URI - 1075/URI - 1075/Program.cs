using System;

namespace URI___1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % X == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
