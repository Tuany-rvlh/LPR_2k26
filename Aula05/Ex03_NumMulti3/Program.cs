int soma = 0;

for (int i = 51; i <= 500; i+= 3)
{
    if (i % 2 == 1)
    {
       soma+=i;
    }
}
Console.WriteLine($"A soma de todos os números ímpares múltiplos de 3 entre 50 e 500 é: {soma}");