using System;

//BEECROWD (URI)

//1001 | Extremamente Básico | Iniciante

#region Enunciado
/* 
 * Leia 2 valores inteiros e armazene-os nas variáveis A e B. 
 * Efetue a soma de A e B atribuindo o seu resultado na variável X. 
 * Imprima X conforme exemplo apresentado abaixo. Não apresente 
 * mensagem alguma além daquilo que está sendo especificado e 
 * não esqueça de imprimir o fim de linha após o resultado, 
 * caso contrário, você receberá "Presentation Error".
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

            Console.WriteLine($"X = {A + B}");
        }
    }

    
}
