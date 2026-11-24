
#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Aluno;
class Turma;

class Matricula
{
public:
    Aluno* aluno;
    Turma* turma;
    string data;

    Matricula(Aluno* aluno, Turma* turma, string data)
    {
        this->aluno = aluno;
        this->turma = turma;
        this->data = data;
    }
};

class Aluno
{
public:
    string nome;
    vector<Matricula> matriculas;

    Aluno(string nome)
    {
        this->nome = nome;
    }

    void AdicionarMatricula(Matricula matricula)
    {
        matriculas.push_back(matricula);
    }

    void Matricular(Turma* turma, string data);
};

class Turma
{
public:
    string nome;
    vector<Matricula> matriculas;

    Turma(string nome)
    {
        this->nome = nome;
    }

    void AdicionarMatricula(Matricula matricula)
    {
        matriculas.push_back(matricula);
    }

    void ListarAlunos()
    {
        cout << "Alunos da turma " << nome << ":" << endl;

        for (int i = 0; i < matriculas.size(); i++)
        {
            cout << matriculas[i].aluno->nome << endl;
        }
    }
};

void Aluno::Matricular(Turma* turma, string data)
{
    for (int i = 0; i < matriculas.size(); i++)
    {
        if (matriculas[i].turma == turma)
        {
            cout << "Aluno ja matriculado nessa turma." << endl;
            return;
        }
    }

    Matricula matricula(this, turma, data);

    AdicionarMatricula(matricula);
    turma->AdicionarMatricula(matricula);

    cout << "Matricula realizada com sucesso!" << endl;
}

int main()
{
    Aluno aluno1("Tuany");
    Aluno aluno2("Maria");

    Turma turma1("Desenvolvimento de Sistemas");
    Turma turma2("Eletronica");

    aluno1.Matricular(&turma1, "23/11/2026");
    aluno1.Matricular(&turma2, "23/11/2026");
    aluno2.Matricular(&turma1, "23/11/2026");

    aluno1.Matricular(&turma1, "24/11/2026");

    cout << endl;

    turma1.ListarAlunos();
}
