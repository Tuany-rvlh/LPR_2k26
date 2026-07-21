/*
 * Enunciado:
 * Desenvolva um programa que leia 5 números inteiros e armazene
 * esses valores em um vetor.
 *
 * Ao final, mostre todos os números digitados, o maior valor
 * armazenado e a posição em que ele se encontra.
 */


// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Cria um vetor de inteiros com 5 posições
    int vetor[5];


    // Entrada dos valores com verificação
    for(int i = 0; i < 5; i++)
    {
        while(true)
        {
            cout << "Digite o valor da posição " << i << ": ";
            cin >> vetor[i];


            // Verifica se a entrada é inválida
            if(cin.fail())
            {
                cout << "Valor inválido! Digite apenas números inteiros." << endl;

                // Limpa o estado de erro do cin
                cin.clear();

                // Descarta o valor inválido digitado
                cin.ignore(1000, '\n');
            }
            else
            {
                break; // Sai do while quando o valor for válido
            }
        }
    }


    // Considera inicialmente o primeiro valor como o maior
    int maiorValor = vetor[0];
    int posMaior = 0;


    // Procura o maior valor e sua posição
    for(int i = 1; i < 5; i++)
    {
        if(vetor[i] > maiorValor)
        {
            maiorValor = vetor[i];
            posMaior = i;
        }
    }


    // Exibe os valores armazenados
    cout << "\nVetor: ";

    for(int i = 0; i < 5; i++)
    {
        cout << vetor[i] << " ";
    }


    // Exibe o maior valor encontrado
    cout << "\nMaior valor: " << maiorValor << endl;
    cout << "Posição do maior valor: " << posMaior << endl;


}