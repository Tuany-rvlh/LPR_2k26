/*
 * Enunciado:
 * Desenvolva um programa que permita ao jogador escolher uma classe
 * de personagem de um jogo de RPG e, em seguida, exiba suas
 * habilidades especiais correspondentes.
 *
 * Classes disponíveis:
 *
 * 1 - Guerreira
 * Habilidades: Ataque Pesado, Defesa Total
 *
 * 2 - Mago
 * Habilidades: Bola de Fogo, Escudo de Gelo
 *
 * 3 - Arqueira
 * Habilidades: Flecha Precisa, Disparo Triplo
 */

// Exibe as opções de classes disponíveis
Console.WriteLine("1 - Guerreira");
Console.WriteLine("2 - Mago");
Console.WriteLine("3 - Arqueira");

Console.Write("Escolha sua classe de personagem: ");

// Variável que armazena a escolha do jogador
if (int.TryParse(Console.ReadLine(), out int classe))
{
    // Verifica a classe escolhida e mostra suas habilidades
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
}
else
{
    Console.WriteLine("Valor inválido! Digite um número.");
}