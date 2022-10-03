using System;

namespace URI___1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int temp = x, total = 0;

            if (x > y)
            {
                x = y; y = temp;
            }
            for (int i = x; i <= y; i++)
            {
                if (i % 13 != 0) total += i;
            }

            Console.WriteLine(total);
        }
    }
}
