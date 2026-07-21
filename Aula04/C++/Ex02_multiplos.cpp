/*
 * Enunciado:
 * Leia dois valores inteiros (A e B). Após, o programa deve mostrar
 * uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se
 * os valores lidos são múltiplos entre si.
 *
 * Atenção:
 * Os números podem ser digitados em ordem crescente ou decrescente.
 */

// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    // Variáveis que armazenam os valores informados pelo usuário
    int A = 0;
    int B = 0;

    // Entrada dos valores
    cout << "Digite o valor de A: ";
    cin >> A;

    cout << "Digite o valor de B: ";
    cin >> B;

    // Verifica se algum valor é zero para evitar divisão inválida
    if (A == 0 || B == 0)
    {
        cout << "Não é possível verificar múltiplos com zero." << endl;
    }
    else
    {
        // Verifica qual valor deve ser usado como divisor
        if (A > B)
        {
            if (A % B == 0)
            {
                cout << "São múltiplos!" << endl;
            }
            else
            {
                cout << "Não são múltiplos!" << endl;
            }
        }
        else
        {
            if (B % A == 0)
            {
                cout << "São múltiplos!" << endl;
            }
            else
            {
                cout << "Não são múltiplos!" << endl;
            }
        }
    }

}