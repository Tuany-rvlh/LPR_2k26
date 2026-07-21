/*
 * Enunciado:
 * Leia dois valores inteiros (A e B). Após, o programa deve mostrar
 * uma mensagem "São Múltiplos" ou "Não são Múltiplos", indicando se
 * os valores lidos são múltiplos entre si.
 *
 * Atenção:
 * Os números podem ser digitados em ordem crescente ou decrescente.
 */

// Variáveis que armazenam os valores informados pelo usuário
int A = 0;
int B = 0;

// Entrada dos valores com garantia de que são inteiros
Console.Write("Digite o valor de A: ");

if (int.TryParse(Console.ReadLine(), out A))
{
    Console.Write("Digite o valor de B: ");

    if (int.TryParse(Console.ReadLine(), out B))
    {
        // Verifica se algum valor é zero para evitar divisão inválida
        if (A == 0 || B == 0)
        {
            Console.WriteLine("Não é possível verificar múltiplos com zero.");
        }
        else
        {
            // Verifica qual número deve ser usado como divisor
            if (A > B)
            {
                if (A % B == 0)
                {
                    Console.WriteLine("São múltiplos!");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos!");
                }
            }
            else
            {
                if (B % A == 0)
                {
                    Console.WriteLine("São múltiplos!");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos!");
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Valor inválido! Digite um número inteiro.");
    }
}
else
{
    Console.WriteLine("Valor inválido! Digite um número inteiro.");
}