/*
 * Enunciado:
 * Desenvolva um programa que leia uma matriz 3x3 de números inteiros.
 *
 * Ao final, mostre a matriz digitada e calcule a soma de todos
 * os elementos presentes nela.
 */


// Declara uma matriz 3x3
int[,] matriz = new int[3, 3];


// Variável para armazenar a soma dos elementos da matriz
int soma = 0;


// Entrada dos valores da matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Digite o valor da posição [{i}][{j}]: ");
        matriz[i, j] = Convert.ToInt32(Console.ReadLine());

        soma += matriz[i, j]; // Soma o valor digitado
    }
}


// Exibe a matriz preenchida
Console.WriteLine("\nMatriz digitada:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }

    Console.WriteLine(); // Quebra a linha ao finalizar uma linha da matriz
}


// Exibe a soma dos elementos da matriz
Console.WriteLine($"\nSoma = {soma}");