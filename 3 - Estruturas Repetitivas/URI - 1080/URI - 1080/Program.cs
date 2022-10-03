using System;

namespace URI___1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0, number = 0;

            for (int i = 1; i <= 100; i++)
            {
                int enter = int.Parse(Console.ReadLine());
                
                if(enter > number)
                {
                    position = i;
                    number = enter;
                }
            }

            Console.WriteLine(number);
            Console.WriteLine(position);
        }
    }
}
