using System;

public class Aluno
{
    public int matricula;
    public string nome;
    public double nota1;
    public double nota2;
    public double notaTrabalho;

    public Aluno(int Matricula, string Nome, double Nota1, double Nota2, double NotaTrabalho)
    {
        matricula = Matricula;
        nome = Nome;
        nota1 = Nota1;
        nota2 = Nota2;
        notaTrabalho = NotaTrabalho;
    }

    public double Media()
    {
        double media = ((nota1 * 2.5) + (nota2 * 2.5) + (notaTrabalho * 2)) / 7;

        return media;
    }

    public double Final()
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

    public void MostrarDados()
    {
        Console.WriteLine("Matricula: " + matricula);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Media: " + Media());

        if (Final() > 0)
        {
            Console.WriteLine("Precisa tirar " + Final() + " na prova final.");
        }
        else
        {
            Console.WriteLine("Aluno aprovado! Não precisa de prova final.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite a matricula: ");
        int matricula = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine() ?? "Nome nao informado";

        Console.Write("Digite a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota do trabalho: ");
        double notaTrabalho = Convert.ToDouble(Console.ReadLine());

        Aluno aluno = new Aluno(matricula, nome, nota1, nota2, notaTrabalho);

        aluno.MostrarDados();
    }
}