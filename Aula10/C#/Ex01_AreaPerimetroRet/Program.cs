using System;

public class Retangulo
{
    public double Altura;
    public double Largura;
    public Retangulo(double altura, double largura)
    {
        Altura = altura;
        Largura = largura;
    }

    public void calcArea()
    {
        double area = Altura*Largura;
        Console.WriteLine($"A área do retângulo é {area}");
    }

    public void calcPerimetro()
    {
        double perimetro = (2*Altura) + (2*Largura);
        Console.WriteLine($"O perímetro do retângulo é {perimetro}");
        
    }



}

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a altura do retângulo: ");
        double alt = Console.Read();
        Retangulo ret = new Retangulo(2, 3);
        ret.calcArea();
        ret.calcPerimetro();
        
    }
}