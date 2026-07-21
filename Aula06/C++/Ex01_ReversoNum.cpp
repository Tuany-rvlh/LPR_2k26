/*
 * Enunciado:
 * Desenvolva uma função em C++ que retorne o reverso de um número inteiro.
 */

// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;


// Função responsável por inverter o número informado
int reverter(int num)
{
    int num_reverso = 0;
    int resto = 0;

    // Retira cada dígito do número e monta o reverso
    while (num != 0)
    {
        resto = num % 10;
        num_reverso = num_reverso * 10 + resto;
        num /= 10;
    }

    return num_reverso;
}


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    int num = 0;

    // Entrada do número
    cout << "Digite o número que será invertido: ";
    cin >> num;


    // Chama a função e armazena o resultado
    int resultado = reverter(num);


    // Exibe o número invertido
    cout << "O inverso desse número é: " << resultado << endl;


}