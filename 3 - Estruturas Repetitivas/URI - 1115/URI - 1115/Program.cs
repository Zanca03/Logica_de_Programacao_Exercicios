﻿using System;

namespace URI___1115
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 || y!= 0) 
            {
                if (x > 0 && y > 0) 
                {
                    Console.WriteLine("primeiro");
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
    }
}
