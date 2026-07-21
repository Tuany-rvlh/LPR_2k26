/*
 * Enunciado:
 * Desenvolva um programa que leia 10 números inteiros e armazene-os
 * em um vetor.
 *
 * Depois, crie automaticamente dois vetores:
 * - Um contendo apenas os números pares;
 * - Outro contendo apenas os números ímpares.
 *
 * Ao final, exiba os dois vetores separados.
 */


// Vetores criados para armazenar os números, pares e ímpares
int[] vetor = new int[10];
int[] par = new int[10];
int[] impar = new int[10];


// Variáveis para controlar a posição dos vetores de pares e ímpares
int qtdPar = 0;
int qtdImpar = 0;


// Leitura dos 10 números
for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o número {i + 1}: ");
    vetor[i] = Convert.ToInt32(Console.ReadLine());


    // Verifica se o número é par
    if (vetor[i] % 2 == 0)
    {
        par[qtdPar] = vetor[i]; // Armazena o número no vetor de pares
        qtdPar++; // Aumenta a posição do próximo número par
    }
    else
    {
        impar[qtdImpar] = vetor[i]; // Armazena o número no vetor de ímpares
        qtdImpar++; // Aumenta a posição do próximo número ímpar
    }
}


// Exibe os números pares
Console.Write("PAR: ");

for (int i = 0; i < qtdPar; i++)
{
    Console.Write(par[i] + " ");
}


// Exibe os números ímpares
Console.Write("\nÍMPAR: ");

for (int i = 0; i < qtdImpar; i++)
{
    Console.Write(impar[i] + " ");
}