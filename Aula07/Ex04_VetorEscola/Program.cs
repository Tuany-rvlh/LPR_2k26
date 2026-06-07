// Vetor para armazenar os nomes dos alunos, notas, condição
string [] alunos = new string[10];
double [] notas = new double[10];
string [] condicao = new string[10];

double nota = 0; //Confirmar que a nota é válida
int aprovados = 0; //Contar a quantidade de alunos aprovados
int reprovados = 0; //Contar a quantidade de alunos reprovados
int recuperacao = 0; //Contar a quantidade de alunos em recuperação
double notaTotal = 0; //Armazenar a soma das notas para calcular a média

void ClassificarAluno(double nota, int i) //função para classificar o aluno de acordo com a nota
{
    if(nota >= 80)
    {
        condicao[i] = "Aprovado";
        aprovados++;
    }
    else if(nota >= 60)
    {
        condicao[i] = "Recuperação";
        recuperacao++;
    }
    else
    {
        condicao[i] = "Reprovado";
        reprovados++;
    }

}

void ExibirRelatorio() //função para exibir o relatório dos alunos
{
    Console.WriteLine("Relatório dos Alunos:");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Aluno: {alunos[i]}, Nota: {notas[i]}, Condição: {condicao[i]}");
    }
    Console.WriteLine($"\nTotal de Aprovados: {aprovados}");
    Console.WriteLine($"Total de Recuperação: {recuperacao}");
    Console.WriteLine($"Total de Reprovados: {reprovados}");
    Console.WriteLine($"Média das Notas: {notaTotal / 10:F2}");
}

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o nome do aluno {i + 1}: ");
    alunos[i] = Console.ReadLine();
    Console.Write($"Digite a nota do aluno {i + 1}: ");
    nota = double.Parse(Console.ReadLine());

    if(nota >= 0 && nota <= 100) // verifica se a nota é válida
    {
        notas[i] = nota; // se for, é armazenada
        notaTotal += nota; // adiciona a nota à soma total
        ClassificarAluno(nota, i); // classifica o aluno de acordo com a nota
    }
    else
    {
        Console.WriteLine("Nota inválida, tente novamente.");
        i--; //Volta para a posição anterior para colocar novamente o nome e a nota do aluno
    }
    Console.WriteLine(); //Pula uma linha para melhor visualização
}

Console.WriteLine();
Console.WriteLine("Deseja ver o relatório dos alunos? (s/n): ");
string resposta = Console.ReadLine();

if (resposta == "s" || resposta == "S")
{
    ExibirRelatorio();
}
else
{
    Console.WriteLine("Relatório não exibido.");
}