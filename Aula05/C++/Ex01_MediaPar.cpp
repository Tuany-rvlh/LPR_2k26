/*
 * Enunciado:
 * Desenvolva um programa que calcule a média aritmética de um conjunto
 * de números pares fornecidos pelo usuário.
 *
 * O usuário deve informar primeiro a quantidade de números que serão
 * digitados e, em seguida, informar os valores.
 *
 * Números ímpares devem ser ignorados no cálculo da média.
 */

// Bibliotecas utilizadas
#include <iostream>
#include <iomanip>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    // Variável que armazena a quantidade de números que serão digitados
    int quantia = 0;

    cout << "Digite a quantidade de números que serão informados: ";
    cin >> quantia;

    // Variáveis para armazenar a soma e a quantidade de números pares
    double acumulador = 0;
    int cont = 0;

    // Variável de controle do while
    int i = 0;

    while (i < quantia)
    {
        int num = 0;

        cout << "Digite um número: ";
        cin >> num;

        // Verifica se o número é par
        if (num % 2 == 0)
        {
            acumulador += num;
            cont++;
        }

        i++;
    }

    // Verifica se existem números pares para calcular a média
    if (cont > 0)
    {
        double media = acumulador / cont;

        cout << fixed << setprecision(2);
        cout << "A média dos valores pares digitados será: " << media << endl;
    }
    else
    {
        cout << "Nenhum número par foi informado." << endl;
    }

}