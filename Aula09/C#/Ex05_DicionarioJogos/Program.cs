/*
 * Enunciado:
 *
 * Crie um programa que utilize um dicionário para armazenar jogos
 * e seus respectivos gêneros.
 *
 * O programa deverá:
 * - Cadastrar pelo menos 5 jogos informados pelo usuário;
 * - Armazenar o nome do jogo e seu gênero em um dicionário;
 * - Solicitar o nome de um jogo e exibir seu gênero;
 * - Caso o jogo não esteja cadastrado, informar que ele não foi encontrado.
 */


using System;
using System.Collections.Generic; // Biblioteca para utilizar dicionários


class Program
{
    static void Main()
    {
        // Dicionário para armazenar o nome do jogo e seu gênero
        Dictionary<string, string> jogos = new();

        string jogo;
        string genero;

        // Cadastro dos jogos
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o nome do jogo: ");
            jogo = Console.ReadLine() ?? "";

            Console.Write("Digite o gênero desse jogo: ");
            genero = Console.ReadLine() ?? "";

            jogos.Add(jogo, genero);

            Console.WriteLine();
        }

        // Busca de um jogo cadastrado
        Console.Write("Digite o nome de um dos jogos cadastrados: ");
        string procura = Console.ReadLine() ?? "";

        // Verifica se o jogo existe no dicionário
        if (jogos.ContainsKey(procura))
        {
            Console.WriteLine($"O gênero do seu jogo é: {jogos[procura]}");
        }
        else
        {
            Console.WriteLine("Não foi possível encontrar o jogo informado.");
        }
    }
}