/*
 * Enunciado:
 *
 * Crie um programa que permita ao usuário cadastrar notas de alunos
 * em uma lista.
 *
 * O programa deverá:
 * - Solicitar ao usuário 5 notas;
 * - Armazenar as notas em uma lista;
 * - Exibir todas as notas cadastradas;
 * - Informar a maior nota;
 * - Informar a menor nota;
 * - Calcular a média das notas.
 */


using System;
using System.Collections.Generic; // Biblioteca para utilizar listas


class Program
{
    static void Main()
    {
        // Lista para armazenar as notas
        List<float> notas = new List<float>();

        float soma = 0;

        // Cadastro das notas
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
            notas.Add(float.Parse(Console.ReadLine()));
        }

        // Inicializa maior e menor com a primeira nota da lista
        float maior = notas[0];
        float menor = notas[0];

        Console.Write("\nNotas cadastradas: ");

        // Percorre a lista para exibir e encontrar valores
        foreach (float numero in notas)
        {
            Console.Write(numero + " ");

            if (numero > maior)
            {
                maior = numero;
            }

            if (numero < menor)
            {
                menor = numero;
            }

            soma += numero;
        }

        Console.WriteLine($"\n\nMaior nota: {maior}");
        Console.WriteLine($"Menor nota: {menor}");
        Console.WriteLine($"Média das notas: {soma / notas.Count:F2}");
    }
}