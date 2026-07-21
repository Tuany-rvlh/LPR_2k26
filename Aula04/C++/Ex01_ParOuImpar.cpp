/*
 * Enunciado:
 * Desenvolva um programa que leia um número inteiro e informe
 * se esse número é par ou ímpar.
 *
 * Um número é considerado par quando o resto da divisão por 2
 * é igual a zero.
 */

// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); //Permite acentuação em português

    // Variável que irá armazenar o número informado pelo usuário
    int num = 0;

    // Entrada do número
    cout << "Digite um número inteiro: ";
    cin >> num;

    // Verifica se a entrada foi válida
    if (cin.fail())
    {
        cout << "Valor inválido! Digite um número inteiro." << endl;
    }
    else
    {
        // Verifica se o número é par ou ímpar
        if (num % 2 == 0)
        {
            cout << "O número é PAR" << endl;
        }
        else
        {
            cout << "O número é ÍMPAR" << endl;
        }
    }

}