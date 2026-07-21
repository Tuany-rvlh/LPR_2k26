/*
 * Enunciado:
 * Desenvolva um programa que leia 10 números inteiros e armazene-os
 * em um vetor.
 *
 * Depois, solicite um número para pesquisar no vetor.
 *
 * Caso o número exista, mostre todas as posições em que ele aparece
 * e a quantidade de ocorrências encontradas.
 */


// Vetor criado para armazenar os 10 números
int[] vetor = new int[10];

int numProcurado = 0;
int ocorrencias = 0;


// Entrada dos valores no vetor
for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o número {i + 1}: ");
    vetor[i] = Convert.ToInt32(Console.ReadLine());
}


// Solicita o número que será pesquisado
Console.Write("\nDigite o número que deseja pesquisar: ");
numProcurado = Convert.ToInt32(Console.ReadLine());


// Percorre o vetor procurando o número
Console.Write("\nNúmero encontrado nas posições: ");

for (int i = 0; i < 10; i++)
{
    if (vetor[i] == numProcurado)
    {
        Console.Write(i + " "); // Exibe a posição encontrada
        ocorrencias++; // Conta a quantidade de vezes que apareceu
    }
}


// Verifica se encontrou alguma ocorrência
if (ocorrencias == 0)
{
    Console.WriteLine("Nenhuma");
    Console.WriteLine("Número não encontrado!");
}
else
{
    Console.WriteLine($"\nQuantidade de ocorrências: {ocorrencias}");
}