
class Programs
{
    //Lista para separar 10 pilotos e suas características
    static List<Piloto> Cadastro10 = new();

    public struct Piloto
    {
        public string Nome;
        public string Equipe;
        public double Pontuacao;
    }

    static void Main()
    {
        CadastrarPiloto();
        ExibirRanking();
        
    }

    static void CadastrarPiloto()
    {
        //For para cadastrar os pilotos e suas devidas características em cada espaço de uma lista
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Cadastro do Piloto{i+1}");

            Piloto piloto = new Piloto();

            Console.Write("Digite o nome do piloto: ");
            piloto.Nome = Console.ReadLine() ?? "";

            Console.Write("Digite a equipe do piloto:  ");
            piloto.Equipe = Console.ReadLine() ?? "";

            Console.Write("Digite a pontuação do piloto: ");
            piloto.Pontuacao = Convert.ToDouble(Console.ReadLine());

            Cadastro10.Add(piloto);

            Console.WriteLine(" ");
        }
    }

    static void ExibirRanking()
    {   
        Cadastro10.Sort();
        Cadastro10.Reverse();

        for(int r; r < 10; r++)
        {
            Console.WriteLine(Cadastro10[r].Pontuacao);
        }
        
    }
}