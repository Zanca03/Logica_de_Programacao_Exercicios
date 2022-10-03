using System;

namespace URI___1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = 0, alcool = 0, gasolina = 0, diesel = 0;

            while (entrada != 4) 
            {
                entrada = int.Parse(Console.ReadLine());
                switch (entrada)
                {
                    case 1:
                        alcool += 1;
                        break;

                    case 2:
                        gasolina += 1;
                        break;

                    case 3:
                        diesel += 1;
                        break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
