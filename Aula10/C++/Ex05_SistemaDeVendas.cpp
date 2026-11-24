
#include <iostream>
#include <string>
using namespace std;

class Produto
{
public:
    string nome;
    double preco;

    Produto(string nome, double preco)
    {
        this->nome = nome;
        this->preco = preco;
    }
};

class Pedido
{
public:
    Produto produto;
    int quantidade;

    Pedido(Produto produto, int quantidade) : produto(produto)
    {
        this->quantidade = quantidade;
    }

    double CalcularTotal()
    {
        return produto.preco * quantidade;
    }
};

int main()
{
    Produto produto("Mouse", 50);

    Pedido pedido(produto, 3);

    cout << "Produto: " << pedido.produto.nome << endl;
    cout << "Quantidade: " << pedido.quantidade << endl;
    cout << "Preco total: " << pedido.CalcularTotal() << endl;
}
