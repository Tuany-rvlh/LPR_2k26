string[] dados1 = Console.ReadLine()!.Split();
string[] dados2 = Console.ReadLine()!.Split();

string c1 = dados1[0];
double p1 = Convert.ToDouble(dados1[1]);
double v1 = Convert.ToDouble(dados1[2]);

string c2 = dados1[0];
double p2 = Convert.ToDouble(dados2[1]);
double v2 = Convert.ToDouble(dados2[2]);

double resultado = (p1 * v1) + (p2 * v2);

Console.WriteLine($"Valor a pagar: R${resultado.ToString("F2")}");

