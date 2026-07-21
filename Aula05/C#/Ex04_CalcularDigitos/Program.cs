/*
 * Enunciado:
 * Desenvolva um programa que solicite ao usuário um número e calcule
 * a soma dos dígitos do quadrado desse número.
 *
 * Exemplo:
 * 123² = 15129
 * Soma dos dígitos: 1 + 5 + 1 + 2 + 9 = 18
 */

// Variáveis para armazenar os valores do cálculo
int num = 0;
int quadrado = 0;
int contador = 0;
int soma = 0;

// Entrada do número
Console.Write("Digite um número: ");
num = int.Parse(Console.ReadLine() ?? "0");

// Calcula o quadrado do número informado
quadrado = num * num;

// Copia o valor do quadrado para retirar seus dígitos
contador = quadrado;

// Soma cada dígito do quadrado
while (contador > 0)
{
    soma += contador % 10;
    contador = contador / 10;
}

// Exibe os resultados
Console.WriteLine($"O quadrado do número é: {quadrado}");
Console.WriteLine($"A soma dos dígitos do quadrado é: {soma}");