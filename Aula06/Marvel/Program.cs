using System;

namespace Marvel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nBem-vindo ao sistema de seleção de heróis da Marvel para uma equipe!");
            int opcao = 0, opcao1 = 0, opcao2 = 0, opcao3 = 0, contCadastro = 0, ValorPonto1 = 0 , ValorPonto2 = 0, ValorPonto3 = 0, ValorPonto4 = 0, ValorPonto5 = 0;
            bool Continuar = false; 
            string nome1 = "", nome2 = "", nome3 = "", nome4 = "", nome5 = "", poder1 = "", poder2 = "", poder3 = "", poder4 = "", poder5 = "";
            
            do{
                Console.WriteLine("==========================================================================");
                Menu(ref opcao);
                Console.WriteLine("\n==========================================================================");
                switch (opcao)
                {
                    case 1:
                        cadastrarHeroi(ref Continuar, ref contCadastro, ref ValorPonto1, ref ValorPonto2, ref ValorPonto3, ref ValorPonto4, 
                        ref ValorPonto5, ref poder1, ref poder2, ref poder3, ref poder4, ref poder5, ref nome1, ref nome2, ref nome3, ref nome4, ref nome5);
                        break;
                    case 2:
                        selecionarEquipe(ref opcao1, ref opcao2, ref opcao3, ref contCadastro, ref ValorPonto1, ref ValorPonto2, ref ValorPonto3, ref ValorPonto4, 
                        ref ValorPonto5, ref poder1, ref poder2, ref poder3, ref poder4, ref poder5, ref nome1, ref nome2, ref nome3, ref nome4, ref nome5);
                        break;
                    case 3:
                        calcularPontuacaoTotal(ref opcao1, ref opcao2, ref opcao3, ref ValorPonto1, ref ValorPonto2, ref ValorPonto3, ref ValorPonto4, ref ValorPonto5);
                        break;
                    case 4:
                        exibirEquipe(ref opcao1, ref opcao2, ref opcao3, ref contCadastro, ref ValorPonto1, ref ValorPonto2, ref ValorPonto3, ref ValorPonto4, ref ValorPonto5,
                        ref poder1, ref poder2, ref poder3, ref poder4, ref poder5, ref nome1, ref nome2, ref nome3, ref nome4, ref nome5);
                        break;
                    case 5:
                        Console.WriteLine("Obrigado por usar o sistema de seleção de heróis da Marvel! Volte sempre!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Por favor, selecione uma opção válida.");
                        break;
                }
            } while (opcao != 5);
        }

         static void Menu(ref int opcao)
        {
            Console.WriteLine("\nMenu de opções: ");
            Console.WriteLine("1 - Cadastrar herói;");
            Console.WriteLine("2 - Seleção de equipe;");
            Console.WriteLine("3 - Pontuação total da equipe;");
            Console.WriteLine("4 - Exibição da equipe selecionada;");
            Console.WriteLine("5 - Sair do programa. ");

            Console.Write("\nDigite o número da opção desejada: ");
            string escolha = Console.ReadLine() ?? "";
            if (int.TryParse(escolha, out int escolhaSelecionada))
            {
                opcao = escolhaSelecionada;
                return;   
            }
        }
        static void ContinuarCadastro(ref bool Continuar, ref int contCadastro)
        {
            Console.Write("\nDeseja cadastrar outro herói? (S/N): ");
            string resposta = Console.ReadLine()?.ToUpper() ?? "";

            if(resposta == "S" || resposta == "SIM")
            {
                Console.WriteLine("\nVamos cadastrar outro herói!");
                Continuar = true;
            }
            else if(resposta == "N" || resposta == "NÃO" || resposta == "NAO")
            {
                Console.WriteLine($"\nCadastro finalizado! Você cadastrou {contCadastro} heróis.");
                Continuar = false;
            }
            else
            {
                Console.WriteLine($"\nResposta inválida! O cadastro será finalizado e você cadastrou {contCadastro} heróis.");
                Continuar = false;
            }
        }
        static void cadastrarHeroi(ref bool Continuar, ref int contCadastro, ref int ValorPonto1, ref int ValorPonto2, ref int ValorPonto3, ref int ValorPonto4, ref int ValorPonto5, 
        ref string poder1, ref string poder2, ref string poder3, ref string poder4, ref string poder5, ref string nome1, ref string nome2, ref string nome3, ref string nome4, ref string nome5)
        {
            Console.WriteLine("\nVocê pode cadastrar até 5 heróis!");

            while (contCadastro < 5)
            {
                Console.WriteLine($"\nCadastro do herói {contCadastro + 1}: ");

                Console.Write("Digite o nome do herói: ");
                string nome = Console.ReadLine() ?? "";

                Console.Write("Digite o poder do herói: ");
                string poder = Console.ReadLine() ?? "";

                Console.Write("Digite o valor do ponto do herói: ");
                string entrada = Console.ReadLine() ?? "";

                if (!int.TryParse(entrada, out int valor))
                {
                    Console.WriteLine("\nEntrada inválida!");
                    continue;
                }

                if (contCadastro == 0)
                {
                    nome1 = nome;
                    poder1 = poder;
                    ValorPonto1 = valor;
                }
                else if (contCadastro == 1)
                {
                    nome2 = nome;
                    poder2 = poder;
                    ValorPonto2 = valor;
                }
                else if (contCadastro == 2)
                {
                    nome3 = nome;
                    poder3 = poder;
                    ValorPonto3 = valor;
                }
                else if (contCadastro == 3)
                {
                    nome4 = nome;
                    poder4 = poder;
                    ValorPonto4 = valor;
                }
                else if (contCadastro == 4)
                {
                    nome5 = nome;
                    poder5 = poder;
                    ValorPonto5 = valor;
                }
                Console.WriteLine("\n==========================================================================");
                Console.WriteLine("\nCadastro realizado com sucesso!");
                contCadastro++;

                if (contCadastro == 5)
                {
                    Console.WriteLine("\nLimite de heróis atingido! Escolha outras opções no Menu!");
                    break;
                }

                ContinuarCadastro(ref Continuar, ref contCadastro);
                if (!Continuar)
                    break;
                Console.WriteLine("\n==========================================================================");
            }
        }
        static void selecionarEquipe(ref int opcao1, ref int opcao2, ref int opcao3, ref int contCadastro, ref int ValorPonto1, ref int ValorPonto2, ref int ValorPonto3, ref int ValorPonto4, 
        ref int ValorPonto5, ref string poder1, ref string poder2, ref string poder3, ref string poder4, ref string poder5, ref string nome1, ref string nome2, ref string nome3, ref string nome4, ref string nome5)
        {
            if(contCadastro < 3)
            {
                Console.WriteLine($"\nVocê precisa cadastrar pelo menos 3 heróis para formar uma equipe! Você cadastrou {contCadastro} heróis.");
                return;
            }
            Console.WriteLine("\nVocê pode selecionar 3 heróis para formar sua equipe!");
            if (nome1 != "")
                Console.WriteLine($"OPÇÃO 1: {nome1} -> Poder: {poder1} - Pontuação: {ValorPonto1}");
            if (nome2 != "")
                Console.WriteLine($"OPÇÃO 2: {nome2} -> Poder: {poder2} - Pontuação: {ValorPonto2}");
            if (nome3 != "")
                Console.WriteLine($"OPÇÃO 3: {nome3} -> Poder: {poder3} - Pontuação: {ValorPonto3}");
            if (nome4 != "")
                Console.WriteLine($"OPÇÃO 4: {nome4} -> Poder: {poder4} - Pontuação: {ValorPonto4}");
            if (nome5 != "")
                Console.WriteLine($"OPÇÃO 5: {nome5} -> Poder: {poder5} - Pontuação: {ValorPonto5}");

            int contOpValida = 0;
            while (contOpValida < 3)
            {
                Console.Write($"\nEscolha os heróis dessas opções para sua equipe (1-{contCadastro}): ");
                string heroi = Console.ReadLine() ?? "";

                if (!int.TryParse(heroi, out int escolhaSelecionada))
                {
                    Console.WriteLine("\nEntrada inválida!");
                    continue;
                }

                if(escolhaSelecionada > contCadastro)
                {
                    Console.WriteLine("\nSua opção não existe nesse sistema, tente novamente!");
                }
                else
                {
                    contOpValida++;
                    if (contOpValida == 1)
                        opcao1 = escolhaSelecionada;
                    else if (contOpValida == 2 && escolhaSelecionada == opcao1)
                    {
                        contOpValida--;
                        Console.WriteLine("\nVocê já selecionou esse herói! Selecione novamente.");
                    }
                    else if (contOpValida == 2 && escolhaSelecionada != opcao1 )
                        opcao2 = escolhaSelecionada;
                    else if (contOpValida == 3 && (escolhaSelecionada == opcao1 || escolhaSelecionada == opcao2))
                    {
                        contOpValida--;
                        Console.WriteLine("\nVocê já selecionou esse herói! Selecione novamente.");
                    }
                    else if (contOpValida == 3)
                    {
                        opcao3 = escolhaSelecionada;
                        Console.WriteLine("\nVocê selecionou os heróis, parabéns!");  
                    }
                }
            }
        }
        static void calcularPontuacaoTotal(ref int opcao1, ref int opcao2, ref int opcao3, ref int ValorPonto1, ref int ValorPonto2, ref int ValorPonto3, ref int ValorPonto4, ref int ValorPonto5)
        {
            int pontuacaoTotal = 0;
                if (opcao1 == 1 || opcao2 == 1 || opcao3 == 1)
                    pontuacaoTotal += ValorPonto1;
                if (opcao1 == 2 || opcao2 == 2 || opcao3 == 2)
                    pontuacaoTotal += ValorPonto2;
                if (opcao1 == 3 || opcao2 == 3 || opcao3 == 3)
                    pontuacaoTotal += ValorPonto3;
                if (opcao1 == 4 || opcao2 == 4 || opcao3 == 4)
                    pontuacaoTotal += ValorPonto4;
                if (opcao1 == 5 || opcao2 == 5 || opcao3 == 5)
                    pontuacaoTotal += ValorPonto5;
            Console.WriteLine($"\nA pontuação total da equipe é: {pontuacaoTotal}\n");
        }
         static void exibirEquipe(ref int opcao1, ref int opcao2, ref int opcao3, ref int contCadastro, ref int ValorPonto1, ref int ValorPonto2, ref int ValorPonto3, ref int ValorPonto4, ref int ValorPonto5, ref string poder1, ref string poder2, ref string poder3, ref string poder4, ref string poder5, ref string nome1, ref string nome2, ref string nome3, ref string nome4, ref string nome5)
        {
            Console.WriteLine("\nEquipe selecionada:");
            if (contCadastro == 0)
            Console.WriteLine($"\nNenhum herói cadastrado! Você precisa cadastrar pelo menos 3 heróis para formar uma equipe! Você cadastrou {contCadastro} heróis.");
            if (opcao1 == 1 || opcao2 == 1 || opcao3 == 1)
                Console.WriteLine($"Herói selecionado: {nome1} -> Poder: {poder1} / Pontuação: {ValorPonto1}");
            if (opcao1 == 2 || opcao2 == 2 || opcao3 == 2)
                Console.WriteLine($"Herói selecionado: {nome2} -> Poder: {poder2} / Pontuação: {ValorPonto2}");
            if (opcao1 == 3 || opcao2 == 3 || opcao3 == 3)
                Console.WriteLine($"Herói selecionado: {nome3} -> Poder: {poder3} / Pontuação: {ValorPonto3}");
            if (opcao1 == 4 || opcao2 == 4 || opcao3 == 4)
                Console.WriteLine($"Herói selecionado: {nome4} -> Poder: {poder4} / Pontuação: {ValorPonto4}");
            if (opcao1 == 5 || opcao2 == 5 || opcao3 == 5)
                Console.WriteLine($"Herói selecionado: {nome5} -> Poder: {poder5} / Pontuação: {ValorPonto5}");
        }
    }
}