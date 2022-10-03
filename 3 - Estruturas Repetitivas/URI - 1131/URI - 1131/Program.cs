using System;

namespace URI___1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int inter, gremio, vinter = 0, vgremio = 0, empates = 0, grenais = 0;
            int comand = 1;
            
            while (comand == 1 && comand != 2)
            {
                String[] vet = Console.ReadLine().Split(' ');
                inter = int.Parse(vet[0]);
                gremio = int.Parse(vet[1]);

                if (inter > gremio) 
                {
                    vinter += 1;
                }
                else if (inter < gremio)
                {
                    vgremio += 1;
                }
                else 
                {
                    empates += 1;
                }

                grenais += 1;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                comand = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{vinter}");
            Console.WriteLine($"Gremio:{vgremio}");
            Console.WriteLine($"Empates:{empates}");

            if (vinter > vgremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vinter < vgremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else 
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
