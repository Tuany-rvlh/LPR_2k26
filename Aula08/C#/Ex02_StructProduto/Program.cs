/*
 * Enunciado:
 *
 * Defina uma struct chamada Produto contendo os seguintes campos:
 * Nome, Codigo, Preco e Quantidade.
 *
 * Desenvolva um programa que permita ao usuário cadastrar
 * os dados de 3 produtos utilizando a struct criada.
 *
 * Ao final, o programa deverá calcular e exibir o valor total
 * em estoque, considerando o preço e a quantidade de cada produto.
 *
 * Fórmula:
 * Valor total em estoque = Preço × Quantidade
 */

using System;

namespace Produtos
{
    internal class Program
    {
        // Struct criada para armazenar os dados do produto
        struct Produto
        {
            public string Nome;
            public string Codigo;
            public float Preco;
            public float Quantidade;
        }


        static void Main(string[] args)
        {
            // Vetor de structs para armazenar 3 produtos
            Produto[] produtos = new Produto[3];

            float valorTotal = 0;


            // Cadastro dos produtos
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nCadastro do produto {i + 1}");


                Console.Write("Digite o nome do produto: ");
                produtos[i].Nome = Console.ReadLine() ?? "";


                Console.Write("Digite o código do produto: ");
                produtos[i].Codigo = Console.ReadLine() ?? "";


                Console.Write("Digite o preço do produto: ");
                produtos[i].Preco = float.Parse(Console.ReadLine() ?? "");


                Console.Write("Digite a quantidade do produto: ");
                produtos[i].Quantidade = float.Parse(Console.ReadLine() ?? "");


                // Soma o valor do produto no estoque
                valorTotal += produtos[i].Preco * produtos[i].Quantidade;
            }


            Console.WriteLine($"\nO valor total em estoque é: {valorTotal:F2} reais.");
        }
    }
}