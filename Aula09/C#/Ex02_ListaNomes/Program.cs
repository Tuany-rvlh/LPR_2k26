/*
 * Exercício:
 * Construa uma lista de X nomes aleatórios.
 * A saída deve mostrar os nomes ordenados pelo tamanho,
 * começando pelo menor.
 * Nomes com o mesmo tamanho devem aparecer em linhas diferentes,
 * mantendo a ordem em que foram digitados.
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista que irá armazenar os nomes digitados
        List<string> nomes = new List<string>();

        Console.Write("Quantidade de nomes: ");
        int quantidade = int.Parse(Console.ReadLine());

        // Cadastro dos nomes
        for (int i = 0; i < quantidade; i++)
        {
            nomes.Add(Console.ReadLine());
        }

        // Ordena os nomes pelo tamanho
        OrdenarNomes(nomes);

        // Exibe os nomes seguindo as regras do exercício
        ExibirNomes(nomes);
    }


    // Função responsável por ordenar os nomes pelo número de caracteres
    static void OrdenarNomes(List<string> nomes)
    {
        for (int i = 0; i < nomes.Count - 1; i++)
        {
            for (int j = i + 1; j < nomes.Count; j++)
            {
                // Troca os nomes caso o próximo seja menor
                if (nomes[i].Length > nomes[j].Length)
                {
                    string aux = nomes[i];
                    nomes[i] = nomes[j];
                    nomes[j] = aux;
                }
            }
        }
    }


    // Função responsável por exibir os nomes em linhas diferentes
    // quando possuem o mesmo tamanho
    static void ExibirNomes(List<string> nomes)
    {
        // Lista para controlar quais nomes já foram exibidos
        List<bool> usado = new List<bool>();

        for (int i = 0; i < nomes.Count; i++)
        {
            usado.Add(false);
        }


        bool existemNomes = true;

        // Continua criando linhas enquanto houver nomes para mostrar
        while (existemNomes)
        {
            existemNomes = false;

            // Guarda o tamanho do último nome exibido na linha
            int ultimoTamanho = -1;

            bool primeiro = true;


            for (int i = 0; i < nomes.Count; i++)
            {
                // Mostra apenas um nome de cada tamanho por linha
                if (!usado[i] && nomes[i].Length != ultimoTamanho)
                {
                    if (!primeiro)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(nomes[i]);

                    usado[i] = true;

                    ultimoTamanho = nomes[i].Length;

                    primeiro = false;

                    existemNomes = true;
                }
            }

            // Pula para a próxima linha
            if (existemNomes)
            {
                Console.WriteLine();
            }
        }
    }
}