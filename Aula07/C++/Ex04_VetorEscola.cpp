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
 * Ao final, exiba um relatório contendo:
 * Nome, nota, situação, quantidade de aprovados,
 * recuperação, reprovados e média da turma.
 */


// Bibliotecas utilizadas
#include <iostream>
#include <clocale>
#include <string>
#include <iomanip>

using namespace std;


// Função que classifica o aluno de acordo com sua nota
string ClassificarAluno(int nota)
{
    if(nota >= 80)
    {
        return "Aprovado";
    }
    else if(nota >= 60)
    {
        return "Recuperação";
    }
    else
    {
        return "Reprovado";
    }
}


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Vetores para armazenar os nomes e as notas dos alunos
    string alunos[10];
    int notas[10];


    // Variáveis para contabilizar as situações
    int aprovados = 0;
    int recuperacao = 0;
    int reprovados = 0;

    int somaNotas = 0;


    // Entrada dos dados dos alunos
    for(int i = 0; i < 10; i++)
    {
        cout << "Digite o nome do aluno " << i + 1 << ": ";
        cin >> alunos[i];

        cout << "Digite a nota do aluno " << i + 1 << ": ";
        cin >> notas[i];


        // Soma as notas para calcular a média
        somaNotas += notas[i];


        // Classifica e contabiliza a situação do aluno
        string situacao = ClassificarAluno(notas[i]);

        if(situacao == "Aprovado")
        {
            aprovados++;
        }
        else if(situacao == "Recuperação")
        {
            recuperacao++;
        }
        else
        {
            reprovados++;
        }


        cout << endl;
    }


    // Exibição do relatório
    cout << "\n========== RELATÓRIO DOS ALUNOS ==========" << endl;


    for(int i = 0; i < 10; i++)
    {
        cout << "Aluno: " << alunos[i]
             << " | Nota: " << notas[i]
             << " | Situação: " << ClassificarAluno(notas[i])
             << endl;
    }


    // Calcula a média da turma
    double media = somaNotas / 10.0;


    cout << fixed << setprecision(1);

    cout << "\nAprovados: " << aprovados << endl;
    cout << "Recuperação: " << recuperacao << endl;
    cout << "Reprovados: " << reprovados << endl;
    cout << "Média da turma: " << media << endl;

}