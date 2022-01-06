using System;

//BEECROWD (URI)

//1006 | Média 2 | Iniciante

#region Enunciado
/* 
 * Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
 * A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B 
 * tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, 
 * sempre com uma casa decimal.
 */
#endregion

//por Marcelly Marsura

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
            double B = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
            double C = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
            double media = ((A * 2) + (B * 3) + (C * 5))/10;

            Console.WriteLine($"MEDIA = {media.ToString("0.0")}");
        }
    }

    
}
