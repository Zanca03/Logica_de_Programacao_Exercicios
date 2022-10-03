using System;

namespace URI___1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int fator = entrada, fator2 = entrada - 1, result = 1;

            for (int i = 1; i <= entrada; i++)
            {
                result *= fator;
                fator = fator2;
                fator2 -= 1;
            }

            Console.WriteLine(result);
        }
    }
}
