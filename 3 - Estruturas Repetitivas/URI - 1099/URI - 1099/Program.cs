using System;

namespace URI___1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int x, y;

            for (int i = 1; i <= entrada; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                int temp = x, soma = 0;

                if (x > y)
                {
                    x = y; 
                    y = temp;
                }
                for (int i2 = x + 1; i2 < y; i2++)
                {
                    if (i2 % 2 != 0)
                    {
                        soma += i2;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}
