/*
 * Enunciado:
 * Desenvolva um programa que leia o código de uma peça 1,
 * o número de peças 1, o valor unitário de cada peça 1,
 * o código de uma peça 2, o número de peças 2 e o valor
 * unitário de cada peça 2.
 *
 * Em seguida, calcule e mostre o valor a ser pago.
 */

string c1;
int p1;
double v1;

string c2;
int p2;
double v2;

// Leitura dos dados da primeira peça
Console.Write("Digite o código da peça 1: ");
c1 = Console.ReadLine() ?? "0";

Console.Write("Digite a quantidade de peças 1: ");
p1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o valor da peça 1: ");
v1 = double.Parse(Console.ReadLine() ?? "0");

// Leitura dos dados da segunda peça
Console.Write("Digite o código da peça 2: ");
c2 = Console.ReadLine() ?? "0";

Console.Write("Digite a quantidade de peças 2: ");
p2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o valor da peça 2: ");
v2 = double.Parse(Console.ReadLine() ?? "0");

// Cálculo do valor total
double resultado = (p1 * v1) + (p2 * v2);

// Exibe o valor a pagar
Console.WriteLine($"Valor a pagar: R${resultado:F2}");