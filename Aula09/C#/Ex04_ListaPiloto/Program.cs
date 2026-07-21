/*
 * Enunciado:
 *
 * Crie uma struct chamada Piloto contendo:
 * Nome, Equipe e Pontuação.
 *
 * O programa deverá utilizar uma lista para armazenar os competidores.
 *
 * Implemente as seguintes funções:
 * - CadastrarPiloto();
 * - ExibirRanking();
 * - CalcularPontuacaoMedia();
 * - ExibirMelhorEquipe();
 *
 * O programa deve:
 * - Cadastrar 10 pilotos;
 * - Exibir um ranking em ordem decrescente de pontuação;
 * - Calcular a média de pontos do campeonato;
 * - Exibir quantos pilotos ficaram acima da média;
 * - Determinar qual equipe possui a maior soma de pontos.
 */


using System;
using System.Collections.Generic;


class Program
{
    // Lista para armazenar os pilotos cadastrados
    static List<Piloto> Cadastro10 = new();

    // Struct criada para armazenar as características do piloto
    public struct Piloto
    {
        public string Nome;
        public string Equipe;
        public double Pontuacao;
    }

    static void Main()
    {
        CadastrarPiloto();

        ExibirRanking();

        CalcularPontuacaoMedia();

        ExibirMelhorEquipe();
    }

    static void CadastrarPiloto()
    {
        // Cadastro dos 10 pilotos
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nCadastro do Piloto {i + 1}");

            Piloto piloto = new Piloto();

            Console.Write("Digite o nome do piloto: ");
            piloto.Nome = Console.ReadLine() ?? "";

            Console.Write("Digite a equipe do piloto: ");
            piloto.Equipe = Console.ReadLine() ?? "";

            Console.Write("Digite a pontuação do piloto: ");
            piloto.Pontuacao = Convert.ToDouble(Console.ReadLine());

            Cadastro10.Add(piloto);
        }
    }

    static void ExibirRanking()
    {
        // Ordena a lista pela pontuação de forma decrescente
        Cadastro10.Sort((a, b) => b.Pontuacao.CompareTo(a.Pontuacao));


        Console.WriteLine("\n===== RANKING =====");


        for (int i = 0; i < Cadastro10.Count; i++)
        {
            Console.WriteLine($"{i + 1}º - {Cadastro10[i].Nome} | {Cadastro10[i].Equipe} | {Cadastro10[i].Pontuacao} pontos");
        }
    }

    static void CalcularPontuacaoMedia()
    {
        double soma = 0;

        foreach (Piloto piloto in Cadastro10)
        {
            soma += piloto.Pontuacao;
        }

        double media = soma / Cadastro10.Count;
        int acimaMedia = 0;

        foreach (Piloto piloto in Cadastro10)
        {
            if (piloto.Pontuacao > media)
            {
                acimaMedia++;
            }
        }

        Console.WriteLine($"\nMédia de pontos do campeonato: {media:F2}");
        Console.WriteLine($"Pilotos acima da média: {acimaMedia}");
    }

    static void ExibirMelhorEquipe()
    {
        Dictionary<string, double> equipes = new();

        foreach (Piloto piloto in Cadastro10)
        {
            if (equipes.ContainsKey(piloto.Equipe))
            {
                equipes[piloto.Equipe] += piloto.Pontuacao;
            }
            else
            {
                equipes.Add(piloto.Equipe, piloto.Pontuacao);
            }
        }

        string melhorEquipe = "";
        double maiorPontuacao = 0;

        foreach (var equipe in equipes)
        {
            if (equipe.Value > maiorPontuacao)
            {
                maiorPontuacao = equipe.Value;
                melhorEquipe = equipe.Key;
            }
        }

        Console.WriteLine($"\nMelhor equipe: {melhorEquipe}");
        Console.WriteLine($"Pontuação total: {maiorPontuacao}");
    }
}