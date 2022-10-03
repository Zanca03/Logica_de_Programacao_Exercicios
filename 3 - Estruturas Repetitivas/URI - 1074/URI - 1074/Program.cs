using System;

namespace URI___1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            for (int number = 1; number <= X; number += 1)
            {
                int enter = int.Parse(Console.ReadLine());
                int even =  enter % 2;

                if (enter == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (even == 0) 
                {
                    if (enter > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                }
                else
                {
                    if (enter > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}
