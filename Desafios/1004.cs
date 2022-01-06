using System;

//BEECROWD (URI)

//1004 | Produto Simples | Iniciante

#region Enunciado
/* 
 * Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores 
 * e atribua esta operação à variável PROD. A seguir mostre a variável PROD 
 * com mensagem correspondente.  
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
            int prod = A * B;

            Console.WriteLine($"PROD = {prod}");
        }
    }

    
}
