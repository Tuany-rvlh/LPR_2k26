/*
 * Enunciado:
 * Desenvolva um programa que simule um sistema de controle de chamados
 * de uma empresa.
 *
 * O programa deve permitir o cadastro de até dez chamados, armazenando em uma
 * STRUCT as informações de cada chamado, como número, solicitante, setor,
 * prioridade, status e descrição.
 *
 * Ao cadastrar um chamado, o status inicial deve ser definido automaticamente
 * como "Aberto". O usuário poderá listar todos os chamados cadastrados, atualizar
 * o status de um chamado específico e visualizar estatísticas sobre a quantidade
 * de chamados em cada situação.
 *
 * O programa deve possuir um menu interativo com as opções de cadastrar chamados,
 * listar chamados, atualizar status, classificar prioridade e exibir estatísticas,
 * permanecendo em execução até que o usuário escolha sair.
 *
 * Requisitos:
 * - Utilizar STRUCTS para armazenar os dados dos chamados.
 * - Não utilizar classes ou listas.
 * - É permitido utilizar vetores.
 */

using System;

class Program
{
    // Struct com as características do chamado
    public struct Chamado
    {
        public int Numero;
        public string Solicitante;
        public string Setor;
        public int Prioridade;
        public string Status;
        public string Descricao;
    }


    // Função para exibir o menu principal
    static void menuPrincipal()
    {
        Console.WriteLine("=== Sistema de Controle de Chamados ===");
        Console.WriteLine("1. Cadastrar Chamado");
        Console.WriteLine("2. Listar Chamados");
        Console.WriteLine("3. Atualizar Status");
        Console.WriteLine("4. Classificar Prioridade");
        Console.WriteLine("5. Exibir Estatísticas");
        Console.WriteLine("6. Sair");
        Console.WriteLine("=======================================");
        Console.WriteLine();
    }


    // Função para cadastrar chamados
    static void cadastrarChamado(Chamado[] chamados, ref int i)
    {
        // Verifica se o limite de chamados foi atingido
        if (i >= chamados.Length)
        {
            Console.WriteLine("Limite de chamados cadastrados atingido.");
            return;
        }


        Console.Write("Digite o número do chamado: ");
        chamados[i].Numero = int.Parse(Console.ReadLine() ?? "0");


        Console.Write("Digite o solicitante: ");
        chamados[i].Solicitante = Console.ReadLine() ?? "Não informado";


        Console.Write("Digite o setor: ");
        chamados[i].Setor = Console.ReadLine() ?? "Não informado";


        Console.Write("Digite a prioridade (1 - Baixa, 2 - Média, 3 - Alta): ");
        chamados[i].Prioridade = int.Parse(Console.ReadLine() ?? "1");


        Console.Write("Digite a descrição: ");
        chamados[i].Descricao = Console.ReadLine() ?? "Não informado";


        // Todo chamado começa como aberto
        chamados[i].Status = "Aberto";


        Console.WriteLine("Chamado cadastrado com sucesso!");
        Console.WriteLine();


        i++;
    }


    // Função para listar chamados cadastrados
    static void listarChamados(Chamado[] chamados, int quantidade)
    {
        if (quantidade == 0)
        {
            Console.WriteLine("Nenhum chamado cadastrado.");
            return;
        }


        Console.WriteLine("=== Chamados Cadastrados ===");


        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Chamado {i + 1}:");
            Console.WriteLine($"Número: {chamados[i].Numero}");
            Console.WriteLine($"Solicitante: {chamados[i].Solicitante}");
            Console.WriteLine($"Setor: {chamados[i].Setor}");
            Console.WriteLine($"Prioridade: {classificarPrioridade(chamados[i].Prioridade)}");
            Console.WriteLine($"Status: {chamados[i].Status}");
            Console.WriteLine($"Descrição: {chamados[i].Descricao}");
            Console.WriteLine();
        }
    }


    // Função para atualizar o status do chamado
    static void atualizarStatus(Chamado[] chamados, int quantidade)
    {
        Console.Write("Digite o número do chamado: ");
        int numero = int.Parse(Console.ReadLine() ?? "0");


        for (int i = 0; i < quantidade; i++)
        {
            if (chamados[i].Numero == numero)
            {
                Console.WriteLine("Escolha o novo status:");
                Console.WriteLine("1. Em andamento");
                Console.WriteLine("2. Resolvido");
                Console.WriteLine("3. Cancelado");


                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine() ?? "1");


                switch (opcao)
                {
                    case 1:
                        chamados[i].Status = "Em andamento";
                        break;

                    case 2:
                        chamados[i].Status = "Resolvido";
                        break;

                    case 3:
                        chamados[i].Status = "Cancelado";
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        return;
                }


                Console.WriteLine("Status atualizado com sucesso!");
                return;
            }
        }


        Console.WriteLine("Chamado não encontrado.");
    }


    // Função para classificar prioridade
    static string classificarPrioridade(int prioridade)
    {
        if (prioridade == 1)
        {
            return "Baixa";
        }
        else if (prioridade == 2)
        {
            return "Média";
        }
        else if (prioridade == 3)
        {
            return "Alta";
        }
        else
        {
            return "Inválida";
        }
    }


    // Função para exibir estatísticas
    static void estatisticas(Chamado[] chamados, int quantidade)
    {
        int abertos = 0;
        int andamento = 0;
        int resolvidos = 0;
        int cancelados = 0;


        for (int i = 0; i < quantidade; i++)
        {
            if (chamados[i].Status == "Aberto")
            {
                abertos++;
            }
            else if (chamados[i].Status == "Em andamento")
            {
                andamento++;
            }
            else if (chamados[i].Status == "Resolvido")
            {
                resolvidos++;
            }
            else if (chamados[i].Status == "Cancelado")
            {
                cancelados++;
            }
        }


        Console.WriteLine("=== Estatísticas ===");
        Console.WriteLine($"Chamados abertos: {abertos}");
        Console.WriteLine($"Chamados em andamento: {andamento}");
        Console.WriteLine($"Chamados resolvidos: {resolvidos}");
        Console.WriteLine($"Chamados cancelados: {cancelados}");
    }


    static void Main()
    {
        // Vetor para armazenar os chamados cadastrados
        Chamado[] chamados = new Chamado[10];


        // Variável para controlar a quantidade de chamados
        int quantidade = 0;


        string opcao;


        do
        {
            menuPrincipal();


            Console.Write("Digite a opção desejada: ");
            opcao = Console.ReadLine() ?? "6";


            switch (opcao)
            {
                case "1":
                    cadastrarChamado(chamados, ref quantidade);
                    break;


                case "2":
                    listarChamados(chamados, quantidade);
                    break;


                case "3":
                    atualizarStatus(chamados, quantidade);
                    break;


                case "4":
                    Console.Write("Digite a prioridade (1 a 3): ");
                    int prioridade = int.Parse(Console.ReadLine() ?? "1");

                    Console.WriteLine($"Prioridade: {classificarPrioridade(prioridade)}");
                    break;


                case "5":
                    estatisticas(chamados, quantidade);
                    break;


                case "6":
                    Console.WriteLine("Encerrando o programa...");
                    return;


                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }


        } while (opcao != "6");
    }
}