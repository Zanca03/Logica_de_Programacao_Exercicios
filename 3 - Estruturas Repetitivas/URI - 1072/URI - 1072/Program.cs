using System;

namespace URI___1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int IN = 0, OUT = 0;

            for (int i = 1; i <= X; i++) 
            {
                int  number = int.Parse(Console.ReadLine());
                
                if (number >= 10 && number <= 20) 
                {
                    IN += 1;
                }
                else 
                {
                    OUT += 1;
                }
            }

            Console.WriteLine(IN + " in");
            Console.WriteLine(OUT + " out");
        }
    }
}
