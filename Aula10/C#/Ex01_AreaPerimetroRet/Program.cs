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
        Console.WriteLine($"A área do retângulo é {area}.");
    }

    public void calcPerimetro()
    {
        double perimetro = (2*Altura) + (2*Largura);
        Console.WriteLine($"O perímetro do retângulo é {perimetro}.");
        
    }



}

class Program
{
    static void Main()
    {
        Console.Write("Digite a altura do retângulo: ");
        double alt = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a largura do retângulo: ");
        double lar = Convert.ToDouble(Console.ReadLine());

        Retangulo ret = new Retangulo(alt, lar);
        ret.calcArea();
        ret.calcPerimetro();;
        
    }
}