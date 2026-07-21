/*
 * Enunciado:
 *
 * Construa uma lista de 100 números aleatórios.
 *
 * O programa deverá:
 * - Colocar os números em ordem crescente e imprimir a lista;
 * - Remover todos os números pares e imprimir a lista novamente;
 * - Informar quais números se repetem e se existe algum número repetido.
 */


using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Lista utilizada para armazenar os números aleatórios
        List<int> numeros100 = new();

        Random num = new Random();

        // Adiciona 100 números aleatórios na lista
        for (int i = 0; i < 100; i++)
        {
            int numeroAleatorio = num.Next(101);
            numeros100.Add(numeroAleatorio);
        }

        // Ordena a lista em ordem crescente
        numeros100.Sort();

        Console.WriteLine("Lista ordenada:");
        MostrarNumeros(numeros100);

        // Verifica os números repetidos
        VerificarRepetidos(numeros100);

        // Remove todos os números pares
        numeros100.RemoveAll(x => x % 2 == 0);

        Console.WriteLine("\n\nLista sem os números pares:");
        MostrarNumeros(numeros100);
    }

    // Função para exibir os números da lista
    static void MostrarNumeros(List<int> numeros)
    {
        foreach (int numero in numeros)
        {
            Console.Write($"{numero} ");
        }
    }

    // Função para verificar números repetidos
    static void VerificarRepetidos(List<int> numeros)
    {
        List<int> repetidos = new();


        foreach (int numero in numeros)
        {
            if (numeros.FindAll(x => x == numero).Count > 1 && !repetidos.Contains(numero))
            {
                repetidos.Add(numero);
            }
        }

        if (repetidos.Count > 0)
        {
            Console.WriteLine("\n\nNúmeros repetidos:");

            foreach (int numero in repetidos)
            {
                Console.Write($"{numero} ");
            }
        }
        else
        {
            Console.WriteLine("\n\nNão existem números repetidos.");
        }
    }
}