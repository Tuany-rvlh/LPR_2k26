using System;
class Program
{
    //Struct com as características do livro
    public struct Caract
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
        public double NumeroPaginas;
        public double Preco;

    }

    static void Main()
    {
        //Vetor para separar 3 livros
        Caract[] Livro = new Caract[3];

        //For para cadastrar os livros e suas devidas características
        for(int i = 0; i < 3; i++)
        {
            Console.Write("Digite o título do livro: ");
            Livro[i].Titulo = Console.ReadLine() ?? "";

            Console.Write("Digite o autor do livro: ");
            Livro[i].Autor = Console.ReadLine() ?? "";

            Console.Write("Digite o ano de publicação do livro: ");
            Livro[i].AnoPublicacao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de páginas do livro: ");
            Livro[i].NumeroPaginas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o preço do livro: ");
            Livro[i].Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");
        }

        double precoTotal = Livro[0].Preco + Livro[1].Preco + Livro[2].Preco;
        double mediaPaginas = (Livro[0].NumeroPaginas + Livro[1].NumeroPaginas + Livro[].NumeroPaginas) / 3;

        Console.WriteLine($"O preço total dos livros cadastrados é R$ {precoTotal} e a média de páginas por livro são {mediaPaginas}.");
    }
}