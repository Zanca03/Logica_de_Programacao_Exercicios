using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salaryFix, sales, finalSalary;

            name = Console.ReadLine();
            salaryFix = double.Parse(Console.ReadLine());
            sales = double.Parse(Console.ReadLine());
            finalSalary = (sales * 0.15) + salaryFix;

            Console.WriteLine($"TOTAL = R$ {finalSalary:F2}");
        }
    }
}
