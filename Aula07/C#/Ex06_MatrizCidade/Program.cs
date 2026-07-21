/*
 * Enunciado:
 * Desenvolva um programa que utilize uma matriz para armazenar
 * as distâncias entre quatro cidades.
 *
 * O usuário deve informar uma cidade de origem e uma cidade de destino.
 * Ao final, o programa deve mostrar a distância entre elas.
 */


// Matriz contendo as distâncias entre as cidades
int[,] matriz =
{
    { 0, 524, 521, 882 },
    { 524, 0, 434, 586 },
    { 521, 434, 0, 429 },
    { 882, 586, 429, 0 }
};


// Vetor contendo os nomes das cidades
string[] cidades =
{
    "Vitória",
    "Belo Horizonte",
    "Rio de Janeiro",
    "São Paulo"
};


int origem;
int destino;


do
{
    // Exibe as opções de cidades
    Console.WriteLine("\n===== CIDADES =====");

    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"{i} - {cidades[i]}");
    }


    Console.Write("\nDigite a cidade de origem: ");
    origem = Convert.ToInt32(Console.ReadLine());


    Console.Write("Digite a cidade de destino: ");
    destino = Convert.ToInt32(Console.ReadLine());


    // Verifica se as posições digitadas existem
    if (origem < 0 || origem > 3 || destino < 0 || destino > 3)
    {
        Console.WriteLine("Cidade inválida! Tente novamente.");
    }
    else if (origem == destino)
    {
        Console.WriteLine("Origem e destino são iguais. Programa encerrado.");
    }
    else
    {
        Console.WriteLine($"Distância entre {cidades[origem]} e {cidades[destino]}: {matriz[origem, destino]} km");
    }

} while (origem != destino);