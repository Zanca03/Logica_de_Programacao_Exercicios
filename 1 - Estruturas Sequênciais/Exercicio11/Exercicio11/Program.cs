using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, N1, N2;
            string[] numbers = Console.ReadLine().Split(' ');

            A = int.Parse(numbers[0]);
            B = int.Parse(numbers[1]);
            C = int.Parse(numbers[2]);
            N1 = (A + B + Math.Abs(A - B)) / 2;
            N2 = (N1 + C + Math.Abs(N1 - C)) / 2;

            Console.WriteLine($"{N2} eh o maior");

            /*if ((number1 >= number2) && (number1 >= number3)) 
                { Console.WriteLine($"{number1} eh o maior"); }

            if ((number2 >= number1) && (number2 >= number3))
            { Console.WriteLine($"{number2} eh o maior"); }

            if ((number3 >= number2) && (number3 >= number1))
            { Console.WriteLine($"{number3} eh o maior"); }
            */
        }
    }
}
