/*
 * Enunciado:
 * Desenvolva um programa que leia 10 números inteiros e armazene-os
 * em um vetor.
 *
 * Depois, solicite um número para pesquisar no vetor.
 *
 * Caso o número exista, mostre todas as posições em que ele aparece
 * e a quantidade de ocorrências encontradas.
 */


// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Vetor para armazenar os 10 números
    int vetor[10];

    int numProcurado = 0;
    int ocorrencias = 0;


    // Entrada dos valores no vetor
    for(int i = 0; i < 10; i++)
    {
        cout << "Digite o número " << i + 1 << ": ";
        cin >> vetor[i];
    }


    // Número que será pesquisado
    cout << "\nDigite o número que deseja pesquisar: ";
    cin >> numProcurado;


    cout << "\nNúmero encontrado nas posições: ";


    // Percorre o vetor procurando todas as ocorrências
    for(int i = 0; i < 10; i++)
    {
        if(vetor[i] == numProcurado)
        {
            cout << i << " ";
            ocorrencias++;
        }
    }


    // Verifica se encontrou algum número
    if(ocorrencias == 0)
    {
        cout << "Nenhuma";
        cout << "\nNúmero não encontrado!";
    }
    else
    {
        cout << "\nQuantidade de ocorrências: " << ocorrencias;
    }
}