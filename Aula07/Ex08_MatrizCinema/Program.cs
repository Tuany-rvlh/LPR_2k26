int[,] SalaCadeira = new int[6,8];
int opcao = 0;

static void Menu(int opcao)
{
    Console.WriteLine("\nMenu de opções: ");
    Console.WriteLine("1 - Reservar assento;");
    Console.WriteLine("2 - Cancelar reserva;");
    Console.WriteLine("3 - Consultar assento;");
    Console.WriteLine("4 - Mostrar mapa da sala;");
    Console.WriteLine("5 - Encerrar. ");

    Console.Write("\nDigite o número da opção desejada: ");
    string escolha = Console.ReadLine() ?? "";
    if (int.TryParse(escolha, out int escolhaSelecionada))
    {
        opcao = escolhaSelecionada;
        return;   
    }
}

Console.WriteLine("\nBem-vindo ao sistema de seleção de cadeira no sistema!");
do{
    Console.WriteLine("==========================================================================");
    Menu(opcao);
    Console.WriteLine("==========================================================================");

    switch (opcao)
    {
        case 1:
        ReserverAcento();
        break;

        case 2:
        CancelarReserva();
        break;

        case 3:
        ConsultarAcento();
        break;

        case 4:
        MostrarMapa();
        break;

        case 5:
        Console.WriteLine("Obrigado por usar o sistema de seleção de heróis da Marvel! Volte sempre!");
        break;

        default:
        Console.WriteLine("Opção inválida! Por favor, selecione uma opção válida.");
        break;

    }
}while(opcao != 5);
