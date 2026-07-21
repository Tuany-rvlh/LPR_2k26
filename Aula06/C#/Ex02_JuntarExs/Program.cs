/*
 * Enunciado:
 * Desenvolva um algoritmo em C# que agrupe em funções os exercícios
 * 1, 3 e 4 da tarefa de estruturas de repetição.
 *
 * Cada exercício deve estar contido em uma função separada.
 * A função Main deve possuir um menu para selecionar as opções.
 */


// Exibe o menu de opções
static void Menu()
{
    Console.WriteLine();
    Console.WriteLine("==============================");
    Console.WriteLine("            MENU");
    Console.WriteLine("==============================");

    Console.WriteLine("1 - Média dos números pares");
    Console.WriteLine("2 - Soma dos ímpares múltiplos de 3");
    Console.WriteLine("3 - Soma dos dígitos do quadrado");
    Console.WriteLine("4 - Sair");
}


// Calcula a média dos números pares informados
static double MediaPar(int quantidade)
{
    double soma = 0;
    int contadorPares = 0;

    for (int i = 0; i < quantidade; i++)
    {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            soma += num;
            contadorPares++;
        }
    }

    if (contadorPares == 0)
    {
        return 0;
    }

    return soma / contadorPares;
}


// Soma os números ímpares que são múltiplos de 3 em um intervalo
static int SomaImparesMultiplos3(int inicio, int fim)
{
    int soma = 0;

    for (int i = inicio; i <= fim; i++)
    {
        if (i % 2 != 0 && i % 3 == 0)
        {
            soma += i;
        }
    }

    return soma;
}


// Soma os dígitos do quadrado de um número
static int SomaDigitosQuadrado(int num)
{
    int quadrado = num * num;
    int soma = 0;

    while (quadrado > 0)
    {
        soma += quadrado % 10;
        quadrado /= 10;
    }

    return soma;
}


// Programa principal
int opcao = 0;

do
{
    Menu();

    Console.Write("Digite a opção desejada: ");
    opcao = Convert.ToInt32(Console.ReadLine());


    switch (opcao)
    {
        case 1:

            Console.Write("Digite a quantidade de números: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            double media = MediaPar(quantidade);

            Console.WriteLine($"A média dos números pares é: {media:F2}");

            break;


        case 2:

            int resultado = SomaImparesMultiplos3(50, 500);

            Console.WriteLine(
                $"A soma dos números ímpares múltiplos de 3 é: {resultado}"
            );

            break;


        case 3:

            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int soma = SomaDigitosQuadrado(num);

            Console.WriteLine(
                $"A soma dos dígitos do quadrado é: {soma}"
            );

            break;


        case 4:

            Console.WriteLine("Saindo do programa...");
            break;


        default:

            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }


} while (opcao != 4);