using System;
using System.Collections.Generic;

namespace AppLogicaExerciciosPropostos_05
{
    /// <summary>
    /// Exercícios sobre Estrutura Condicional (if-else)
    /// OBS: Neste exemplo usei alguns recursos, não abordados no curso até então. Foreach \ Lista.. 
    /// Com base nos produtos do método criarListaProduto, escreva um programa que leia o código de um item e a 
    /// quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
    /// </summary>

    class Program
    {
        public static List<Produtos> criaListaProduto() 
        {
            List<Produtos> produtos = new List<Produtos>();

            Produtos produtos1 = new Produtos();
            Produtos produtos2 = new Produtos();
            Produtos produtos3 = new Produtos();
            Produtos produtos4 = new Produtos();
            Produtos produtos5 = new Produtos();

            produtos1.codigo = 1;
            produtos1.produto = "Cachorro Quente";
            produtos1.preco = 4.00;

            produtos2.codigo = 2;
            produtos2.produto = "X-Salada";
            produtos2.preco = 4.50;

            produtos3.codigo = 3;
            produtos3.produto = "X-Bacon";
            produtos3.preco = 5.00;

            produtos4.codigo = 4;
            produtos4.produto = "Torrada Simples";
            produtos4.preco = 2.00;

            produtos5.codigo = 5;
            produtos5.produto = "Refrigerante";
            produtos5.preco = 1.50;

            produtos.Add(produtos1);
            produtos.Add(produtos2);
            produtos.Add(produtos3);
            produtos.Add(produtos4);
            produtos.Add(produtos5);

            return produtos;
        }

        public static double valorTotalPgto(int codigo,int Qtd)
        {
            List<Produtos> produtos = criaListaProduto();
            double valorPgto = 0;

            foreach (var item in produtos)
            {
                if (item.codigo == codigo)
                {
                    valorPgto = (Qtd * item.preco);
                }
            }
            return valorPgto;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o código do produto e a quantidade: ");
            string[] vet = Console.ReadLine().Split(" ");
            int codigo = int.Parse(vet[0]);
            int Qtd = int.Parse(vet[1]);
            double valor =  valorTotalPgto(codigo, Qtd);

            Console.WriteLine("O valor total a ser pago é: {0}", valor.ToString("F2"));
            Console.ReadLine();

        }
    }
}
