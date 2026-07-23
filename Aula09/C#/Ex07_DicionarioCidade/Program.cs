/*
 * Enunciado:
 * Construa um dicionário de X pares chave-valor,
 * onde as chaves são nomes de cidades e os valores
 * são suas respectivas populações.
 *
 * O programa deve:
 * - Encontrar cidades com população acima da média;
 * - Mostrar a cidade mais populosa e menos populosa;
 * - Remover cidades com uma população informada pelo usuário;
 * - Exibir o dicionário atualizado.
 */

using System;
using System.Collections.Generic;

class Program
{
    // Calcula a média das populações
    static double CalcularMedia(Dictionary<string, int> cidades)
    {
        int soma = 0;

        foreach (int populacao in cidades.Values)
        {
            soma += populacao;
        }

        return (double)soma / cidades.Count;
    }

    // Mostra cidades com população acima da média
    static void MostrarAcimaMedia(Dictionary<string, int> cidades)
    {
        double media = CalcularMedia(cidades);

        Console.WriteLine("\nCidades acima da média:");

        foreach (var cidade in cidades)
        {
            if (cidade.Value > media)
            {
                Console.WriteLine($"{cidade.Key} - {cidade.Value} habitantes");
            }
        }
    }

    // Encontra a cidade mais e menos populosa
    static void MostrarMaiorMenor(Dictionary<string, int> cidades)
    {
        string maiorCidade = "";
        string menorCidade = "";

        int maiorPopulacao = int.MinValue;
        int menorPopulacao = int.MaxValue;

        foreach (var cidade in cidades)
        {
            if (cidade.Value > maiorPopulacao)
            {
                maiorPopulacao = cidade.Value;
                maiorCidade = cidade.Key;
            }

            if (cidade.Value < menorPopulacao)
            {
                menorPopulacao = cidade.Value;
                menorCidade = cidade.Key;
            }
        }

        Console.WriteLine("\nCidade mais populosa:");
        Console.WriteLine($"{maiorCidade} - {maiorPopulacao} habitantes");

        Console.WriteLine("\nCidade menos populosa:");
        Console.WriteLine($"{menorCidade} - {menorPopulacao} habitantes");
    }

    // Remove cidades com determinada população
    static void RemoverPopulacao(Dictionary<string, int> cidades, int valor)
    {
        List<string> remover = new List<string>();

        foreach (var cidade in cidades)
        {
            if (cidade.Value == valor)
            {
                remover.Add(cidade.Key);
            }
        }

        foreach (string cidade in remover)
        {
            cidades.Remove(cidade);
        }
    }

    // Exibe o dicionário completo
    static void ExibirCidades(Dictionary<string, int> cidades)
    {
        Console.WriteLine("\nDicionário atualizado:");

        foreach (var cidade in cidades)
        {
            Console.WriteLine($"{cidade.Key} - {cidade.Value} habitantes");
        }
    }

    static void Main()
    {
        Dictionary<string, int> cidades = new Dictionary<string, int>();

        int quantidade;

        Console.Write("Digite a quantidade de cidades: ");
        quantidade = int.Parse(Console.ReadLine() ?? "0");

        // Cadastro das cidades
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("\nNome da cidade: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("População: ");
            int populacao = int.Parse(Console.ReadLine() ?? "0");

            cidades.Add(nome, populacao);
        }

        MostrarAcimaMedia(cidades);

        MostrarMaiorMenor(cidades);

        Console.Write("\nDigite uma população para remover: ");
        int valorRemover = int.Parse(Console.ReadLine() ?? "0");

        RemoverPopulacao(cidades, valorRemover);

        ExibirCidades(cidades);
    }
}