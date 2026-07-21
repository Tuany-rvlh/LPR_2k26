/*
 * Enunciado:
 * Desenvolva um programa que utilize uma matriz para armazenar
 * as distâncias entre quatro cidades.
 *
 * O usuário deve informar uma cidade de origem e uma cidade de destino.
 * Ao final, o programa deve mostrar a distância entre elas.
 */


// Bibliotecas utilizadas
#include <iostream>
#include <clocale>
#include <string>

using namespace std;


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Matriz contendo as distâncias entre as cidades
    int matriz[4][4] =
    {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };


    // Vetor contendo os nomes das cidades
    string cidades[4] =
    {
        "Vitória",
        "Belo Horizonte",
        "Rio de Janeiro",
        "São Paulo"
    };


    int origem;
    int destino;


    do
    {
        // Exibe as opções de cidades
        cout << "\n===== CIDADES =====" << endl;

        for(int i = 0; i < 4; i++)
        {
            cout << i << " - " << cidades[i] << endl;
        }


        cout << "\nDigite a cidade de origem: ";
        cin >> origem;


        cout << "Digite a cidade de destino: ";
        cin >> destino;


        // Verifica se as posições digitadas existem
        if(origem < 0 || origem > 3 || destino < 0 || destino > 3)
        {
            cout << "Cidade inválida! Tente novamente." << endl;
        }
        else if(origem == destino)
        {
            cout << "Origem e destino são iguais. Programa encerrado." << endl;
        }
        else
        {
            cout << "Distância entre "
                 << cidades[origem]
                 << " e "
                 << cidades[destino]
                 << ": "
                 << matriz[origem][destino]
                 << " km" << endl;
        }

    } while(origem != destino);
}