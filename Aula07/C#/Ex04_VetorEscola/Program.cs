/*
 * Enunciado:
 * Desenvolva um programa que leia o nome de 10 alunos e suas notas.
 *
 * As informações devem ser armazenadas em vetores:
 * - Um vetor para os nomes;
 * - Um vetor para as notas.
 *
 * Crie uma função chamada ClassificarAluno() que receba a nota
 * e retorne a situação do aluno:
 *
 * Nota < 60       -> Reprovado
 * Nota 60 a 79    -> Recuperação
 * Nota >= 80      -> Aprovado
 *
 * Ao final, exiba um relatório com:
 * Nome, nota, situação, quantidade de aprovados, recuperação,
 * reprovados e média da turma.
 */


// Vetores para armazenar os nomes e as notas dos alunos
string[] alunos = new string[10];
int[] notas = new int[10];


// Variáveis para contar as situações dos alunos
int aprovados = 0;
int recuperacao = 0;
int reprovados = 0;

int somaNotas = 0;


// Função responsável por classificar o aluno pela nota
string ClassificarAluno(int nota)
{
    if (nota >= 80)
    {
        return "Aprovado";
    }
    else if (nota >= 60)
    {
        return "Recuperação";
    }
    else
    {
        return "Reprovado";
    }
}


// Leitura dos alunos e notas
for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o nome do aluno {i + 1}: ");
    alunos[i] = Console.ReadLine() ?? "";


    Console.Write($"Digite a nota do aluno {i + 1}: ");
    notas[i] = Convert.ToInt32(Console.ReadLine());


    // Soma as notas para calcular a média
    somaNotas += notas[i];


    // Conta a quantidade de alunos em cada situação
    string situacao = ClassificarAluno(notas[i]);

    if (situacao == "Aprovado")
    {
        aprovados++;
    }
    else if (situacao == "Recuperação")
    {
        recuperacao++;
    }
    else
    {
        reprovados++;
    }
}


// Exibição do relatório
Console.WriteLine("\n========== RELATÓRIO DOS ALUNOS ==========");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Aluno: {alunos[i]} | Nota: {notas[i]} | Situação: {ClassificarAluno(notas[i])}");
}


Console.WriteLine($"\nAprovados: {aprovados}");
Console.WriteLine($"Recuperação: {recuperacao}");
Console.WriteLine($"Reprovados: {reprovados}");

double media = somaNotas / 10.0;

Console.WriteLine($"Média da turma: {media:F1}");