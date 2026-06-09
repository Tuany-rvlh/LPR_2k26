#include <iostream>
#include <locale.h>

// declarar matriz
int matriz[3][3];

// armazenar a soma dos elementos da matriz
int soma = 0;

using namespace std;

main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português  

    //percorrer e preencher a matriz
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << "Digite o valor para a posição [" << i << "][" << j << "]: ";
            cin >> matriz[i][j];
            soma += matriz[i][j]; // acumula a soma dos elementos da matriz
        }
    }
    
    //for para mostrar a matriz
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << matriz[i][j] << " ";
        }
        cout << endl; // <- quebra a linha aqui
    }

    // mostrar a soma dos elementos da matriz
    cout << "A soma dos elementos da matriz é: " << soma << endl;
}

