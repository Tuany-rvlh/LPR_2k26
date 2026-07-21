/*
 * Enunciado:
 * Desenvolva uma função em C# que retorne o reverso de um número inteiro.
 */


// Função responsável por inverter o número informado
static int Reverter(int num)
{
    int numReverso = 0;
    int resto = 0;

    // Retira cada dígito do número e monta o reverso
    while (num != 0)
    {
        resto = num % 10;
        numReverso = numReverso * 10 + resto;
        num /= 10;
    }

    return numReverso;
}


// Entrada do número
Console.Write("Digite o número que será invertido: ");
int num = Convert.ToInt32(Console.ReadLine());


// Chama a função e guarda o resultado
int resultado = Reverter(num);


// Exibe o número invertido
Console.WriteLine($"O inverso desse número é: {resultado}");