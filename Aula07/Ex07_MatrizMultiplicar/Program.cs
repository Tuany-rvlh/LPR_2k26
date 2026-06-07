// declarar as matrizes
int[,] matrizA = new int[3, 3];
int[,] matrizB = new int[3, 3];

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        // solicitar os valores para a matriz A
        Console.Write($"Digite o valor para a posição [{i}][{j}] da matriz A: ");
        matrizA[i, j] = int.Parse(Console.ReadLine());
        
        // solicitar os valores para a matriz B
        Console.Write($"Digite o valor para a posição [{i}][{j}] da matriz B: ");
        matrizB[i, j] = int.Parse(Console.ReadLine());

        //espaço
        Console.WriteLine();
    }
}
