/*
 * Enunciado:
 * Desenvolva um programa que leia 5 números inteiros e armazene
 * esses valores em um vetor.
 *
 * Ao final, mostre todos os números digitados, o maior valor
 * armazenado e a posição em que ele se encontra.
 */


// Cria um vetor de inteiros com 5 posições
int[] vetor = new int[5];


// Entrada dos valores com verificação
for (int i = 0; i < 5; i++)
{
    while (true)
    {
        Console.Write($"Digite o valor da posição {i}: ");

        string entrada = Console.ReadLine() ?? "";

        if (int.TryParse(entrada, out vetor[i]))
        {
            break; // Sai do while quando o valor for válido
        }
        else
        {
            Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
        }
    }
}


// Considera inicialmente o primeiro valor como o maior
int maiorValor = vetor[0];
int posMaior = 0;


// Procura o maior valor do vetor
for (int i = 1; i < 5; i++)
{
    if (vetor[i] > maiorValor)
    {
        maiorValor = vetor[i];
        posMaior = i;
    }
}


// Mostra o vetor completo
Console.Write("\nVetor: ");

for (int i = 0; i < 5; i++)
{
    Console.Write(vetor[i] + " ");
}


// Mostra o maior valor encontrado
Console.WriteLine($"\nMaior valor: {maiorValor}");
Console.WriteLine($"Posição do maior valor: {posMaior}");