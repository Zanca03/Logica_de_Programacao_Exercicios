using System;

namespace URI___1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada; i++)
            {
                if (entrada % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
