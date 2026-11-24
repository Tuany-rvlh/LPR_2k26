
#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Livro
{
private:
    string titulo;
    string autor;
    int ano;

public:
    Livro(string titulo, string autor, int ano)
    {
        this->titulo = titulo;
        this->autor = autor;
        this->ano = ano;
    }

    string GetTitulo()
    {
        return titulo;
    }

    string GetAutor()
    {
        return autor;
    }

    int GetAno()
    {
        return ano;
    }

    void SetTitulo(string titulo)
    {
        this->titulo = titulo;
    }

    void SetAutor(string autor)
    {
        this->autor = autor;
    }

    void SetAno(int ano)
    {
        this->ano = ano;
    }
};

class Biblioteca
{
public:
    vector<Livro> livros;

    Biblioteca()
    {
        livros = vector<Livro>();
    }

    void AdicionarLivro(Livro livro)
    {
        livros.push_back(livro);
    }

    void ListarLivros()
    {
        cout << "Livros da biblioteca:" << endl;

        for (int i = 0; i < livros.size(); i++)
        {
            cout << "Titulo: " << livros[i].GetTitulo() << endl;
            cout << "Autor: " << livros[i].GetAutor() << endl;
            cout << "Ano: " << livros[i].GetAno() << endl;
            cout << endl;
        }
    }
};

int main()
{
    Biblioteca biblioteca;

    Livro livro1("Dom Casmurro", "Machado de Assis", 1899);
    Livro livro2("O Quinze", "Rachel de Queiroz", 1930);

    biblioteca.AdicionarLivro(livro1);
    biblioteca.AdicionarLivro(livro2);

    biblioteca.ListarLivros();
}
