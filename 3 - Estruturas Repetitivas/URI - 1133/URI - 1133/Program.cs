using System;

namespace URI___1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int temp = x;

            if (x > y) x = y; y = temp;
            x++;

            for (int i = x; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
