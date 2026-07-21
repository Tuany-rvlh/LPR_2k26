/*
 * Enunciado:
 * Desenvolva um programa que leia quatro valores inteiros A, B, C e D.
 *
 * Em seguida, calcule a diferença entre o produto de A e B
 * pelo produto de C e D.
 *
 * Fórmula:
 * diferença = (A × B) - (C × D)
 *
 * Ao final, apresente o resultado da diferença calculada.
 */

// Bibliotecas utilizadas
#include <iostream>

using namespace std;

int main()
{
    // Variáveis que vão armazenar os quatro valores informados pelo usuário
    int A, B, C, D;

    // Variável que irá guardar o resultado da diferença dos produtos
    int diferenca;

    // Leitura dos valores digitados pelo usuário
    cout << "Digite o valor de A: ";
    cin >> A;

    cout << "Digite o valor de B: ";
    cin >> B;

    cout << "Digite o valor de C: ";
    cin >> C;

    cout << "Digite o valor de D: ";
    cin >> D;

    // Calcula a diferença entre o produto de A e B pelo produto de C e D
    diferenca = (A * B) - (C * D);

    // Exibe o resultado final na tela
    cout << "A diferença é: " << diferenca << endl;

}