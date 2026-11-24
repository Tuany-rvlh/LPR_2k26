
using System;

class Produto
{
    public string nome;
    public double preco;

    public Produto(string nome, double preco)
    {
        this.nome = nome;
        this.preco = preco;
    }
}

class Pedido
{
    public Produto produto;
    public int quantidade;

    public Pedido(Produto produto, int quantidade)
    {
        this.produto = produto;
        this.quantidade = quantidade;
    }

    public double CalcularTotal()
    {
        return produto.preco * quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Mouse", 50);

        Pedido pedido = new Pedido(produto, 3);

        Console.WriteLine("Produto: " + pedido.produto.nome);
        Console.WriteLine("Quantidade: " + pedido.quantidade);
        Console.WriteLine("Preco total: " + pedido.CalcularTotal());
    }
}
