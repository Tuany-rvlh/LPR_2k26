/*
 * Enunciado:
 * Desenvolva um programa que leia quatro valores inteiros A, B, C e D.
 *
 * Em seguida, calcule a diferença entre o produto de A e B
 * pelo produto de C e D.
 *
 * Fórmula:
 * diferença = (A × B) - (C × D)
 *
 * Ao final, apresente o resultado da diferença calculada.
 */

// Variáveis que armazenam os valores informados pelo usuário
int A = 0;
int B = 0;
int C = 0;
int D = 0;

// Variável que irá guardar o resultado do cálculo
int diferenca = 0;

// Leitura dos valores digitados pelo usuário
Console.Write("Digite o valor de A: ");
A = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o valor de B: ");
B = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o valor de C: ");
C = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o valor de D: ");
D = int.Parse(Console.ReadLine() ?? "0");

// Calcula a diferença entre os produtos de A e B e de C e D
diferenca = (A * B) - (C * D);

// Mostra o resultado final do cálculo
Console.WriteLine($"A diferença é: {diferenca}");