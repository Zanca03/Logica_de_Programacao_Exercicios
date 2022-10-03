using System;

namespace URI___1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bool primo = true;

                for (int i2 = 2; i2 < number; i2++)
                {
                    if (number % i2 == 0)
                    {
                        Console.WriteLine($"{number} nao eh primo");
                        primo = false;
                        break;
                    }
                }

                if (primo == true)
                {
                    Console.WriteLine($"{number} eh primo");
                }
            }
        }
    }
}
