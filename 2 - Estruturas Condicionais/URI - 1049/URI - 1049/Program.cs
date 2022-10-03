using System;

namespace URI___1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipe1 = Console.ReadLine();
            string tipe2 = Console.ReadLine();
            string tipe3 = Console.ReadLine();

            if (tipe1 == "vertebrado") 
            {
                if (tipe2 == "ave") 
                {
                    if (tipe3 == "carnivoro") 
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (tipe3 == "onivoro") 
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (tipe2 == "mamifero") 
                {
                    if (tipe3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (tipe3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }

            else if (tipe1 == "invertebrado")
            {
                if (tipe2 == "inseto")
                {
                    if (tipe3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (tipe3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (tipe2 == "anelideo")
                {
                    if (tipe3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (tipe3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
