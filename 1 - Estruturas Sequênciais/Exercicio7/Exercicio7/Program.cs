using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFunc, hours;
            double hoursPay, payment;

            numberFunc = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            hoursPay = double.Parse(Console.ReadLine());
            payment = hours * hoursPay;

            Console.WriteLine($"NUMBER = {numberFunc}");
            Console.WriteLine($"SALARY = U${payment.ToString("F2")}");
        }
    }
}
