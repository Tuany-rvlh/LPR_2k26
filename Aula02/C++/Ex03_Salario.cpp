/*
 * Enunciado:
 * Desenvolva um programa que leia o número de um funcionário,
 * a quantidade de horas trabalhadas e o valor recebido por hora.
 *
 * Em seguida, calcule o salário desse funcionário utilizando a fórmula:
 *
 * salário = horas trabalhadas × valor por hora
 *
 * Ao final, apresente o número do funcionário e seu salário
 * com duas casas decimais.
 */

// Bibliotecas utilizadas
#include <iostream>
#include <iomanip>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite a exibição de caracteres em português

    // Variáveis para armazenar os dados do funcionário
    int num_funcionario = 0;
    int horas = 0;
    float valor_hora = 0;
    float salario = 0;

    // Entrada das informações do funcionário
    cout << "Digite o número do funcionário: ";
    cin >> num_funcionario;

    cout << "Digite a quantidade de horas trabalhadas: ";
    cin >> horas;

    cout << "Digite o valor recebido por hora: ";
    cin >> valor_hora;

    // Cálculo do salário com base nas horas trabalhadas e no valor da hora
    salario = horas * valor_hora;

    // Exibição dos dados do funcionário e do salário calculado
    cout << string(30, '=') << endl;
    cout << "Número do funcionário: " << num_funcionario << endl;

    cout << fixed << setprecision(2);
    cout << "Salário: " << salario << endl;

}