Random random = new Random();
int valorSecreto = random.Next(1, 101);

int tentativa;
int cont = 0;

Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===");
Console.WriteLine("Tente adivinhar um número entre 1 e 100!");

do
{
    Console.Write("Digite sua tentativa: ");

    if (!int.TryParse(Console.ReadLine(), out tentativa))
    {
        Console.WriteLine("Entrada inválida e gastou uma tentativa! Digite um número inteiro.");
        cont++;
        continue;
        
    }

    cont++;

    if (tentativa > valorSecreto)
    {
        Console.WriteLine("Muito alto!");
    }
    else if (tentativa < valorSecreto)
    {
        Console.WriteLine("Muito baixo!");
    }
    else
    {
        Console.WriteLine($"Acertou! Você usou {cont} tentativas!");
    }

} while (tentativa != valorSecreto);