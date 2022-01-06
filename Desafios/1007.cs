using System;

//BEECROWD (URI)

//1007 | Diferença | Iniciante

#region Enunciado
/* 
 * Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
 * de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
 */
#endregion

//por Marcelly Marsura

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());
            int diferenca = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }

    
}
