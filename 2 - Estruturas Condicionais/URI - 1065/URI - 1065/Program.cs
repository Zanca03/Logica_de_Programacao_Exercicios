using System;

namespace URI___1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            number1 %= 2;
            int number2 = int.Parse(Console.ReadLine());
            number2 %= 2;
            int number3 = int.Parse(Console.ReadLine());
            number3 %= 2;
            int number4 = int.Parse(Console.ReadLine());
            number4 %= 2;
            int number5 = int.Parse(Console.ReadLine());
            number5 %= 2;
            int result = 0;
            
            if (number1 == 0) 
            {
                result += 1;
            }
            if (number2 == 0)
            {
                result += 1;
            }
            if (number3 == 0)
            {
                result += 1;
            }
            if (number4 == 0)
            {
                result += 1;
            }
            if (number5 == 0)
            {
                result += 1;
            }
            Console.WriteLine(result + " valores pares");
        }
    }
}
