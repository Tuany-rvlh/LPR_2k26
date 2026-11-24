
using System;
using System.Collections.Generic;

class Livro
{
    private string titulo;
    private string autor;
    private int ano;

    public Livro(string titulo, string autor, int ano)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.ano = ano;
    }

    public string GetTitulo()
    {
        return titulo;
    }

    public string GetAutor()
    {
        return autor;
    }

    public int GetAno()
    {
        return ano;
    }

    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void SetAutor(string autor)
    {
        this.autor = autor;
    }

    public void SetAno(int ano)
    {
        this.ano = ano;
    }
}

class Biblioteca
{
    public List<Livro> livros;

    public Biblioteca()
    {
        livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void ListarLivros()
    {
        Console.WriteLine("Livros da biblioteca:");

        for (int i = 0; i < livros.Count; i++)
        {
            Console.WriteLine("Titulo: " + livros[i].GetTitulo());
            Console.WriteLine("Autor: " + livros[i].GetAutor());
            Console.WriteLine("Ano: " + livros[i].GetAno());
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis", 1899);
        Livro livro2 = new Livro("O Quinze", "Rachel de Queiroz", 1930);

        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);

        biblioteca.ListarLivros();
    }
}
