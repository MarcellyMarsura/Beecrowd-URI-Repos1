using System;

//BEECROWD (URI)

//1003 | Soma Simples | Iniciante

#region Enunciado
/* 
 * Leia dois valores inteiros, no caso para variáveis A e B. 
 * A seguir, calcule a soma entre elas e atribua à variável SOMA. 
 * A seguir escrever o valor desta variável.
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
            int soma = A + B;

            Console.WriteLine($"SOMA = {soma}");
        }
    }

    
}
