using System;

public class Funcionario
{
    public string nome;
    public double salarioBruto;
    public double salarioLiquido;
    public double porcentagem;

    public Funcionario(string Nome, double SalarioBruto, double Porcentagem)
    {
        nome = Nome;
        salarioBruto = SalarioBruto;
        porcentagem = Porcentagem;
    }

    public void MostrarDados()
    {
        Console.WriteLine("Nome: " + nome);

        if(salarioBruto <= 2000)
        {
            salarioLiquido = salarioBruto - (salarioBruto * 0.10);
        }
        else if(salarioBruto <= 3000)
        {
            salarioLiquido = salarioBruto - (salarioBruto * 0.15);
        }
        else
        {
            salarioLiquido = salarioBruto - (salarioBruto * 0.20);
        }

        Console.WriteLine("Salário Líquido: " + salarioLiquido);
    }

    public void AumentarSalario()
    {
        double aumento = salarioBruto * (porcentagem / 100);
        salarioBruto += aumento;
        Console.WriteLine("Salário após aumento: " + salarioBruto); 
    }

}
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do funcionário: ");
        string nomefunc = Console.ReadLine() ?? "Nome não informado";

        Console.WriteLine("Digite o salário bruto do funcionário: ");
        double salariobruto = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Digite a porcentagem de aumento: ");
        double porcentagem = Convert.ToDouble(Console.ReadLine());  

        Funcionario funcionario = new Funcionario(nomefunc, salariobruto, porcentagem);
        funcionario.MostrarDados();
        funcionario.AumentarSalario();
    }
    
}
