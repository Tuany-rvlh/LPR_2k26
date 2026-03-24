Console.WriteLine("1 - Guerreira\n2 - Mago\n3 - Arqueira");
Console.WriteLine("Escolha sua classe de jogo: ");

int classe = Convert.ToInt16(Console.ReadLine());

switch (classe)
{
    case 1:
    Console.WriteLine("Suas habilidades são: Ataque Pesado, Defesa Total");
    break;

    case 2:
    Console.WriteLine("Suas habilidades são: Bola de Fogo, Escudo de Gelo");
    break;

    case 3:
    Console.WriteLine("Suas habilidades são: Flecha Precisa, Disparo Triplo");
    break;

    default:
    Console.WriteLine("Você digitou uma opção inválida!");
    break;

}
