class Programs
{
    static void Main()
    {
        //Váriveis utilizadas
        List<int> numeros100 = new();
        int numeroAleatorio = 0;

        Random num = new Random();

        for(int i = 0; i < 100; i++)
        {
            numeroAleatorio = num.Next(101);
            numeros100.Add(numeroAleatorio);
        }

        numeros100.Sort();

        Console.WriteLine("Lista ordenada");
        MostrarNumeros(numeros100);

        numeros100.RemoveAll(x => x % 2 == 0);
        Console.WriteLine("Lista sem os pares");
        MostrarNumeros(numeros100);

    }

    static void MostrarNumeros(List<int> numeros)
    {
        foreach (int numero in numeros)
        {
            Console.Write($"{numero} " );
        }
    }

}