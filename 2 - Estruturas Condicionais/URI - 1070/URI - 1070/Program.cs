using System;

namespace URI___1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int show = x % 2;
            int limit = 0;

            if (show == 0)
            {
                x += 1;
                while (limit <= 5)
                {
                    Console.WriteLine(x);
                    x += 2;
                    limit += 1;
                }
            }
            else 
            {  
                while (limit <= 5) 
                {
                    Console.WriteLine(x);
                    x += 2;
                    limit += 1;
                }
            }
        }
    }
}
