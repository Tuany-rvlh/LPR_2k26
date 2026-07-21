/*
 * Enunciado:
 * Desenvolva um programa que leia o valor do raio de um círculo e calcule
 * a sua área utilizando a fórmula:
 *
 *      área = π × raio²
 *
 * Considere o valor de π = 3.14159 e apresente o resultado da área
 * com quatro casas decimais.
 */

// Constante para o valor de pi
const double pi = 3.14159;

// Variáveis para armazenar os valores do raio e da área
double raio = 0;
double area = 0;

// Entrada do valor do raio
Console.Write("Digite o raio do círculo: ");
raio = double.Parse(Console.ReadLine() ?? "0");

// Cálculo da área do círculo
area = pi * (raio * raio);

// Saída do valor da área com quatro casas decimais
Console.WriteLine($"A área deste círculo é: {area:F4} m²");