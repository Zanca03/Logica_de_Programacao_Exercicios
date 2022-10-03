using System;
using System.Globalization;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, A, B, C;
            string[] vet = Console.ReadLine().Split(' ');
            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2= double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Separação dos Números em Descrescente
            if (n1 > n2 && n1 > n3)
            {
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                A = n2;
                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }
            
            //Definição do tipo de Triângulo;
            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(A, 2.0) == (Math.Pow(B, 2.0) + Math.Pow(C, 2.0)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
                if (A == B && A == C && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else if (Math.Pow(A, 2.0) > (Math.Pow(B, 2.0) + Math.Pow(C, 2.0)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (A == B && A == C && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else if (Math.Pow(A, 2.0) < (Math.Pow(B, 2.0) + Math.Pow(C, 2.0)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
                if (A == B && A == C && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
