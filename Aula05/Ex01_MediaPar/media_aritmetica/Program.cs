Console.WriteLine("Média Aritmética:");

Console.Write("Digite a quantia de números que serão digitados e o conjunto de números: ");
string[] valores = Console.ReadLine()!.Split();
int quantia = Convert.ToInt32(valores[0]);

double acumulador = 0;
double cont = 0;

while (quantia != 0)
{
    double num = Convert.ToDouble(valores[quantia]);

    if(num % 2 == 0)
    {
        acumulador+=num;
        cont++;
    }

    quantia--;
}

Console.WriteLine($"A média dos valores pares digitados será: {acumulador/cont}");