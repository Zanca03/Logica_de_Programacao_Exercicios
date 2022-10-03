using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, salariofinal;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.0 && salario > 0)
            {
                reajuste = salario * 0.15;
                salariofinal = salario * 1.15;
                Console.WriteLine("Novo salario: " + salariofinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario >= 400.01 && salario <= 800.0)
            {
                reajuste = salario * 0.12;
                salariofinal = salario * 1.12;
                Console.WriteLine("Novo salario: " + salariofinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.01 && salario <= 1200.0)
            {
                reajuste = salario * 0.10;
                salariofinal = salario * 1.10;
                Console.WriteLine("Novo salario: " + salariofinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 1200.01 && salario <= 2000.0)
            {
                reajuste = salario * 0.07;
                salariofinal = salario * 1.07;
                Console.WriteLine("Novo salario: " + salariofinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                reajuste = salario * 0.04;
                salariofinal = salario * 1.04;
                Console.WriteLine("Novo salario: " + salariofinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
