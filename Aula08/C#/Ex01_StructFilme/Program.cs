/*
 * Enunciado:
 *
 * Defina uma struct chamada Filme contendo os seguintes campos:
 * Titulo, Diretor, AnoLancamento e DuracaoMinutos.
 *
 * Desenvolva um programa que solicite os dados de 3 filmes
 * ao usuário e armazene as informações em um vetor de structs.
 *
 * Ao final, o programa deverá:
 * - Exibir todos os filmes cadastrados;
 * - Informar qual é o filme mais antigo, considerando o menor
 *   ano de lançamento.
 */

using System;

namespace Filmes
{
    internal class Program
    {
        // Struct criada para armazenar os dados do filme
        struct Filme
        {
            public string Titulo;
            public string Diretor;
            public int AnoLancamento;
            public int DuracaoMinutos;
        }


        static void Main(string[] args)
        {
            // Vetor de structs para armazenar 3 filmes
            Filme[] filmes = new Filme[3];


            // Cadastro dos filmes
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nCadastro do filme {i + 1}");


                Console.Write("Digite o título do filme: ");
                filmes[i].Titulo = Console.ReadLine() ?? "";


                Console.Write("Digite o diretor do filme: ");
                filmes[i].Diretor = Console.ReadLine() ?? "";


                Console.Write("Digite o ano de lançamento do filme: ");
                filmes[i].AnoLancamento = int.Parse(Console.ReadLine() ?? "0");


                Console.Write("Digite a duração em minutos do filme: ");
                filmes[i].DuracaoMinutos = int.Parse(Console.ReadLine() ?? "0");


                Console.WriteLine();
            }


            // Exibição dos filmes cadastrados
            Console.WriteLine("\n===== FILMES CADASTRADOS =====");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nFilme {i + 1}:");
                Console.WriteLine($"Título: {filmes[i].Titulo}");
                Console.WriteLine($"Diretor: {filmes[i].Diretor}");
                Console.WriteLine($"Ano de lançamento: {filmes[i].AnoLancamento}");
                Console.WriteLine($"Duração: {filmes[i].DuracaoMinutos} minutos");
            }


            // Encontrar o filme mais antigo
            int indiceMaisAntigo = 0;

            for (int i = 1; i < 3; i++)
            {
                if (filmes[i].AnoLancamento < filmes[indiceMaisAntigo].AnoLancamento)
                {
                    indiceMaisAntigo = i;
                }
            }


            // Exibir o filme mais antigo
            Console.WriteLine("\n===== FILME MAIS ANTIGO =====");
            Console.WriteLine($"Título: {filmes[indiceMaisAntigo].Titulo}");
            Console.WriteLine($"Ano de lançamento: {filmes[indiceMaisAntigo].AnoLancamento}");
        }
    }
}