using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variaveis
            string alturaS, raioS;
            float alturaF, raioF;
            float volume, area;
            float pi = 3.1415926f;

            // Pedir altura
            Console.WriteLine("Introduz altura: ");
            alturaS = Console.ReadLine();

            Console.WriteLine("Introduz o raio");
            raioS = Console.ReadLine();

            // Converter altura em float
            alturaF = Convert.ToSingle(alturaS);

            // Pedir o raio e converter o raio em float
            raioF = Convert.ToSingle(raioS);

            // Calcular o volume
            volume = pi * raioF * raioF * alturaF;

            // Calcular area superficial
            area = 2 * pi * raioF * (raioF + alturaF);

            // Mostrar resultados
            Console.WriteLine($"Volume é {volume:f3}");
            //Console.WriteLine($"A area é {area:f3}");
            Console.WriteLine("A area é {0:f3}", area);

            Console.Read();

        }
    }
}
