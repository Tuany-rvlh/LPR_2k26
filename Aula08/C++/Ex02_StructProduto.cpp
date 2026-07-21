/*
 * Enunciado:
 *
 * Defina uma struct chamada Produto contendo os seguintes campos:
 * Nome, Codigo, Preco e Quantidade.
 *
 * Desenvolva um programa que permita ao usuário cadastrar
 * os dados de 3 produtos utilizando a struct criada.
 *
 * Ao final, o programa deverá calcular e exibir o valor total
 * em estoque, considerando o preço e a quantidade de cada produto.
 *
 * Fórmula:
 * Valor total em estoque = Preço × Quantidade
 */


#include <iostream>
#include <string>
#include <clocale>

using namespace std;


// Struct criada para armazenar os dados do produto
struct Produto
{
    string Nome;
    string Codigo;
    float Preco;
    float Quantidade;
};


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");


    // Vetor de structs para armazenar 3 produtos
    Produto produtos[3];

    float valorTotal = 0;


    // Cadastro dos produtos
    for (int i = 0; i < 3; i++)
    {
        cout << "\nCadastro do produto " << i + 1 << endl;


        cout << "Digite o nome do produto: ";
        getline(cin, produtos[i].Nome);


        cout << "Digite o código do produto: ";
        getline(cin, produtos[i].Codigo);


        cout << "Digite o preço do produto: ";
        cin >> produtos[i].Preco;


        cout << "Digite a quantidade do produto: ";
        cin >> produtos[i].Quantidade;


        // Soma o valor do produto no estoque
        valorTotal += produtos[i].Preco * produtos[i].Quantidade;


        cin.ignore(); // Limpa o Enter antes do próximo getline
    }


    cout << "\nO valor total em estoque é: "
         << valorTotal << " reais." << endl;


    return 0;
}