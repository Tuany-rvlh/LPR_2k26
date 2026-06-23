#include <iostream> // biblioteca do sistema
#include <clocale> // setlocale

using namespace std; //não será precio mais o uso do std em todas as linhas de código

//struct para o produto criado
struct produto{
    string Nome;
    string Codigo;
    float Preco;
    float Quantidade;
};

main(){
    
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    produto P1;
    cout << "Digite o nome do produto: ";
    cin >> P1.Nome;
    cout << "Digite o código do produto: ";
    cin >> P1.Codigo;
    cout << "Digite o preço do produto: ";
    cin >> P1.Preco;
    cout << "Digite a quantidade de produto: ";
    cin >> P1.Quantidade;
    cout << " " << endl;
    cin.ignore();
    
    produto P2;
    cout << "Digite o nome do produto: ";
    cin >> P2.Nome;
    cout << "Digite o código do produto: ";
    cin >> P2.Codigo;
    cout << "Digite o preço do produto: ";
    cin >> P2.Preco;
    cout << "Digite a quantidade de produto: ";
    cin >> P2.Quantidade;
    cout << " " << endl;
    cin.ignore();

    produto P3;
    cout << "Digite o nome do produto: ";
    cin >> P3.Nome;
    cout << "Digite o código do produto: ";
    cin >> P3.Codigo;
    cout << "Digite o preço do produto: ";
    cin >> P3.Preco;
    cout << "Digite a quantidade de produto: ";
    cin >> P3.Quantidade;
    cout << " " << endl;
    cin.ignore();

    float valor = (P1.Preco * P1.Quantidade) + (P2.Preco * P2.Quantidade) + (P3.Preco * P3.Quantidade);

    cout << "O valor total em estoque é " << valor << " reais. " << endl;

}