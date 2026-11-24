
using System;
using System.Collections.Generic;

class Aluno
{
    public string nome;
    public List<Matricula> matriculas;

    public Aluno(string nome)
    {
        this.nome = nome;
        matriculas = new List<Matricula>();
    }

    public void AdicionarMatricula(Matricula matricula)
    {
        matriculas.Add(matricula);
    }

    public void Matricular(Turma turma, string data)
    {
        for (int i = 0; i < matriculas.Count; i++)
        {
            if (matriculas[i].turma == turma)
            {
                Console.WriteLine("Aluno ja matriculado nessa turma.");
                return;
            }
        }

        Matricula matricula = new Matricula(this, turma, data);

        AdicionarMatricula(matricula);
        turma.AdicionarMatricula(matricula);

        Console.WriteLine("Matricula realizada com sucesso!");
    }
}

class Turma
{
    public string nome;
    public List<Matricula> matriculas;

    public Turma(string nome)
    {
        this.nome = nome;
        matriculas = new List<Matricula>();
    }

    public void AdicionarMatricula(Matricula matricula)
    {
        matriculas.Add(matricula);
    }

    public void ListarAlunos()
    {
        Console.WriteLine("Alunos da turma " + nome + ":");

        for (int i = 0; i < matriculas.Count; i++)
        {
            Console.WriteLine(matriculas[i].aluno.nome);
        }
    }
}

class Matricula
{
    public Aluno aluno;
    public Turma turma;
    public string data;

    public Matricula(Aluno aluno, Turma turma, string data)
    {
        this.aluno = aluno;
        this.turma = turma;
        this.data = data;
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno1 = new Aluno("Tuany");
        Aluno aluno2 = new Aluno("Maria");

        Turma turma1 = new Turma("Desenvolvimento de Sistemas");
        Turma turma2 = new Turma("Eletronica");

        aluno1.Matricular(turma1, "23/11/2026");
        aluno1.Matricular(turma2, "23/11/2026");
        aluno2.Matricular(turma1, "23/11/2026");

        aluno1.Matricular(turma1, "24/11/2026");

        Console.WriteLine();

        turma1.ListarAlunos();
    }
}
