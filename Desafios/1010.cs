using System;

//BEECROWD (URI)

//1010 | Cálculo Simples | Iniciante

#region Enunciado
/* 
 * Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor 
 * unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor 
 * unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
 */
#endregion

//por Marcelly Marsura

namespace beecrowd
{
    class Program
    {
        struct Item
        {
            public int codigo;
            public int numero;
            public double valor;
        }

        static double CalculaValorTotal(Item peca)
        {
            double total = 0;
            string linha = Console.ReadLine();
            string[] dados = linha.Split(' ');
            peca.codigo = Convert.ToInt32(dados[0]);
            peca.numero = Convert.ToInt32(dados[1]);
            peca.valor = Convert.ToDouble(dados[2]);

            total = Math.Round(peca.numero * peca.valor, 2);
            return total;
        }

        static void Main(string[] args)
        {
            double soma = 0;

            Item p1 = new Item();
            Item p2 = new Item();

            soma += CalculaValorTotal(p1);
            soma += CalculaValorTotal(p2);

            Console.WriteLine($"VALOR A PAGAR: R$ {soma.ToString("0.00")}");

        }
    }

    
}
