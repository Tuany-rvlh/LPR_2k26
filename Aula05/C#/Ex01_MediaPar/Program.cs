/*
 * Enunciado:
 * Desenvolva um programa que calcule a média aritmética de um conjunto
 * de números pares fornecidos pelo usuário.
 *
 * O usuário deve informar primeiro a quantidade de números que serão
 * digitados e, em seguida, informar os valores.
 *
 * Números ímpares devem ser ignorados no cálculo da média.
 */

// Exibe o título do programa
Console.WriteLine("Média Aritmética dos números pares");

// Entrada da quantidade de números
Console.Write("Digite a quantidade de números que serão informados: ");
int quantia = int.Parse(Console.ReadLine() ?? "0");

// Variáveis para armazenar a soma dos números pares e a quantidade deles
double acumulador = 0;
int cont = 0;

// Controle da quantidade de números que serão lidos
int i = 0;

while (i < quantia)
{
    Console.Write("Digite um número: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    // Verifica se o número é par
    if (num % 2 == 0)
    {
        acumulador += num;
        cont++;
    }

    i++;
}

// Verifica se foi informado algum número par
if (cont > 0)
{
    double media = acumulador / cont;
    Console.WriteLine($"A média dos valores pares digitados será: {media:F2}");
}
else
{
    Console.WriteLine("Nenhum número par foi informado.");
}