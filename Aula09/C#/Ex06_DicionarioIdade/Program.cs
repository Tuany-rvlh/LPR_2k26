/*
 * Enunciado:
 *
 * Construa um dicionário de X pares chave-valor onde as chaves são
 * nomes de pessoas e os valores são suas respectivas idades.
 *
 * O programa deverá:
 * - Encontrar e imprimir todas as pessoas com idade acima da média;
 * - Encontrar e imprimir a pessoa mais velha e a pessoa mais nova;
 * - Remover todas as pessoas com idade igual a um valor Y informado pelo usuário;
 * - Exibir o dicionário atualizado.
 */


using System;
using System.Collections.Generic; // Biblioteca para utilizar dicionários


class Program
{
    static void Main()
    {
        // Dicionário para armazenar nome e idade
        Dictionary<string, int> pessoasIdade = new();

        int quantidade;
        int soma = 0;

        Console.Write("Digite o número de pessoas cadastradas: ");
        quantidade = int.Parse(Console.ReadLine() ?? "0");

        // Cadastro das pessoas
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("\nDigite o nome da pessoa: ");
            string nome = Console.ReadLine() ?? "";


            Console.Write("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine() ?? "0");


            pessoasIdade.Add(nome, idade);
        }

        // Calcula a média das idades
        foreach (var pessoa in pessoasIdade)
        {
            soma += pessoa.Value;
        }

        double media = soma / (double)pessoasIdade.Count;

        Console.WriteLine($"\nMédia das idades: {media:F2}");

        // Pessoas acima da média
        Console.WriteLine("\nPessoas acima da média:");

        foreach (var pessoa in pessoasIdade)
        {
            if (pessoa.Value > media)
            {
                Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
            }
        }

        // Encontrar pessoa mais velha e mais nova
        string maisVelha = "";
        string maisNova = "";

        int maiorIdade = -1;
        int menorIdade = int.MaxValue;

        foreach (var pessoa in pessoasIdade)
        {
            if (pessoa.Value > maiorIdade)
            {
                maiorIdade = pessoa.Value;
                maisVelha = pessoa.Key;
            }


            if (pessoa.Value < menorIdade)
            {
                menorIdade = pessoa.Value;
                maisNova = pessoa.Key;
            }
        }

        Console.WriteLine($"\nPessoa mais velha: {maisVelha} - {maiorIdade} anos");
        Console.WriteLine($"Pessoa mais nova: {maisNova} - {menorIdade} anos");

        // Remover pessoas com uma idade informada
        Console.Write("\nDigite uma idade para remover: ");
        int idadeRemover = int.Parse(Console.ReadLine() ?? "0");

        List<string> remover = new();

        foreach (var pessoa in pessoasIdade)
        {
            if (pessoa.Value == idadeRemover)
            {
                remover.Add(pessoa.Key);
            }
        }

        foreach (string nome in remover)
        {
            pessoasIdade.Remove(nome);
        }

        // Exibir dicionário atualizado
        Console.WriteLine("\nDicionário atualizado:");

        foreach (var pessoa in pessoasIdade)
        {
            Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
        }
    }
}