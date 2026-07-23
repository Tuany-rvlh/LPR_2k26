/*
 * Enunciado:
 * Construa um dicionário de X pares chave-valor,
 * onde as chaves são nomes de cidades e os valores
 * são suas respectivas populações.
 *
 * O programa deve:
 * - Encontrar cidades com população acima da média;
 * - Mostrar a cidade mais populosa e menos populosa;
 * - Remover cidades com uma população informada pelo usuário;
 * - Exibir o dicionário atualizado.
 */

#include <iostream>
#include <map>
#include <vector>
#include <string>

using namespace std;

// Calcula a média das populações
double calcularMedia(map<string, int> cidades)
{
    int soma = 0;

    for (auto cidade : cidades)
    {
        soma += cidade.second;
    }

    return (double)soma / cidades.size();
}

// Mostra cidades acima da média
void mostrarAcimaMedia(map<string, int> cidades)
{
    double media = calcularMedia(cidades);

    cout << "\nCidades acima da media:" << endl;

    for (auto cidade : cidades)
    {
        if (cidade.second > media)
        {
            cout << cidade.first << " - "
                 << cidade.second << " habitantes" << endl;
        }
    }
}

// Mostra cidade mais e menos populosa
void mostrarMaiorMenor(map<string, int> cidades)
{
    string maiorCidade;
    string menorCidade;

    int maiorPopulacao = -1;
    int menorPopulacao = 999999999;

    for (auto cidade : cidades)
    {
        if (cidade.second > maiorPopulacao)
        {
            maiorPopulacao = cidade.second;
            maiorCidade = cidade.first;
        }

        if (cidade.second < menorPopulacao)
        {
            menorPopulacao = cidade.second;
            menorCidade = cidade.first;
        }
    }

    cout << "\nCidade mais populosa:" << endl;
    cout << maiorCidade << " - "
         << maiorPopulacao << " habitantes" << endl;

    cout << "\nCidade menos populosa:" << endl;
    cout << menorCidade << " - "
         << menorPopulacao << " habitantes" << endl;
}

// Remove cidades com determinada população
void removerPopulacao(map<string, int>& cidades, int valor)
{
    vector<string> remover;

    // Guarda as cidades que serão removidas
    for (auto cidade : cidades)
    {
        if (cidade.second == valor)
        {
            remover.push_back(cidade.first);
        }
    }

    // Remove as cidades encontradas
    for (string nome : remover)
    {
        cidades.erase(nome);
    }
}

// Exibe o dicionário completo
void exibirCidades(map<string, int> cidades)
{
    cout << "\nDicionario atualizado:" << endl;

    for (auto cidade : cidades)
    {
        cout << cidade.first << " - "
             << cidade.second << " habitantes" << endl;
    }
}

int main()
{
    map<string, int> cidades;

    int quantidade;

    cout << "Digite a quantidade de cidades: ";
    cin >> quantidade;

    // Cadastro das cidades
    for (int i = 0; i < quantidade; i++)
    {
        string nome;
        int populacao;

        cout << "\nNome da cidade: ";
        cin >> nome;

        cout << "Populacao: ";
        cin >> populacao;

        cidades[nome] = populacao;
    }

    mostrarAcimaMedia(cidades);

    mostrarMaiorMenor(cidades);

    int valor;

    cout << "\nDigite uma populacao para remover: ";
    cin >> valor;

    removerPopulacao(cidades, valor);

    exibirCidades(cidades);
}