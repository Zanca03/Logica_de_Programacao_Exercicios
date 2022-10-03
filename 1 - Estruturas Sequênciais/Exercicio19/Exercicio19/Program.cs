using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int iD, fD, iH, fH, iM, fM, iS, fS, iDia, fDia, total, resto, W, X, Y, Z;

            string[] inicio = Console.ReadLine().Split(' ');
            iD = int.Parse(inicio[1]);
            inicio = Console.ReadLine().Split(':');
            iH = int.Parse(inicio[0]);
            iM = int.Parse(inicio[1]);
            iS = int.Parse(inicio[2]);

            string[] final = Console.ReadLine().Split(' ');
            fD = int.Parse(final[1]);
            final = Console.ReadLine().Split(':');
            fH = int.Parse(final[0]);
            fM = int.Parse(final[1]);
            fS = int.Parse(final[2]);

            iDia = (iD - 1) * 24 * 60 * 60 + iH * 60 * 60 + iM * 60 + iS;
            fDia = (fD - 1) * 24 * 60 * 60 + fH * 60 * 60 + fM * 60 + fS;
            total = Math.Abs(iDia - fDia);

            W = total / (24 * 60 * 60);
            resto = total % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine($"{W} dia(s)");
            Console.WriteLine($"{X} hora(s)");
            Console.WriteLine($"{Y} minuto(s)");
            Console.WriteLine($"{Z} segundo(s)");
        }
    }
}
