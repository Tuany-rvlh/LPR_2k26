Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);

Console.Write("Digite a sua primeira tentativa: ");
int num = Convert.ToInt32(Console.ReadLine());
int cont = 1;

while (true)
{
    if (num > valorInteiro){
        Console.WriteLine("Chutou alto!");
        cont++;
    }
    else if(num < valorInteiro)
    {
        Console.WriteLine("Chutou baixo!");
        cont++;
    }
    else
    {
        Console.WriteLine($"Acertou! Foram usadas {cont} tentativas!");
        break;
    }

    Console.Write("Digite a sua outra tentativa: ");
    num = Convert.ToInt32(Console.ReadLine());
}
