/*
 * Enunciado:
 * Desenvolva um programa que solicite ao usuário um número e calcule
 * a soma dos dígitos do quadrado desse número.
 *
 * Exemplo:
 * 123² = 15129
 * Soma dos dígitos: 1 + 5 + 1 + 2 + 9 = 18
 */

// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    // Variáveis para armazenar o número, o quadrado e a soma dos dígitos
    int num = 0;
    int quadrado = 0;
    int contador = 0;
    int soma = 0;

    // Entrada do número
    cout << "Digite um número: ";
    cin >> num;

    // Calcula o quadrado do número informado
    quadrado = num * num;

    // Copia o valor do quadrado para retirar seus dígitos
    contador = quadrado;

    // Soma cada dígito do quadrado
    while (contador > 0)
    {
        soma += contador % 10;
        contador = contador / 10;
    }

    // Exibe o resultado
    cout << "O quadrado do número é: " << quadrado << endl;
    cout << "A soma dos dígitos do quadrado é: " << soma << endl;

}