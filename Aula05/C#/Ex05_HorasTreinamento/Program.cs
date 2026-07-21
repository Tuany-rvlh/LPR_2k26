/*
 * Enunciado:
 * Desenvolva um programa que simule o treinamento de um Jedi.
 *
 * O usuário deve informar a quantidade de horas de treinamento por dia.
 * O programa deve calcular o total de horas treinadas por semana,
 * desconsiderando sábados e domingos.
 *
 * Ao final, deve informar quantos dias, semanas e meses são necessários
 * para alcançar 1000 horas de treinamento.
 *
 * Considere:
 * 1 semana = 5 dias de treinamento
 * 1 mês = 4,5 semanas
 */

// Variáveis para armazenar as horas de treinamento
double horasDia = 0;
double horasSemana = 0;
double totalHoras = 0;

int semanas = 0;


// Entrada com garantia de que o valor seja maior que zero
do
{
    Console.Write("Insira o número de horas de treinamento por dia: ");
    horasDia = double.Parse(Console.ReadLine() ?? "0");

    if (horasDia <= 0)
    {
        Console.WriteLine("Valor inválido! Digite um número maior que zero.\n");
    }

} while (horasDia <= 0);


// Calcula a quantidade de horas treinadas em uma semana
horasSemana = 5 * horasDia;


// Continua somando semanas até alcançar 1000 horas
while (totalHoras < 1000)
{
    totalHoras += horasSemana;
    semanas++;
}


// Calcula a quantidade de dias e meses necessários
int dias = semanas * 5;
double meses = semanas / 4.5;


// Exibe os resultados
Console.WriteLine();

Console.WriteLine("===============================");
Console.WriteLine("     RESULTADO DO TREINAMENTO");
Console.WriteLine("===============================");
Console.WriteLine();

Console.WriteLine($"Total de horas treinadas: {totalHoras:F2} horas\n");

Console.WriteLine($"Número de dias para atingir 1000 horas: {dias} dias\n");

Console.WriteLine($"Número de semanas para atingir 1000 horas: {semanas} semanas\n");

Console.WriteLine($"Número de meses para atingir 1000 horas: {meses:F2} meses");

Console.WriteLine();
Console.WriteLine("===============================");