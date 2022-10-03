using System;
using System.Globalization;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, media2, mediafinal;
            string[] vet = Console.ReadLine().Split(' ');
            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);
            media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + N4) / 10.0f;
            
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            if (media >= 7.0f)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0f)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                media2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediafinal = (media2 + media) / 2.0f;

                if (mediafinal >= 5.0f)
                {
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine("Nota do exame: " + media2.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine("Nota do exame: " + media2.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + mediafinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
