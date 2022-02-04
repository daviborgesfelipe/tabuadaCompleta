using System;

namespace tabuadaCompleta
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicador = 1;
            int multiplicando = 1;
            int resultado;

            while (multiplicador < 10)
            {
                Console.WriteLine($"\n##### Tabuada do numero: {multiplicador} #####\n");

                while (multiplicando <= 10)
                {
                    resultado = multiplicando * multiplicador;
                    Console.WriteLine($"{multiplicador} x {multiplicando} = {resultado}");
                    multiplicando = multiplicando + 1;
                }

                multiplicador = multiplicador + 1;
                multiplicando = 1;
            }
        }
    }
}
