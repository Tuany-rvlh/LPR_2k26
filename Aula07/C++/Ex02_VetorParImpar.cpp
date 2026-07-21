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


// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Vetores criados para armazenar os números, pares e ímpares
    int vetor[10];
    int par[10];
    int impar[10];


    // Variáveis para controlar a posição dos vetores de pares e ímpares
    int qtdPar = 0;
    int qtdImpar = 0;


    // Leitura dos 10 números
    for(int i = 0; i < 10; i++)
    {
        cout << "Digite o número " << i + 1 << ": ";
        cin >> vetor[i];


        // Verifica se o número é par
        if(vetor[i] % 2 == 0)
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
    cout << "\nPAR: ";

    for(int i = 0; i < qtdPar; i++)
    {
        cout << par[i] << " ";
    }


    // Exibe os números ímpares
    cout << "\nÍMPAR: ";

    for(int i = 0; i < qtdImpar; i++)
    {
        cout << impar[i] << " ";
    }

}