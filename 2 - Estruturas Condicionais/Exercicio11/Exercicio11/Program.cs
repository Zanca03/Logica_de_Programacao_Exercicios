using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int ihour, iminute, fhour, fminute;
            String[] vet = Console.ReadLine().Split(' ');
            ihour = int.Parse(vet[0]);
            iminute = int.Parse(vet[1]);
            fhour = int.Parse(vet[2]);
            fminute = int.Parse(vet[3]);

            int hour = fhour - ihour;
            //Primeiro hora final menos hora final menos hora inicial, depois, se o resultado for menor que
            //zero, o resultado mais 24. Assim, dando o valor das horas.
            if (hour < 0) 
            {
                hour += 24;
            }
        
            int minute = fminute - iminute;
            //Se os minutos forem menores que zero, acrescenta-se mais 60 e menos 1 nas horas.
            if (minute < 0) 
            {
                minute += 60;
                hour -= 1;
                if (hour < 0)
                {
                    hour += 24;
                }
            }

            if (hour == 0 && minute == 0) 
            {
                // Se o resultado for 0 tanto nas horas quanto nos minutos, então o resultado é 24 horas.
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else 
            {
                Console.WriteLine($"O JOGO DUROU {hour} HORA(S) E {minute} MINUTO(S)");
            }
        }
    }
}
