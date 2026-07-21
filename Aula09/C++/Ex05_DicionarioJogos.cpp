/*
 * Enunciado:
 *
 * Crie um programa que utilize um dicionário para armazenar jogos
 * e seus respectivos gêneros.
 *
 * O programa deverá:
 * - Cadastrar pelo menos 5 jogos informados pelo usuário;
 * - Armazenar o nome do jogo e seu gênero em um dicionário;
 * - Solicitar o nome de um jogo e exibir seu gênero;
 * - Caso o jogo não esteja cadastrado, informar que ele não foi encontrado.
 */


#include <iostream> // Biblioteca para entrada e saída
#include <map>      // Biblioteca para utilizar dicionários
#include <string>   // Biblioteca para utilizar strings
#include <clocale>  // Biblioteca para setlocale

using namespace std;


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    // Dicionário para armazenar jogo e gênero
    map<string, string> jogos;

    string chave;
    string procura;

    // Cadastro dos jogos
    for (int i = 0; i < 5; i++)
    {
        cout << "Digite o nome do jogo: ";
        getline(cin, chave);

        cout << "Digite o gênero desse jogo: ";
        getline(cin, jogos[chave]);

        cout << endl;
    }

    // Busca de um jogo cadastrado
    cout << "Digite o nome de um dos jogos cadastrados: ";
    getline(cin, procura);

    // Verifica se o jogo existe no dicionário
    if (jogos.find(procura) != jogos.end())
    {
        cout << "O gênero do seu jogo é: "
             << jogos[procura] << endl;
    }
    else
    {
        cout << "Não foi possível encontrar o jogo informado." << endl;
    }

}