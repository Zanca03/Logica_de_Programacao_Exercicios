using System;

namespace URI___1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int PA, PB, Tempo;
            double TA, TB;

            for (int i = 1; i <= T; i++)
            {
                Tempo = 0;
                string [] vet = Console.ReadLine().Split(' ');
                PA = int.Parse(vet[0]);
                PB = int.Parse(vet[1]);
                TA = double.Parse(vet[2]);
                TB= double.Parse(vet[3]);
                double PAb = PA, PBb = PB;

                while (PAb <= PBb)
                {
                    PAb = PAb + ((PAb * TA) / 100);
                    PBb = PBb + ((PBb * TB) / 100);
                    Tempo++;

                    if (Tempo > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                if (Tempo <= 100)
                {
                    Console.WriteLine($"{Tempo} anos.");
                }
            }
        }
    }
}
