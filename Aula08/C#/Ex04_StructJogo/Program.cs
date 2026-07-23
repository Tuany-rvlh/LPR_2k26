/*
 * Enunciado:
 * Desenvolva um programa em C# que simule um sistema de seleção de heróis da Marvel.
 * O programa deve permitir o cadastro de até cinco heróis, armazenando em um STRUCT
 * o nome, o poder e a pontuação de cada um. Em seguida, o usuário poderá selecionar
 * três heróis para formar uma equipe.
 *
 * O sistema deverá calcular a pontuação total da equipe somando a pontuação dos
 * heróis escolhidos e exibir as informações da equipe formada, incluindo o nome,
 * poder de cada integrante e a pontuação total.
 *
 * O programa deve possuir um menu interativo com as opções de cadastrar heróis,
 * selecionar a equipe, exibir a equipe e encerrar a execução, permanecendo em
 * funcionamento até que o usuário escolha sair.
 *
 * Requisitos:
 * - Utilizar STRUCTS para armazenar os dados dos heróis e da equipe.
 * - Não utilizar classes ou listas.
 * - É permitido utilizar vetores.
 */

using System;

class Program
{
    //Struct com as características do herói
    public struct Heroi
    {
        public string Nome;
        public string Poder;
        public int Pontuacao;
    }

    //Struct com as características da equipe
    public struct Equipe
    {
        public Heroi[] Integrantes;
        public int PontuacaoTotal;
    }

    //Função para exibir o menu principal
    static void menuPrincipal()
    {
        Console.WriteLine("=== Sistema de Seleção de Heróis da Marvel ===");
        Console.WriteLine("1. Cadastrar Herói");
        Console.WriteLine("2. Selecionar Equipe");
        Console.WriteLine("3. Pontuação Total da Equipe");
        Console.WriteLine("4. Exibir Equipe");
        Console.WriteLine("5. Sair");
        Console.WriteLine("===============================================");
        Console.WriteLine();
    }

    // Função para cadastrar heróis
    static void CadastrarHeroi(Heroi[] herois, ref int i)
    {
        // Verifica se o limite de heróis cadastrados foi atingido
        if( i >= herois.Length)
        {
            Console.WriteLine("Limite de heróis cadastrados atingido.");
            return;
        }

        string resposta; // Var para ver se o usuário deseja cadastrar outro herói

        do // Loop para cadastrar heróis
        {
            Console.Write($"Digite o nome do herói {i + 1}: ");
            herois[i].Nome = Console.ReadLine() ?? "Não informado";

            Console.Write($"Digite o poder do herói {i + 1}: ");
            herois[i].Poder = Console.ReadLine() ?? "Não informado";

            Console.Write($"Digite a pontuação do herói {i + 1}: ");

            while (!int.TryParse(Console.ReadLine(), out herois[i].Pontuacao))
            {
                Console.Write("Valor inválido! Digite um número: ");
            }

            Console.WriteLine($"Herói {i + 1} cadastrado com sucesso!");
            Console.WriteLine();
            i++;

            Console.Write("Deseja cadastrar outro herói? (s/n): ");
            resposta = Console.ReadLine() ?? "n";


        } while (resposta == "s" && i < herois.Length);
        
    }

    // Função para selecionar a equipe de heróis
    static void SelecionarEquipe(Heroi[] herois, ref Equipe equipeMarvel, ref int i)
    {
        //Verifica se há heróis cadastrados
        if (i == 0)
        {
            Console.WriteLine("Nenhum herói cadastrado. Cadastre heróis antes de selecionar a equipe.");
            return;
        }
        else
        {
            Console.WriteLine("Selecione 3 heróis para formar a equipe:");
            Console.WriteLine("Suas opções são:");
            
            //Mostra os heróis cadastrados
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"{j + 1} - {herois[j].Nome}");
            }

        int count = 0; // Controla quantos heróis já foram selecionados

            while (count < 3)
            {
                Console.Write($"Digite o número do herói {count + 1}: ");

                if (int.TryParse(Console.ReadLine(), out int escolha))
                {
                    if (escolha >= 1 && escolha <= i)
                    {
                        bool jaSelecionado = false;

                        // Verifica se o herói já foi escolhido anteriormente
                        for (int j = 0; j < count; j++)
                        {
                            if (equipeMarvel.Integrantes[j].Nome == herois[escolha - 1].Nome)
                            {
                                jaSelecionado = true;
                            }
                        }

                        if (jaSelecionado)
                        {
                            Console.WriteLine("Você já selecionou esse herói. Escolha outro.");
                        }
                        else
                        {
                            // Armazena o herói escolhido dentro da equipe
                            equipeMarvel.Integrantes[count] = herois[escolha - 1];
                            count++;

                            Console.WriteLine("Herói adicionado à equipe!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida! Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite um número.");
                }
            }

            Console.WriteLine("Equipe formada com sucesso!");
        } 
    }  

    // Função para calcular a pontuação total da equipe
    static int CalcularPontuacaoTotal(ref Equipe equipeMarvel)
    {
        equipeMarvel.PontuacaoTotal = 0;

        for (int i = 0; i < equipeMarvel.Integrantes.Length; i++)
        {
            equipeMarvel.PontuacaoTotal += equipeMarvel.Integrantes[i].Pontuacao;
        }

        return equipeMarvel.PontuacaoTotal;
    }

    // Função para exibir a equipe selecionada
    static void ExibirEquipe(Equipe equipeMarvel)
    {
        Console.WriteLine("Equipe selecionada:");
        Console.WriteLine();

        for (int i = 0; i < equipeMarvel.Integrantes.Length; i++)
        {
            Console.WriteLine($"Herói {i + 1}:");
            Console.WriteLine($"Nome: {equipeMarvel.Integrantes[i].Nome}");
            Console.WriteLine($"Poder: {equipeMarvel.Integrantes[i].Poder}");
            Console.WriteLine($"Pontuação: {equipeMarvel.Integrantes[i].Pontuacao}");
            Console.WriteLine();

            Console.WriteLine($"Pontuação total da equipe: {equipeMarvel.PontuacaoTotal}");
        }
    }

    static void Main()
    {
        // Vetor para armazenar os heróis cadastrados
        Heroi[] herois = new Heroi[5];

        // Variável para controlar o índice do vetor
        int i = 0;

        // Variável para armazenar a opção do menu
        string opcao;

        // Struct para armazenar a equipe
        Equipe equipeMarvel = new Equipe();
        equipeMarvel.Integrantes = new Heroi[3];

        // Estrutura de decisão para as opções do menu
        do
        {
            // Menu principal mostrado
            menuPrincipal();

            // Solicitação do que o usuário quer fazer
            Console.Write("Digite a opção desejada: ");
            opcao = Console.ReadLine() ?? "5";

            switch (opcao)
            {
                case "1":
                    CadastrarHeroi(herois, ref i);
                    break;

                case "2":
                    SelecionarEquipe(herois, ref equipeMarvel, ref i);
                    break;

                case "3":
                    int pontuacaoTotal = CalcularPontuacaoTotal(ref equipeMarvel);
                    Console.WriteLine($"Pontuação total da equipe: {pontuacaoTotal}");
                    break;

                case "4":
                    ExibirEquipe(equipeMarvel);
                    break;

                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != "5");
    }
}