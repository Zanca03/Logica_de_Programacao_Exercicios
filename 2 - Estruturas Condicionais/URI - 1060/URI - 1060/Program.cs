using System;

namespace URI___1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double number4 = double.Parse(Console.ReadLine());
            double number5 = double.Parse(Console.ReadLine());
            double number6 = double.Parse(Console.ReadLine());
            int result = 0;
            double result2 = 0;
            
            if (number1 > 0) 
            {
                result += 1;
                result2 += number1;
            }
            if (number2 > 0)
            {
                result += 1;
                result2 += number2;
            }
            if (number3 > 0)
            {
                result += 1;
                result2 += number3;
            }
            if (number4 > 0)
            {
                result += 1;
                result2 += number4;
            }
            if (number5 > 0)
            {
                result += 1;
                result2 += number5;
            }
            if (number6 > 0)
            {
                result += 1;
                result2 += number6;
            }
            result2 /= result;
            
            Console.WriteLine(result + " valores positivos");
            Console.WriteLine(result2.ToString("F1"));
        }
    }
}
