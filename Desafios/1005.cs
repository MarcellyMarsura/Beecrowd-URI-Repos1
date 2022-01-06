using System;

//BEECROWD (URI)

//1005 | Média 1 | Iniciante

#region Enunciado
/* 
 * Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 
 * 2 notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A 
 * tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma 
 * que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
 */
#endregion

//por Marcelly Marsura

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            double B = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            double media = ((A * 3.5) + (B * 7.5))/11;

            Console.WriteLine($"MEDIA = {media.ToString("0.00000")}");
        }
    }

    
}
