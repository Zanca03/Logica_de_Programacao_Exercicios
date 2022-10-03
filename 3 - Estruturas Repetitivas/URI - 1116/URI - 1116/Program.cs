using System;

namespace URI___1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            double divisao, X, Y;

            entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = X / Y;
                    Console.WriteLine(divisao.ToString("F1"));
                }
            }
        }
    }
}
