using System;

namespace URI___1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double wage = double.Parse(Console.ReadLine());

            if (wage <= 2000) 
            {
                Console.WriteLine("Isento");
            }
            else if (wage <= 3000 && wage > 2000) 
            {
                wage -= 2000;
                wage *= 0.08;
                Console.WriteLine("R$ " + wage.ToString("F2"));
            }
            else if (wage <= 4500 && wage > 3000) 
            {
                wage -= 3000;
                wage = wage * 0.18 + 80;
                Console.WriteLine("R$ " + wage.ToString("F2"));
            }
            else if (wage > 4500) 
            {
                wage -= 4500;
                wage = wage * 0.28 + 80 + 270;
                Console.WriteLine("R$ " + wage.ToString("F2"));
            }
        }
    }
}