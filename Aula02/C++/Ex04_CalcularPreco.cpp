/*
 * Enunciado:
 * Desenvolva um programa que leia o código de uma peça 1,
 * o número de peças 1, o valor unitário de cada peça 1,
 * o código de uma peça 2, o número de peças 2 e o valor
 * unitário de cada peça 2.
 *
 * Em seguida, calcule e mostre o valor a ser pago.
 */

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    // Variáveis para armazenar os dados das duas peças
    int codigo1, codigo2;
    int quantidade1, quantidade2;
    double valor1, valor2;

    // Lê todos os dados da primeira peça
    cin >> codigo1 >> quantidade1 >> valor1;

    // Lê todos os dados da segunda peça
    cin >> codigo2 >> quantidade2 >> valor2;

    // Calcula o valor total a pagar
    double resultado = (quantidade1 * valor1) + (quantidade2 * valor2);

    // Mostra o resultado com duas casas decimais
    cout << fixed << setprecision(2);
    cout << "VALOR A PAGAR: R$ " << resultado << endl;

}