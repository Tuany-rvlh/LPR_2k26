/*
 * Enunciado:
 *
 * Defina uma struct chamada Filme contendo os seguintes campos:
 * Titulo, Diretor, AnoLancamento e DuracaoMinutos.
 *
 * Desenvolva um programa que solicite os dados de 3 filmes
 * ao usuário e armazene as informações em um vetor de structs.
 *
 * Ao final, o programa deverá:
 * - Exibir todos os filmes cadastrados;
 * - Informar qual é o filme mais antigo, considerando o menor
 *   ano de lançamento.
 */


#include <iostream>
#include <string>
#include <clocale>

using namespace std;


// Struct criada para armazenar os dados do filme
struct Filme
{
    string Titulo;
    string Diretor;
    int AnoLancamento;
    int DuracaoMinutos;
};


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");


    // Vetor de structs para armazenar 3 filmes
    Filme filmes[3];


    // Cadastro dos filmes
    for (int i = 0; i < 3; i++)
    {
        cout << "\nCadastro do filme " << i + 1 << endl;


        cout << "Digite o título do filme: ";
        getline(cin, filmes[i].Titulo);


        cout << "Digite o diretor do filme: ";
        getline(cin, filmes[i].Diretor);


        cout << "Digite o ano de lançamento do filme: ";
        cin >> filmes[i].AnoLancamento;


        cout << "Digite a duração em minutos do filme: ";
        cin >> filmes[i].DuracaoMinutos;


        cin.ignore(); // limpa o Enter antes do próximo getline

        cout << endl;
    }


    // Exibição dos filmes cadastrados
    cout << "\n===== FILMES CADASTRADOS =====" << endl;

    for (int i = 0; i < 3; i++)
    {
        cout << "\nFilme " << i + 1 << ":" << endl;
        cout << "Título: " << filmes[i].Titulo << endl;
        cout << "Diretor: " << filmes[i].Diretor << endl;
        cout << "Ano de lançamento: " << filmes[i].AnoLancamento << endl;
        cout << "Duração: " << filmes[i].DuracaoMinutos << " minutos" << endl;
    }


    // Encontrar o filme mais antigo
    int indiceMaisAntigo = 0;

    for (int i = 1; i < 3; i++)
    {
        if (filmes[i].AnoLancamento < filmes[indiceMaisAntigo].AnoLancamento)
        {
            indiceMaisAntigo = i;
        }
    }


    // Exibir o filme mais antigo
    cout << "\n===== FILME MAIS ANTIGO =====" << endl;
    cout << "Título: " << filmes[indiceMaisAntigo].Titulo << endl;
    cout << "Ano de lançamento: " << filmes[indiceMaisAntigo].AnoLancamento << endl;

}