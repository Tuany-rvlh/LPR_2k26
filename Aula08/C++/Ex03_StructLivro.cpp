/*
 * Enunciado:
 *
 * Defina uma struct chamada Livro contendo os seguintes campos:
 * Titulo, Autor, AnoPublicacao, NumeroPaginas e Preco.
 *
 * Desenvolva um programa que permita ao usuário cadastrar
 * os dados de 3 livros utilizando a struct criada.
 *
 * Ao final, o programa deverá calcular e exibir:
 * - O preço total dos livros cadastrados;
 * - A média de páginas dos livros.
 */


#include <iostream> // Biblioteca para entrada e saída de dados
#include <string>   // Biblioteca para utilizar string
#include <clocale>  // Biblioteca para setlocale

using namespace std;


// Struct criada para armazenar os dados do livro
struct Livro
{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Vetor de structs para armazenar 3 livros
    Livro livros[3];

    double precoTotal = 0;
    int totalPaginas = 0;


    // Cadastro dos livros
    for (int i = 0; i < 3; i++)
    {
        cout << "\nCadastro do livro " << i + 1 << endl;


        cout << "Digite o título do livro: ";
        getline(cin, livros[i].Titulo);


        cout << "Digite o autor do livro: ";
        getline(cin, livros[i].Autor);


        cout << "Digite o ano de publicação do livro: ";
        cin >> livros[i].AnoPublicacao;


        cout << "Digite o número de páginas do livro: ";
        cin >> livros[i].NumeroPaginas;


        cout << "Digite o preço do livro: ";
        cin >> livros[i].Preco;


        // Limpa o buffer para o próximo getline
        cin.ignore();


        // Soma os valores cadastrados
        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;


        cout << endl;
    }


    // Calcula a média de páginas dos livros
    double mediaPaginas = totalPaginas / 3.0;


    // Exibe os resultados
    cout << "\n===== RESULTADO =====" << endl;
    cout << "Preço total dos livros: R$ " << precoTotal << endl;
    cout << "Média de páginas por livro: " << mediaPaginas << endl;


    return 0;
}