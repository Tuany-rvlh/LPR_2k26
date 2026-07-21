/*
 * Enunciado:
 * Desenvolva um algoritmo de adivinhação de números.
 *
 * O programa deve gerar um número aleatório entre 1 e 100.
 * O usuário deverá informar tentativas até acertar o número secreto.
 *
 * A cada tentativa, o programa deve informar se o usuário:
 * - chutou alto;
 * - chutou baixo;
 * - acertou.
 *
 * Ao final, deve informar a quantidade de tentativas utilizadas.
 */

// Gera um número aleatório entre 1 e 100
Random random = new Random();
int valorSecreto = random.Next(1, 101);

// Variáveis para armazenar a tentativa e contar os chutes
int tentativa = 0;
int cont = 0;

Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===");
Console.WriteLine("Tente adivinhar um número entre 1 e 100!");

// O jogo continua até o usuário acertar
do
{
    Console.Write("Digite sua tentativa: ");

    // Verifica se o valor digitado é um número inteiro válido
    if (int.TryParse(Console.ReadLine(), out tentativa))
    {
        cont++;

        // Compara a tentativa com o número secreto
        if (tentativa > valorSecreto)
        {
            Console.WriteLine("Chutou alto!");
        }
        else if (tentativa < valorSecreto)
        {
            Console.WriteLine("Chutou baixo!");
        }
        else
        {
            Console.WriteLine($"Acertou! Você usou {cont} tentativas.");
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida! Digite um número inteiro.");
    }

} while (tentativa != valorSecreto);