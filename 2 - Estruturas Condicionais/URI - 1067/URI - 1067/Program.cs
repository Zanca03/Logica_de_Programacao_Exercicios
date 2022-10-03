using System;

namespace URI___1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int show = 1;

            while (1 <= x && x <= 1000 && show <= x) 
            {
                Console.WriteLine(show);
                show += 2;
            }
        }
    }
}
