using System;

//BEECROWD (URI)

//1008 | Salário | Iniciante

#region Enunciado
/* 
 * Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas,
 * o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o 
 * número e o salário do funcionário, com duas casas decimais.
 */
#endregion

//por Marcelly Marsura

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            int horas = Convert.ToInt32(Console.ReadLine());
            double s = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            
            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {(horas * s).ToString("0.00")}");
        }
    }

    
}
