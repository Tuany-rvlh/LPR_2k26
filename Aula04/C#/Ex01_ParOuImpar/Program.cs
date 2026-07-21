/*
 * Enunciado:
 * Desenvolva um programa que leia um número inteiro e informe
 * se esse número é par ou ímpar.
 *
 * Um número é considerado par quando o resto da divisão por 2
 * é igual a zero.
 */

// Variável que irá armazenar o número informado
int num = 0;

// Entrada do número com garantia de que o valor é inteiro
Console.Write("Digite um número inteiro: ");

if (int.TryParse(Console.ReadLine(), out num))
{
    // Verifica se o número é par ou ímpar
    if (num % 2 == 0)
    {
        Console.WriteLine("O número é PAR");
    }
    else
    {
        Console.WriteLine("O número é ÍMPAR");
    }
}
else
{
    // Caso o usuário digite algo que não seja um número inteiro
    Console.WriteLine("Valor inválido! Digite um número inteiro.");
}