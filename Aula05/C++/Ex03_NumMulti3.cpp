/*
 * Enunciado:
 * Desenvolva um algoritmo que calcule a soma de todos os números
 * ímpares que são múltiplos de 3 e que estejam no conjunto dos
 * números de 50 a 500.
 */

// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    // Variável que irá armazenar a soma dos números encontrados
    int soma = 0;

    // Percorre todos os números entre 50 e 500
    for (int i = 50; i <= 500; i++)
    {
        // Verifica se o número é ímpar e múltiplo de 3
        if (i % 2 != 0 && i % 3 == 0)
        {
            soma += i;
        }
    }

    // Exibe o resultado da soma
    cout << "A soma de todos os números ímpares múltiplos de 3 entre 50 e 500 é: "
         << soma << endl;

}