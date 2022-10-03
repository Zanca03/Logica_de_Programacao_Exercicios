using System;

namespace URI___1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int number2 = 2; number2 <= number; number2 += 2)
            {
                int potentiation = number2 * number2;
                Console.WriteLine($"{number2}^2 = {potentiation}");
            }
        }
    }
}