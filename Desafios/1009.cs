using System;

//BEECROWD (URI)

//1009 | Salário com Bônus | Iniciante

#region Enunciado
/* 
 * Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total 
 * de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor 
 * ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber 
 * no final do mês, com duas casas decimais.
 */
#endregion

//por Marcelly Marsura

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            double vendas = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            double comissao = Math.Round(vendas * 0.15, 2);

            Console.WriteLine($"TOTAL = R$ {(salario + comissao).ToString("0.00")}");
        }
    }

    
}
