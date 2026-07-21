/*
 * Enunciado:
 * Desenvolva um programa que leia duas matrizes A e B,
 * ambas de tamanho 3x3, e calcule a multiplicação entre elas (A * B).
 *
 * O programa deve:
 * - Ler todos os valores da matriz A;
 * - Ler todos os valores da matriz B;
 * - Realizar a multiplicação das duas matrizes;
 * - Exibir a matriz resultante.
 */


#include <iostream>
#include <locale.h>

using namespace std;


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Declarar as matrizes
    int matrizA[3][3];
    int matrizB[3][3];
    int matrizAB[3][3];


    // Preencher as matrizes A e B
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 3; j++)
        {
            // Solicitar os valores da matriz A
            cout << "Digite o valor para a posição [" << i << "][" << j << "] da matriz A: ";
            cin >> matrizA[i][j];


            // Solicitar os valores da matriz B
            cout << "Digite o valor para a posição [" << i << "][" << j << "] da matriz B: ";
            cin >> matrizB[i][j];

            cout << endl;
        }
    }


    // Cálculo da multiplicação das matrizes A * B


    // Primeira linha
    matrizAB[0][0] = (matrizA[0][0] * matrizB[0][0]) + (matrizA[0][1] * matrizB[1][0]) + (matrizA[0][2] * matrizB[2][0]);
    matrizAB[0][1] = (matrizA[0][0] * matrizB[0][1]) + (matrizA[0][1] * matrizB[1][1]) + (matrizA[0][2] * matrizB[2][1]);
    matrizAB[0][2] = (matrizA[0][0] * matrizB[0][2]) + (matrizA[0][1] * matrizB[1][2]) + (matrizA[0][2] * matrizB[2][2]);


    // Segunda linha
    matrizAB[1][0] = (matrizA[1][0] * matrizB[0][0]) + (matrizA[1][1] * matrizB[1][0]) + (matrizA[1][2] * matrizB[2][0]);
    matrizAB[1][1] = (matrizA[1][0] * matrizB[0][1]) + (matrizA[1][1] * matrizB[1][1]) + (matrizA[1][2] * matrizB[2][1]);
    matrizAB[1][2] = (matrizA[1][0] * matrizB[0][2]) + (matrizA[1][1] * matrizB[1][2]) + (matrizA[1][2] * matrizB[2][2]);


    // Terceira linha
    matrizAB[2][0] = (matrizA[2][0] * matrizB[0][0]) + (matrizA[2][1] * matrizB[1][0]) + (matrizA[2][2] * matrizB[2][0]);
    matrizAB[2][1] = (matrizA[2][0] * matrizB[0][1]) + (matrizA[2][1] * matrizB[1][1]) + (matrizA[2][2] * matrizB[2][1]);
    matrizAB[2][2] = (matrizA[2][0] * matrizB[0][2]) + (matrizA[2][1] * matrizB[1][2]) + (matrizA[2][2] * matrizB[2][2]);


    // Mostrar a matriz resultante
    cout << "\nMatriz resultante A * B:" << endl;

    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 3; j++)
        {
            cout << matrizAB[i][j] << " ";
        }

        cout << endl;
    }


}