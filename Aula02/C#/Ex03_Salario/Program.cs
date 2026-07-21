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

// Variáveis para armazenar os dados do funcionário
int num_funcionario = 0;
int horas = 0;
double valor_hora = 0;
double salario = 0;

// Entrada das informações do funcionário
Console.Write("Digite o número do funcionário: ");
num_funcionario = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite a quantidade de horas trabalhadas: ");
horas = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o valor recebido por hora: ");
valor_hora = double.Parse(Console.ReadLine() ?? "0");

// Cálculo do salário com base nas horas trabalhadas e no valor da hora
salario = horas * valor_hora;

// Exibição das informações do funcionário e do salário calculado
Console.WriteLine(new string('=', 30));
Console.WriteLine($"Número do funcionário: {num_funcionario}");
Console.WriteLine($"Salário: {salario:F2}");