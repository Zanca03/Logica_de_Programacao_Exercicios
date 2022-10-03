using System;

namespace URI___1097
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 7; i <= 9; i += 2, j += 2)
            {
                Console.WriteLine($"I={i} J={j}");
                Console.WriteLine($"I={i} J={j - 1}");
                Console.WriteLine($"I={i} J={j - 2}");
            }
        }
    }
}
