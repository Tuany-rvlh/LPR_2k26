/*
 * Enunciado:
 * 
 * Crie uma struct chamada Livro contendo:
 * - Título
 * - Autor
 * - Ano de publicação
 * - Quantidade disponível
 *
 * Utilize um Dictionary onde:
 * Chave: Código do livro
 * Valor: Struct Livro
 *
 * O programa deverá permitir:
 * - Cadastrar livros;
 * - Buscar livro pelo código;
 * - Realizar empréstimos reduzindo a quantidade disponível;
 * - Impedir empréstimos quando não houver exemplares;
 * - Exibir relatório com:
 *   - Total de livros cadastrados;
 *   - Livro mais antigo;
 *   - Livro com maior quantidade disponível;
 *   - Quantidade de livros por autor.
 */

using System;
using System.Collections.Generic;

class Program
{
    // Struct com as informações do livro
    public struct Livro
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
        public int QuantidadeDisponivel;
    }


    // Função para exibir o menu principal
    static void MenuPrincipal()
    {
        Console.WriteLine("========== Sistema de Biblioteca ==========");
        Console.WriteLine("1. Cadastrar Livro");
        Console.WriteLine("2. Buscar Livro");
        Console.WriteLine("3. Emprestar Livro");
        Console.WriteLine("4. Exibir Relatório");
        Console.WriteLine("5. Sair");
        Console.WriteLine("===========================================");
        Console.WriteLine();
    }


    // Função para cadastrar livros
    static void CadastrarLivro(Dictionary<int, Livro> biblioteca)
    {
        if (biblioteca.Count >= 10)
        {
            Console.WriteLine("Limite de 10 livros cadastrados atingido.");
            return;
        }


        Console.Write("Digite o código do livro: ");
        int codigo;

        while (!int.TryParse(Console.ReadLine(), out codigo))
        {
            Console.Write("Código inválido! Digite novamente: ");
        }


        if (biblioteca.ContainsKey(codigo))
        {
            Console.WriteLine("Já existe um livro com esse código.");
            return;
        }


        Livro livro = new Livro();


        Console.Write("Digite o título do livro: ");
        livro.Titulo = Console.ReadLine() ?? "Não informado";


        Console.Write("Digite o autor do livro: ");
        livro.Autor = Console.ReadLine() ?? "Não informado";


        Console.Write("Digite o ano de publicação: ");

        while (!int.TryParse(Console.ReadLine(), out livro.AnoPublicacao))
        {
            Console.Write("Ano inválido! Digite novamente: ");
        }


        Console.Write("Digite a quantidade disponível: ");

        while (!int.TryParse(Console.ReadLine(), out livro.QuantidadeDisponivel))
        {
            Console.Write("Quantidade inválida! Digite novamente: ");
        }


        biblioteca.Add(codigo, livro);


        Console.WriteLine("Livro cadastrado com sucesso!");
        Console.WriteLine();
    }



    // Função para buscar livro pelo código
    static void BuscarLivro(Dictionary<int, Livro> biblioteca)
    {
        Console.Write("Digite o código do livro: ");

        if (int.TryParse(Console.ReadLine(), out int codigo))
        {
            if (biblioteca.ContainsKey(codigo))
            {
                Livro livro = biblioteca[codigo];

                Console.WriteLine();
                Console.WriteLine("Livro encontrado:");
                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
                Console.WriteLine($"Ano: {livro.AnoPublicacao}");
                Console.WriteLine($"Quantidade disponível: {livro.QuantidadeDisponivel}");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Código inválido.");
        }

        Console.WriteLine();
    }



    // Função para realizar empréstimo de livro
    static void EmprestarLivro(Dictionary<int, Livro> biblioteca)
    {
        Console.Write("Digite o código do livro: ");

        if (int.TryParse(Console.ReadLine(), out int codigo))
        {
            if (biblioteca.ContainsKey(codigo))
            {
                Livro livro = biblioteca[codigo];


                if (livro.QuantidadeDisponivel > 0)
                {
                    livro.QuantidadeDisponivel--;

                    biblioteca[codigo] = livro;

                    Console.WriteLine("Empréstimo realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não existem exemplares disponíveis.");
                }
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Código inválido.");
        }

        Console.WriteLine();
    }



    // Função para exibir relatório da biblioteca
    static void ExibirRelatorio(Dictionary<int, Livro> biblioteca)
    {
        if (biblioteca.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
            return;
        }


        Livro livroMaisAntigo = new Livro();
        Livro maiorQuantidade = new Livro();


        bool primeiro = true;


        Dictionary<string, int> livrosPorAutor = new Dictionary<string, int>();


        foreach (Livro livro in biblioteca.Values)
        {
            // Define o primeiro livro como referência inicial
            if (primeiro)
            {
                livroMaisAntigo = livro;
                maiorQuantidade = livro;
                primeiro = false;
            }


            // Verifica livro mais antigo
            if (livro.AnoPublicacao < livroMaisAntigo.AnoPublicacao)
            {
                livroMaisAntigo = livro;
            }


            // Verifica livro com maior quantidade disponível
            if (livro.QuantidadeDisponivel > maiorQuantidade.QuantidadeDisponivel)
            {
                maiorQuantidade = livro;
            }


            // Conta livros por autor
            if (livrosPorAutor.ContainsKey(livro.Autor))
            {
                livrosPorAutor[livro.Autor]++;
            }
            else
            {
                livrosPorAutor.Add(livro.Autor, 1);
            }
        }


        Console.WriteLine("============== Relatório ==============");
        Console.WriteLine($"Total de livros cadastrados: {biblioteca.Count}");
        Console.WriteLine();

        Console.WriteLine("Livro mais antigo:");
        Console.WriteLine($"Título: {livroMaisAntigo.Titulo}");
        Console.WriteLine($"Ano: {livroMaisAntigo.AnoPublicacao}");
        Console.WriteLine();

        Console.WriteLine("Livro com maior quantidade disponível:");
        Console.WriteLine($"Título: {maiorQuantidade.Titulo}");
        Console.WriteLine($"Quantidade: {maiorQuantidade.QuantidadeDisponivel}");
        Console.WriteLine();


        Console.WriteLine("Quantidade de livros por autor:");

        foreach (var autor in livrosPorAutor)
        {
            Console.WriteLine($"{autor.Key}: {autor.Value} livro(s)");
        }


        Console.WriteLine("=======================================");
        Console.WriteLine();
    }



    static void Main()
    {
        // Dictionary para armazenar os livros
        // Chave: Código do livro
        // Valor: Struct Livro
        Dictionary<int, Livro> biblioteca = new Dictionary<int, Livro>();


        string opcao;


        do
        {
            MenuPrincipal();


            Console.Write("Digite a opção desejada: ");
            opcao = Console.ReadLine() ?? "5";


            switch (opcao)
            {
                case "1":
                    CadastrarLivro(biblioteca);
                    break;


                case "2":
                    BuscarLivro(biblioteca);
                    break;


                case "3":
                    EmprestarLivro(biblioteca);
                    break;


                case "4":
                    ExibirRelatorio(biblioteca);
                    break;


                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    break;


                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }


        } while (opcao != "5");
    }
}