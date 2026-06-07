//biblioteca para manipulação de vetores e algoritmos de busca
#include <iostream>
#include <locale.h>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    vector<int> numeros(10); // Cria um vetor de inteiros com 10 posições
    int numProcurado; // Variável para armazenar o número que o usuário deseja buscar

    for (int i = 0; i < 10; i++) // for para preencher o vetor
    {
        cout << "Insira o número " << i + 1 << ": ";
        cin >> numeros[i];
    }

    cout << "Digite o número que deseja buscar no array: "; // Solicita o número a ser procurado
    cin >> numProcurado;

    // Utiliza a função find para procurar o número no vetor
    auto resultado = find(numeros.begin(), numeros.end(), numProcurado); 

    if (resultado != numeros.end()) // Verifica se o número foi encontrado
    {
        int posicao = resultado - numeros.begin();

        cout << "Número encontrado na posição " << posicao << endl; // Exibe a posição do número encontrado
    }
    else
    {
        cout << "Número não encontrado!" << endl;
    }
}