#include <iostream>
#include <string>
#include <locale>
using namespace std;

class Funcionario
{
public:
    string nome;
    double salarioBruto;
    double salarioLiquido;
    double porcentagem;

    Funcionario(string Nome, double SalarioBruto, double Porcentagem)
    {
        nome = Nome;
        salarioBruto = SalarioBruto;
        porcentagem = Porcentagem;
    }

    void MostrarDados()
    {
        cout << "Nome: " << nome << endl;

        if (salarioBruto <= 2000)
        {
            salarioLiquido = salarioBruto - (salarioBruto * 0.10);
        }
        else if (salarioBruto <= 3000)
        {
            salarioLiquido = salarioBruto - (salarioBruto * 0.15);
        }
        else
        {
            salarioLiquido = salarioBruto - (salarioBruto * 0.20);
        }

        cout << "Salario Liquido: " << salarioLiquido << endl;
    }

    void AumentarSalario()
    {
        double aumento = salarioBruto * (porcentagem / 100);
        salarioBruto += aumento;

        cout << "Salario apos aumento: " << salarioBruto << endl;
    }
};

int main()
{
    setlocale(LC_ALL, "Portuguese");

    string nomefunc;
    double salariobruto, porcentagem;

    cout << "Digite o nome do funcionario: ";
    getline(cin, nomefunc);

    cout << "Digite o salario bruto do funcionario: ";
    cin >> salariobruto;

    cout << "Digite a porcentagem de aumento: ";
    cin >> porcentagem;

    Funcionario funcionario(nomefunc, salariobruto, porcentagem);

    funcionario.MostrarDados();
    funcionario.AumentarSalario();

}