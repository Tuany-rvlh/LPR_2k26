/*
 * Exercício 8:
 *
 * Crie uma struct chamada Livro contendo:
 * - Título
 * - Autor
 * - Ano de publicação
 * - Quantidade disponível
 *
 * Utilize um dicionário onde:
 * Chave: Código do livro
 * Valor: Struct Livro
 *
 * Funções:
 * 1. CadastrarLivro()
 * 2. BuscarLivro()
 * 3. EmprestarLivro()
 * 4. ExibirRelatorio()
 */

#include <iostream>
#include <map>
#include <string>

using namespace std;


// Struct com as características do livro
struct Livro
{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int QuantidadeDisponivel;
};


// Função para exibir o menu principal
void MenuPrincipal()
{
    cout << "========== Sistema de Biblioteca ==========" << endl;
    cout << "1. Cadastrar Livro" << endl;
    cout << "2. Buscar Livro" << endl;
    cout << "3. Emprestar Livro" << endl;
    cout << "4. Exibir Relatorio" << endl;
    cout << "5. Sair" << endl;
    cout << "===========================================" << endl;
    cout << endl;
}

// Função para cadastrar livros
void CadastrarLivro(map<int, Livro>& biblioteca)
{
    // Verifica limite de livros
    if (biblioteca.size() >= 10)
    {
        cout << "Limite de livros cadastrados atingido." << endl;
        return;
    }

    int codigo;

    cout << "Digite o codigo do livro: ";
    cin >> codigo;

    // Verifica se o código já existe
    if (biblioteca.count(codigo))
    {
        cout << "Codigo ja cadastrado." << endl;
        return;
    }

    Livro livro;
    cin.ignore();

    cout << "Digite o titulo: ";
    getline(cin, livro.Titulo);

    cout << "Digite o autor: ";
    getline(cin, livro.Autor);

    cout << "Digite o ano de publicacao: ";
    cin >> livro.AnoPublicacao;

    cout << "Digite a quantidade disponivel: ";
    cin >> livro.QuantidadeDisponivel;

    biblioteca[codigo] = livro;

    cout << "Livro cadastrado com sucesso!" << endl;
    cout << endl;
}

// Função para buscar livro pelo código
void BuscarLivro(map<int, Livro>& biblioteca)
{
    int codigo;

    cout << "Digite o codigo do livro: ";
    cin >> codigo;

    if (biblioteca.count(codigo))
    {
        Livro livro = biblioteca[codigo];

        cout << endl;
        cout << "===== Livro Encontrado =====" << endl;
        cout << "Titulo: " << livro.Titulo << endl;
        cout << "Autor: " << livro.Autor << endl;
        cout << "Ano: " << livro.AnoPublicacao << endl;
        cout << "Quantidade disponivel: "
             << livro.QuantidadeDisponivel << endl;
    }
    else
    {
        cout << "Livro nao encontrado." << endl;
    }
    cout << endl;
}

// Função para realizar empréstimo
void EmprestarLivro(map<int, Livro>& biblioteca)
{
    int codigo;

    cout << "Digite o codigo do livro: ";
    cin >> codigo;

    if (biblioteca.count(codigo))
    {
        Livro& livro = biblioteca[codigo];


        if (livro.QuantidadeDisponivel > 0)
        {
            livro.QuantidadeDisponivel--;

            cout << "Emprestimo realizado com sucesso!" << endl;
        }
        else
        {
            cout << "Nao existem exemplares disponiveis." << endl;
        }
    }
    else
    {
        cout << "Livro nao encontrado." << endl;
    }

    cout << endl;
}


// Função para exibir relatório
void ExibirRelatorio(map<int, Livro>& biblioteca)
{
    if (biblioteca.empty())
    {
        cout << "Nenhum livro cadastrado." << endl;
        return;
    }


    Livro livroMaisAntigo;
    Livro livroMaiorQuantidade;

    bool primeiro = true;

    // Dicionário para armazenar quantidade de livros por autor
    map<string, int> quantidadeAutores;


    for (auto item : biblioteca)
    {
        Livro livro = item.second;

        // Inicializa os valores de comparação
        if (primeiro)
        {
            livroMaisAntigo = livro;
            livroMaiorQuantidade = livro;
            primeiro = false;
        }

        // Verifica livro mais antigo
        if (livro.AnoPublicacao < livroMaisAntigo.AnoPublicacao)
        {
            livroMaisAntigo = livro;
        }

        // Verifica maior quantidade disponível
        if (livro.QuantidadeDisponivel >
            livroMaiorQuantidade.QuantidadeDisponivel)
        {
            livroMaiorQuantidade = livro;
        }

        // Conta livros por autor
        quantidadeAutores[livro.Autor]++;
    }

    cout << "============== Relatorio ==============" << endl;
    cout << "Total de livros cadastrados: "<< biblioteca.size() << endl;

    cout << endl;

    cout << "Livro mais antigo:" << endl;
    cout << "Titulo: " << livroMaisAntigo.Titulo << endl;
    cout << "Ano: " << livroMaisAntigo.AnoPublicacao << endl;

    cout << endl;

    cout << "Livro com maior quantidade disponivel:" << endl;
    cout << "Titulo: " << livroMaiorQuantidade.Titulo << endl;
    cout << "Quantidade: " << livroMaiorQuantidade.QuantidadeDisponivel << endl;

    cout << endl;

    cout << "Quantidade de livros por autor:" << endl;


    for (auto autor : quantidadeAutores)
    {
        cout << autor.first << ": "
             << autor.second
             << " livro(s)" << endl;
    }


    cout << "=======================================" << endl;
    cout << endl;
}

int main()
{
    // Map utilizado como dicionário
    // Chave: Código do livro
    // Valor: Struct Livro
    map<int, Livro> biblioteca;


    int opcao;



    do
    {
        // Exibe menu
        MenuPrincipal();


        cout << "Digite a opcao desejada: ";
        cin >> opcao;



        switch(opcao)
        {
            case 1:
                CadastrarLivro(biblioteca);
                break;

            case 2:
                BuscarLivro(biblioteca);
                break;

            case 3:
                EmprestarLivro(biblioteca);
                break;

            case 4:
                ExibirRelatorio(biblioteca);
                break;

            case 5:
                cout << "Encerrando o programa..." << endl;
                break;

            default:
                cout << "Opcao invalida." << endl;
                break;
        }

    } while(opcao != 5);

}