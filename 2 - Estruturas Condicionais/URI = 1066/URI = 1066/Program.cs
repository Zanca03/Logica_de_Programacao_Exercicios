using System;

namespace URI___1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());
            int par = 0;
            int impar = 0;
            int positive = 0;
            int negative = 0;

            if (number1 % 2 == 0) 
            {
                par += 1;
                if (number1 > 0)
                {
                    positive += 1;
                }
                if (number1 < 0)
                {
                    negative += 1;
                }
            }
            else 
            {
                impar += 1;
                if (number1 > 0)
                {
                    positive += 1;
                }
                if (number1 < 0)
                {
                    negative += 1;
                }
            }
            if (number2 % 2 == 0)
            {
                par += 1;
                if (number2 > 0)
                {
                    positive += 1;
                }
                if (number2 < 0)
                {
                    negative += 1;
                }
            }
            else
            {
                impar += 1;
                if (number2 > 0)
                {
                    positive += 1;
                }
                if (number2 < 0)
                {
                    negative += 1;
                }
            }
            if (number3 % 2 == 0)
            {
                par += 1;
                if (number3 > 0)
                {
                    positive += 1;
                }
                if (number3 < 0)
                    {
                    negative += 1;
                }
            }
            else
            {
                impar += 1;
                if (number3 > 0)
                {
                    positive += 1;
                }
                if (number3 < 0)
                {
                    negative += 1;
                }
            }
            if (number4 % 2 == 0)
            {
                par += 1;
                if (number4 > 0)
                {
                    positive += 1;
                }
                if (number4 < 0)
                {
                    negative += 1;
                }
            }
            else
            {
                impar += 1;
                if (number4 > 0)
                {
                    positive += 1;
                }
                if (number4 < 0)
                {
                    negative += 1;
                }
            }
            if (number5 % 2 == 0)
            {
                par += 1;
                if (number5 > 0)
                {
                    positive += 1;
                }
                if (number5 < 0)
                {
                    negative += 1;
                }
            }
            else 
            {
                impar += 1;
                if (number5 > 0)
                {
                    positive += 1;
                }
                if (number5 < 0)
                {
                    negative += 1;
                }
            }
            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positive + " valor(es) positivo(s)");
            Console.WriteLine(negative + " valor(es) negativo(s)");
        }
    }
}
