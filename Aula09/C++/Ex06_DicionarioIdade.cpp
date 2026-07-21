/*
 * Enunciado:
 *
 * Construa um dicionário de X pares chave-valor onde as chaves são
 * nomes de pessoas e os valores são suas respectivas idades.
 *
 * O programa deverá:
 * - Encontrar e imprimir todas as pessoas com idade acima da média;
 * - Encontrar e imprimir a pessoa mais velha e a pessoa mais nova;
 * - Remover todas as pessoas com idade igual a um valor Y informado pelo usuário;
 * - Exibir o dicionário atualizado.
 */


#include <iostream> // Biblioteca para entrada e saída
#include <map>      // Biblioteca para utilizar dicionários
#include <string>   // Biblioteca para utilizar strings
#include <clocale>  // Biblioteca para setlocale

using namespace std;



int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Dicionário para armazenar nome e idade
    map<string, int> pessoasIdade;


    int pares;
    float soma = 0;


    cout << "Digite o número de pessoas cadastradas: ";
    cin >> pares;

    cin.ignore();



    // Cadastro das pessoas
    for (int i = 0; i < pares; i++)
    {
        string nome;
        int idade;


        cout << "\nDigite o nome da pessoa: ";
        getline(cin, nome);


        cout << "Digite a idade da pessoa: ";
        cin >> idade;

        cin.ignore();


        pessoasIdade[nome] = idade;
    }



    // Calcula a soma das idades
    for (auto pessoa : pessoasIdade)
    {
        soma += pessoa.second;
    }


    float media = soma / pessoasIdade.size();



    cout << "\nMédia das idades: " << media << endl;



    // Pessoas acima da média
    cout << "\nPessoas acima da média:" << endl;


    for (auto pessoa : pessoasIdade)
    {
        if (pessoa.second > media)
        {
            cout << pessoa.first << " - "
                 << pessoa.second << " anos" << endl;
        }
    }



    // Descobrir pessoa mais velha e mais nova
    string maisVelha;
    string maisNova;

    int maiorIdade = -1;
    int menorIdade = 999;


    for (auto pessoa : pessoasIdade)
    {
        if (pessoa.second > maiorIdade)
        {
            maiorIdade = pessoa.second;
            maisVelha = pessoa.first;
        }


        if (pessoa.second < menorIdade)
        {
            menorIdade = pessoa.second;
            maisNova = pessoa.first;
        }
    }

    cout << "\nPessoa mais velha: " << maisVelha << " - " << maiorIdade << " anos" << endl;


    cout << "Pessoa mais nova: " << maisNova << " - "  << menorIdade << " anos" << endl;

    // Remover pessoas com idade escolhida
    int idadeRemover;

    cout << "\nDigite uma idade para remover: ";
    cin >> idadeRemover;

    for (auto it = pessoasIdade.begin(); it != pessoasIdade.end(); )
    {
        if (it->second == idadeRemover)
        {
            it = pessoasIdade.erase(it);
        }
        else
        {
            it++;
        }
    }

    // Exibir dicionário atualizado
    cout << "\nDicionário atualizado:" << endl;

    for (auto pessoa : pessoasIdade)
    {
        cout << pessoa.first << " - " << pessoa.second << " anos" << endl;
    }

}