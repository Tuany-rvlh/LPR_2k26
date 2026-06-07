#include <iostream>
#include <locale.h>
using namespace std;

int main() {

    setlocale(LC_ALL, "pt_BR.UTF-8");

    int matriz[4][4] = {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };

    string cidades[4] = {
        "Vitoria",
        "Belo Horizonte",
        "Rio de Janeiro",
        "Sao Paulo"
    };

    int origem, destino;

    while (origem != destino) {

        cout << "\n0 - Vitoria\n1 - Belo Horizonte\n2 - Rio de Janeiro\n3 - Sao Paulo\n";

        cout << "Digite a cidade de origem: ";
        cin >> origem;

        cout << "Digite a cidade de destino: ";
        cin >> destino;

        if (origem < 0 || origem > 3 || destino < 0 || destino > 3) {
            cout << "Cidade inválida. Tente novamente." << endl;
        } else {
            cout << "Distancia: " << matriz[origem][destino] << " km" << endl;
        }
    }

    cout << "Programa encerrado." << endl;

}