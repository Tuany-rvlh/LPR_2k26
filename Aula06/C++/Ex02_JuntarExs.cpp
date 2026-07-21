/*
 * Enunciado:
 * Desenvolva um algoritmo em C++ que agrupe em funções os exercícios
 * 1, 3 e 4 da tarefa de estruturas de repetição.
 *
 * Cada exercício deve estar contido em uma função separada.
 * A função main deve possuir um menu para selecionar as opções.
 */

// Bibliotecas utilizadas
#include <iostream>
#include <iomanip>
#include <clocale>

using namespace std;


// Exibe o menu de opções
void menu()
{
    cout << endl;
    cout << "==============================" << endl;
    cout << "            MENU" << endl;
    cout << "==============================" << endl;

    cout << "1 - Média dos números pares" << endl;
    cout << "2 - Soma dos ímpares múltiplos de 3" << endl;
    cout << "3 - Soma dos dígitos do quadrado" << endl;
    cout << "4 - Sair" << endl;
}


// Calcula a média dos números pares informados
double MediaPar(int quantidade)
{
    double soma = 0;
    int contadorPares = 0;

    for (int i = 0; i < quantidade; i++)
    {
        int num;

        cout << "Digite um número: ";
        cin >> num;

        if (num % 2 == 0)
        {
            soma += num;
            contadorPares++;
        }
    }

    if (contadorPares == 0)
    {
        return 0;
    }

    return soma / contadorPares;
}


// Soma os números ímpares múltiplos de 3 dentro de um intervalo
int SomaImparesMultiplos3(int inicio, int fim)
{
    int soma = 0;

    for (int i = inicio; i <= fim; i++)
    {
        if (i % 2 != 0 && i % 3 == 0)
        {
            soma += i;
        }
    }

    return soma;
}


// Soma os dígitos do quadrado de um número
int SomaDigitosQuadrado(int num)
{
    int quadrado = num * num;
    int soma = 0;

    while (quadrado > 0)
    {
        soma += quadrado % 10;
        quadrado /= 10;
    }

    return soma;
}


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int opcao = 0;


    do
    {
        menu();

        cout << "Digite a opção desejada: ";
        cin >> opcao;


        switch (opcao)
        {
            case 1:
            {
                int quantidade;

                cout << "Digite a quantidade de números: ";
                cin >> quantidade;

                double media = MediaPar(quantidade);

                cout << fixed << setprecision(2);
                cout << "A média dos números pares é: "
                     << media << endl;

                break;
            }


            case 2:
            {
                int resultado = SomaImparesMultiplos3(50, 500);

                cout << "A soma dos números ímpares múltiplos de 3 é: "
                     << resultado << endl;

                break;
            }


            case 3:
            {
                int num;

                cout << "Digite um número: ";
                cin >> num;

                int resultado = SomaDigitosQuadrado(num);

                cout << "A soma dos dígitos do quadrado é: "
                     << resultado << endl;

                break;
            }


            case 4:
                cout << "Saindo do programa..." << endl;
                break;


            default:
                cout << "Opção inválida! Tente novamente." << endl;
        }


    } while (opcao != 4);

}