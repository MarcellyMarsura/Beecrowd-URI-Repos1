using System;

//BEECROWD (URI)

//1002 | Área do Círculo | Iniciante

#region Enunciado
/* 
 * A fórmula para calcular a área de uma circunferência é: area = π . raio2. 
 * Considerando para este problema que π = 3.14159:
 * Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.
 */
#endregion

//por Marcelly Marsura

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double raio = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

            Console.WriteLine($"A={(PI * Math.Pow(raio, 2)).ToString("0.0000")}");
        }
    }

    
}
