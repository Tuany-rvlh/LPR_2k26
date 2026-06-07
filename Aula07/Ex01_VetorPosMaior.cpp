#include <iostream> // Biblioteca para entrada e saída de dados
#include <vector>   // Biblioteca para utilizar vetores dinâmicos

using namespace std;

int main() {

    // Cria um vetor de inteiros com 5 posições
    vector<int> vetor(5);

    // Laço para preencher o vetor com valores digitados pelo usuário
    for (int i = 0; i < 5; i++) {
        cout << "Digite o valor da posicao " << i << ": ";
        cin >> vetor[i];
    }

    // Assume inicialmente que o maior valor está na posição 0
    int posMaior = 0;
    int maiorValor = vetor[0];

    // Percorre o vetor a partir da segunda posição para encontrar o maior valor e sua posição
    for (int i = 1; i < vetor.size(); i++) {
        if (vetor[i] > maiorValor) {
            maiorValor = vetor[i]; // Atualiza o maior valor
            posMaior = i;          // Atualiza a posição do maior valor
        }
    }

    // Exibe a posição onde está o maior valor
    cout << "\nPosicao do maior valor: " << posMaior << endl;

    // Exibe o maior valor encontrado
    cout << "Maior valor: " << maiorValor << endl;
}