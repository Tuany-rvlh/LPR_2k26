/*
 * Enunciado:
 * Desenvolva um programa que leia uma matriz 3x3 de números inteiros.
 *
 * Ao final, mostre a matriz digitada e calcule a soma de todos
 * os elementos presentes nela.
 */


// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Declara uma matriz 3x3 e uma variável para armazenar a soma
    int matriz[3][3];
    int soma = 0;


    // Entrada dos valores da matriz
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 3; j++)
        {
            cout << "Digite o valor da posição [" << i << "][" << j << "]: ";
            cin >> matriz[i][j];

            soma += matriz[i][j]; // Soma o valor digitado
        }
    }


    // Exibe a matriz preenchida
    cout << "\nMatriz digitada:" << endl;

    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 3; j++)
        {
            cout << matriz[i][j] << " ";
        }

        cout << endl;
    }


    // Exibe a soma dos elementos da matriz
    cout << "\nSoma = " << soma << endl;


}