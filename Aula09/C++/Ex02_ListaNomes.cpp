/*
 * Exercício 2:
 * Construa uma lista de X nomes aleatórios.
 *
 * A saída deve mostrar os nomes ordenados pelo tamanho,
 * começando pelos menores. Quando existirem nomes com
 * o mesmo tamanho, apenas um deles aparece em cada linha,
 * mantendo a ordem em que foram digitados.
 */

#include <iostream>
#include <vector>
#include <string>

using namespace std;

int main()
{
    int quantidade;

    // Lê a quantidade de nomes que serão cadastrados
    cin >> quantidade;

    vector<string> nomes(quantidade);

    // Guarda os nomes digitados pelo usuário
    for (int i = 0; i < quantidade; i++)
    {
        cin >> nomes[i];
    }

    // Ordena os nomes pelo tamanho
    // Caso tenham o mesmo tamanho, mantém a ordem original
    for (int i = 0; i < quantidade - 1; i++)
    {
        for (int j = i + 1; j < quantidade; j++)
        {
            if (nomes[i].size() > nomes[j].size())
            {
                string auxiliar = nomes[i];
                nomes[i] = nomes[j];
                nomes[j] = auxiliar;
            }
        }
    }

    vector<bool> usado(quantidade, false);

    int exibidos = 0;

    // Continua mostrando linhas até todos os nomes aparecerem
    while (exibidos < quantidade)
    {
        int ultimoTamanho = -1;
        bool primeiro = true;

        // Procura o menor nome disponível para começar a linha
        for (int i = 0; i < quantidade; i++)
        {
            if (!usado[i])
            {
                ultimoTamanho = nomes[i].size();
                break;
            }
        }

        // Mostra um nome de cada tamanho na linha atual
        for (int i = 0; i < quantidade; i++)
        {
            if (!usado[i] && nomes[i].size() >= ultimoTamanho)
            {
                if (!primeiro)
                {
                    cout << ", ";
                }

                cout << nomes[i];

                usado[i] = true;
                exibidos++;

                ultimoTamanho = nomes[i].size();
                primeiro = false;
            }
        }

        cout << endl;
    }
}