using System;

namespace At03
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {
                if (tipo == 1)
                {
                    Alcool++;
                }
                else if (tipo == 2)
                {
                    Gasolina++;
                }
                else if (tipo == 3)
                {
                    Diesel++;
                }

                tipo = int.Parse (Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {Alcool}");
            Console.WriteLine($"Gasolina: {Gasolina}");
            Console.WriteLine($"Diesel: {Diesel}");
        }
    }
}
