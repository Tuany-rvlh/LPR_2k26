#include <iostream>
#include <string>
#include <locale>
using namespace std;

class Aluno
{
public:
    int matricula;
    string nome;
    double nota1;
    double nota2;
    double notaTrabalho;

    Aluno(int Matricula, string Nome, double Nota1, double Nota2, double NotaTrabalho)
    {
        matricula = Matricula;
        nome = Nome;
        nota1 = Nota1;
        nota2 = Nota2;
        notaTrabalho = NotaTrabalho;
    }

    double Media()
    {
        double media = ((nota1 * 2.5) + (nota2 * 2.5) + (notaTrabalho * 2)) / 7;

        return media;
    }

    double Final()
    {
        double media = Media();
        double notaFinal;

        if (media < 60)
        {
            notaFinal = 120 - media;
        }
        else
        {
            notaFinal = 0;
        }

        return notaFinal;
    }

    void MostrarDados()
    {
        cout << "Matricula: " << matricula << endl;
        cout << "Nome: " << nome << endl;
        cout << "Media: " << Media() << endl;

        if (Final() > 0)
        {
            cout << "Precisa tirar " << Final() << " na prova final." << endl;
        }
        else
        {
            cout << "Aluno aprovado! Nao precisa de prova final." << endl;
        }
    }
};

int main()
{
    setlocale(LC_ALL, "Portuguese");

    int matricula;
    string nome;
    double nota1, nota2, notaTrabalho;

    cout << "Digite a matricula: ";
    cin >> matricula;

    cin.ignore();

    cout << "Digite o nome: ";
    getline(cin, nome);

    cout << "Digite a primeira nota: ";
    cin >> nota1;

    cout << "Digite a segunda nota: ";
    cin >> nota2;

    cout << "Digite a nota do trabalho: ";
    cin >> notaTrabalho;

    Aluno aluno(matricula, nome, nota1, nota2, notaTrabalho);

    aluno.MostrarDados();
}