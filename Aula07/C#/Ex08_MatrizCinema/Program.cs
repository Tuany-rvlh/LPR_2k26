/*
 * Enunciado:
 * Um cinema possui uma sala com 6 linhas e 8 colunas.
 * Cada posição da matriz representa uma cadeira:
 *
 * 0 = Livre
 * 1 = Ocupada
 *
 * Inicialmente todas as cadeiras devem estar livres.
 *
 * Crie um sistema com menu repetitivo:
 *
 * 1 - Reservar assento
 * 2 - Cancelar reserva
 * 3 - Consultar assento
 * 4 - Mostrar mapa da sala
 * 5 - Encerrar
 *
 * Utilize uma função chamada VerificarAssento().
 * A função deve retornar "Livre" ou "Ocupado".
 */


// Matriz que representa as cadeiras da sala
int[,] SalaCadeira = new int[6, 8];

int opcao = 0;


// Função do menu
void Menu(ref int opcao)
{
    Console.WriteLine("\nMenu de opções:");
    Console.WriteLine("1 - Reservar assento;");
    Console.WriteLine("2 - Cancelar reserva;");
    Console.WriteLine("3 - Consultar assento;");
    Console.WriteLine("4 - Mostrar mapa da sala;");
    Console.WriteLine("5 - Encerrar.");

    Console.Write("\nDigite o número da opção desejada: ");

    string escolha = Console.ReadLine() ?? "";

    if (int.TryParse(escolha, out int escolhaSelecionada))
    {
        opcao = escolhaSelecionada;
    }
}


// Função para reservar cadeira
void ReservarAssento()
{
    Console.Write("\nDigite a linha do assento (0 a 5): ");
    int linha = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite a coluna do assento (0 a 7): ");
    int coluna = Convert.ToInt32(Console.ReadLine());


    if(linha < 0 || linha > 5 || coluna < 0 || coluna > 7)
    {
        Console.WriteLine("Assento inválido!");
    }
    else if(SalaCadeira[linha, coluna] == 1)
    {
        Console.WriteLine("Esse assento já está ocupado!");
    }
    else
    {
        SalaCadeira[linha, coluna] = 1;
        Console.WriteLine("Assento reservado com sucesso!");
    }
}


// Função para cancelar reserva
void CancelarReserva()
{
    Console.Write("\nDigite a linha do assento (0 a 5): ");
    int linha = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite a coluna do assento (0 a 7): ");
    int coluna = Convert.ToInt32(Console.ReadLine());


    if(linha < 0 || linha > 5 || coluna < 0 || coluna > 7)
    {
        Console.WriteLine("Assento inválido!");
    }
    else if(SalaCadeira[linha, coluna] == 0)
    {
        Console.WriteLine("Esse assento já está livre!");
    }
    else
    {
        SalaCadeira[linha, coluna] = 0;
        Console.WriteLine("Reserva cancelada com sucesso!");
    }
}


// Função que verifica o estado do assento
string VerificarAssento(int linha, int coluna)
{
    if(SalaCadeira[linha, coluna] == 0)
    {
        return "Livre";
    }
    else
    {
        return "Ocupado";
    }
}


// Função para consultar cadeira
void ConsultarAssento()
{
    Console.Write("\nDigite a linha do assento (0 a 5): ");
    int linha = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite a coluna do assento (0 a 7): ");
    int coluna = Convert.ToInt32(Console.ReadLine());


    if(linha < 0 || linha > 5 || coluna < 0 || coluna > 7)
    {
        Console.WriteLine("Assento inválido!");
    }
    else
    {
        Console.WriteLine($"O assento [{linha}][{coluna}] está {VerificarAssento(linha, coluna)}.");
    }
}


// Função para mostrar mapa da sala
void MostrarMapa()
{
    Console.WriteLine("\nMapa da sala:");

    for(int i = 0; i < 6; i++)
    {
        for(int j = 0; j < 8; j++)
        {
            Console.Write(SalaCadeira[i,j] + " ");
        }

        Console.WriteLine();
    }
}


// Programa principal
Console.WriteLine("\nBem-vindo ao sistema de reservas do cinema!");

do
{
    Console.WriteLine("\n==========================================================================");

    Menu(ref opcao);

    Console.WriteLine("==========================================================================");


    switch(opcao)
    {
        case 1:
            ReservarAssento();
            break;


        case 2:
            CancelarReserva();
            break;


        case 3:
            ConsultarAssento();
            break;


        case 4:
            MostrarMapa();
            break;


        case 5:
            Console.WriteLine("Obrigado por utilizar o sistema do cinema!");
            break;


        default:
            Console.WriteLine("Opção inválida! Escolha uma opção válida.");
            break;
    }


} while(opcao != 5);