int[] numeros = new int[10]; //criando vetor de 10 espaços
int[] numPar = new int[10]; //vetor para números pares
int[] numImpar = new int[10]; // vetor para números ímpares

for(int num = 0; num < 10; num++) // for para digitar os números do vetor
{
    Console.Write($"Digite o número {num+1} do vetor: "); //Usuário digita os números
    int numero = Convert.ToInt32(Console.ReadLine()); //leitura de entrada
    numeros[num] = numero; //armazena no array
}

for(int i = 0; i < numeros.Length; i++)
{
    if(numeros[i] % 2 == 0)
    {
        
    }
}


