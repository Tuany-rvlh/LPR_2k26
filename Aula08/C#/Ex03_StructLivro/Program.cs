/*
 * Enunciado:
 *
 * Defina uma struct chamada Livro contendo os seguintes campos:
 * Titulo, Autor, AnoPublicacao, NumeroPaginas e Preco.
 *
 * Desenvolva um programa que permita ao usuário cadastrar
 * os dados de 3 livros utilizando a struct criada.
 *
 * Ao final, o programa deverá calcular e exibir:
 * - O preço total dos livros cadastrados;
 * - A média de páginas dos livros.
 */


using System;

class Program
{
    // Struct com as características do livro
    public struct Livro
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
        public int NumeroPaginas;
        public double Preco;
    }


    static void Main()
    {
        // Vetor para armazenar 3 livros
        Livro[] livros = new Livro[3];

        double precoTotal = 0;
        int totalPaginas = 0;


        // Cadastro dos livros
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nCadastro do livro {i + 1}");


            Console.Write("Digite o título do livro: ");
            livros[i].Titulo = Console.ReadLine() ?? "";


            Console.Write("Digite o autor do livro: ");
            livros[i].Autor = Console.ReadLine() ?? "";


            Console.Write("Digite o ano de publicação do livro: ");
            livros[i].AnoPublicacao = int.Parse(Console.ReadLine()  ?? "");


            Console.Write("Digite o número de páginas do livro: ");
            livros[i].NumeroPaginas = int.Parse(Console.ReadLine()  ?? "");


            Console.Write("Digite o preço do livro: ");
            livros[i].Preco = double.Parse(Console.ReadLine() ?? "");

            // Acumula os valores
            precoTotal += livros[i].Preco;
            totalPaginas += livros[i].NumeroPaginas;

            Console.WriteLine();
        }


        // Calcula a média de páginas
        double mediaPaginas = totalPaginas / 3.0;


        // Exibe os resultados
        Console.WriteLine("\n===== RESULTADO =====");
        Console.WriteLine($"Preço total dos livros: R$ {precoTotal:F2}");
        Console.WriteLine($"Média de páginas por livro: {mediaPaginas:F2}");
    }
}