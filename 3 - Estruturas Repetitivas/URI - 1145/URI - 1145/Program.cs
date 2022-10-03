using System;

namespace URI___1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int number = 1;

            for (int i = 3; i <= y; i += x)
            {
                int repeticao = 1;
                
                while (repeticao <= x)
                {
                    if (repeticao < x)
                    {
                        Console.Write($"{number} ");
                    }
                    else
                    {
                        Console.Write($"{number}");
                    }

                    number += 1;
                    repeticao += 1;
                }
                Console.WriteLine();
            }
        }
    }
}
