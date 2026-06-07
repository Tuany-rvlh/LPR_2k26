// Vetores criados para armazenar os números, os pares e os ímpares
int[] vetor = new int[10];
int[] par = new int[10];
int[] impar = new int[10];

// Váriaveis para saber a posição dos vetores de par e ímpar
int qtdPar = 0;
int qtdImpar = 0;

for (int i = 0; i < 10; i++) 
{
    Console.Write($"Digite o número {i + 1}: "); //Solicitação do número para o usuário
    vetor[i] = int.Parse(Console.ReadLine()); //Armazena

    if (vetor[i] % 2 == 0) //se for par
    {
        par[qtdPar] = vetor[i]; //armazeana o número no vetor de par
        qtdPar++; // aumenta a posição do próximo número par
    }
    else
    {
        impar[qtdImpar] = vetor[i]; //armazeana o número no vetor de ímpar
        qtdImpar++; // aumenta a posição do próximo número ímpar
    }
}

Console.Write("Números pares: "); //Exibe os números pares
for (int i = 0; i < qtdPar; i++)
{
    Console.Write($"{par[i]}, ");
}

Console.Write("\nNúmeros ímpares: "); //Exibe os números ímpares4
for (int i = 0; i < qtdImpar; i++)
{
    Console.Write($"{impar[i]}, ");
}