int soma = 0;

for (int i = 50; i <= 500; i++)
{
    if ( i % 3 == 0 && i % 2 == 1)
    {
       soma+=i;
    }
}
Console.WriteLine($"A soma de todos os números ìmpares múltiplos de 3 é: {soma}");