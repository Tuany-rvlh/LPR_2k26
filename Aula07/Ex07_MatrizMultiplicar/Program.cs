// declarar as matrizes
int[,] matrizA = new int[3, 3];
int[,] matrizB = new int[3, 3];
int[,] matrizAB = new int[3,3];

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

//cálculo da matriz
matrizAB[0, 0] = (matrizA[0,0] * matrizB[0,0]) + (matrizA[0,1] * matrizB[1,0]) + (matrizA[0,2] * matrizB[2,0]);
matrizAB[0, 1] = (matrizA[0,0] * matrizB[0,1]) + (matrizA[0,1] * matrizB[1,1]) + (matrizA[0,2] * matrizB[2,1]);
matrizAB[0, 2] = (matrizA[0,0] * matrizB[0,2]) + (matrizA[0,1] * matrizB[1,2]) + (matrizA[0,2] * matrizB[2,2]);

matrizAB[1, 0] = (matrizA[1,0] * matrizB[0,0]) + (matrizA[1,1] * matrizB[1,0]) + (matrizA[1,2] * matrizB[2,0]);
matrizAB[1, 1] = (matrizA[1,0] * matrizB[0,1]) + (matrizA[1,1] * matrizB[1,1]) + (matrizA[1,2] * matrizB[2,1]);
matrizAB[1, 2] = (matrizA[1,0] * matrizB[0,2]) + (matrizA[1,1] * matrizB[1,2]) + (matrizA[1,2] * matrizB[2,2]);

matrizAB[2, 0] = (matrizA[2,0] * matrizB[0,0]) + (matrizA[2,1] * matrizB[1,0]) + (matrizA[2,2] * matrizB[2,0]);
matrizAB[2, 1] = (matrizA[2,0] * matrizB[0,1]) + (matrizA[2,1] * matrizB[1,1]) + (matrizA[2,2] * matrizB[2,1]);
matrizAB[2, 2] = (matrizA[2,0] * matrizB[0,2]) + (matrizA[2,1] * matrizB[1,2]) + (matrizA[2,2] * matrizB[2,2]);

//mostrar a matriz
for (int i = 0; i < matrizAB.GetLength(0); i++)
{
    for (int j = 0; j < matrizAB.GetLength(1); j++)
    {
        Console.Write($"{matrizAB[i, j]} ");
    }
    Console.WriteLine();
}
