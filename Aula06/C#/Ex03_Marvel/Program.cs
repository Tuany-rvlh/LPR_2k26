/*
 * Enunciado:
 * Desenvolva um programa em C# que simule um sistema de seleção de heróis
 * da Marvel para uma equipe.
 *
 * O programa deve permitir:
 * - Cadastro de até 5 heróis;
 * - Seleção de 3 heróis para uma equipe;
 * - Cálculo da pontuação total;
 * - Exibição da equipe selecionada.
 *
 * Não utilizar classes, vetores ou listas.
 */

using System;


namespace Marvel
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao sistema de seleção de heróis da Marvel!");

            int opcao = 0;
            int quantidadeHerois = 0;

            int escolha1 = 0;
            int escolha2 = 0;
            int escolha3 = 0;


            string nome1 = "";
            string nome2 = "";
            string nome3 = "";
            string nome4 = "";
            string nome5 = "";

            string poder1 = "";
            string poder2 = "";
            string poder3 = "";
            string poder4 = "";
            string poder5 = "";


            int ponto1 = 0;
            int ponto2 = 0;
            int ponto3 = 0;
            int ponto4 = 0;
            int ponto5 = 0;


            do
            {
                menuPrincipal(ref opcao);


                switch (opcao)
                {

                    case 1:

                        cadastrarHeroi(
                            ref quantidadeHerois,
                            ref nome1, ref nome2, ref nome3, ref nome4, ref nome5,
                            ref poder1, ref poder2, ref poder3, ref poder4, ref poder5,
                            ref ponto1, ref ponto2, ref ponto3, ref ponto4, ref ponto5
                        );

                        break;



                    case 2:

                        selecionarEquipe(
                            quantidadeHerois,
                            ref escolha1, ref escolha2, ref escolha3,
                            nome1, nome2, nome3, nome4, nome5,
                            poder1, poder2, poder3, poder4, poder5,
                            ponto1, ponto2, ponto3, ponto4, ponto5
                        );

                        break;



                    case 3:

                        int total = calcularPontuacaoTotal(
                            escolha1, escolha2, escolha3,
                            ponto1, ponto2, ponto3, ponto4, ponto5
                        );


                        Console.WriteLine($"\nPontuação total da equipe: {total}");

                        break;



                    case 4:

                        exibirEquipe(
                            escolha1, escolha2, escolha3,
                            nome1, nome2, nome3, nome4, nome5,
                            poder1, poder2, poder3, poder4, poder5,
                            ponto1, ponto2, ponto3, ponto4, ponto5
                        );

                        break;



                    case 5:

                        Console.WriteLine("Obrigado por utilizar o sistema!");

                        break;



                    default:

                        Console.WriteLine("Opção inválida!");

                        break;
                }


            } while (opcao != 5);

        }



        static void menuPrincipal(ref int opcao)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("==============================");

            Console.WriteLine("1 - Cadastrar herói");
            Console.WriteLine("2 - Selecionar equipe");
            Console.WriteLine("3 - Calcular pontuação");
            Console.WriteLine("4 - Exibir equipe");
            Console.WriteLine("5 - Sair");


            Console.Write("\nEscolha uma opção: ");

            int.TryParse(Console.ReadLine(), out opcao);
        }



        static void cadastrarHeroi(
            ref int quantidade,
            ref string nome1, ref string nome2, ref string nome3, ref string nome4, ref string nome5,
            ref string poder1, ref string poder2, ref string poder3, ref string poder4, ref string poder5,
            ref int ponto1, ref int ponto2, ref int ponto3, ref int ponto4, ref int ponto5)
        {


            if (quantidade >= 5)
            {
                Console.WriteLine("Limite máximo de heróis atingido!");

                return;
            }


            Console.Write("\nNome do herói: ");
            string nome = Console.ReadLine() ?? "";


            Console.Write("Poder do herói: ");
            string poder = Console.ReadLine() ?? "";


            Console.Write("Pontuação do herói: ");
            int.TryParse(Console.ReadLine(), out int ponto);



            if (quantidade == 0)
            {
                nome1 = nome;
                poder1 = poder;
                ponto1 = ponto;
            }

            else if (quantidade == 1)
            {
                nome2 = nome;
                poder2 = poder;
                ponto2 = ponto;
            }

            else if (quantidade == 2)
            {
                nome3 = nome;
                poder3 = poder;
                ponto3 = ponto;
            }

            else if (quantidade == 3)
            {
                nome4 = nome;
                poder4 = poder;
                ponto4 = ponto;
            }

            else
            {
                nome5 = nome;
                poder5 = poder;
                ponto5 = ponto;
            }


            quantidade++;


            Console.WriteLine("Herói cadastrado com sucesso!");

        }




        static void selecionarEquipe(
            int quantidade,
            ref int escolha1, ref int escolha2, ref int escolha3,
            string nome1, string nome2, string nome3, string nome4, string nome5,
            string poder1, string poder2, string poder3, string poder4, string poder5,
            int ponto1, int ponto2, int ponto3, int ponto4, int ponto5)
        {


            if (quantidade < 3)
            {
                Console.WriteLine("Cadastre pelo menos 3 heróis!");

                return;
            }


            Console.WriteLine("\nHeróis disponíveis:");

            Console.WriteLine($"1 - {nome1} | {poder1} | {ponto1} pontos");
            Console.WriteLine($"2 - {nome2} | {poder2} | {ponto2} pontos");
            Console.WriteLine($"3 - {nome3} | {poder3} | {ponto3} pontos");
            Console.WriteLine($"4 - {nome4} | {poder4} | {ponto4} pontos");
            Console.WriteLine($"5 - {nome5} | {poder5} | {ponto5} pontos");



            Console.Write("\nEscolha o primeiro herói: ");
            escolha1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Escolha o segundo herói: ");
            escolha2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Escolha o terceiro herói: ");
            escolha3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Equipe selecionada!");

        }





        static int calcularPontuacaoTotal(
            int escolha1, int escolha2, int escolha3,
            int ponto1, int ponto2, int ponto3, int ponto4, int ponto5)
        {

            int total = 0;


            if (escolha1 == 1 || escolha2 == 1 || escolha3 == 1)
                total += ponto1;

            if (escolha1 == 2 || escolha2 == 2 || escolha3 == 2)
                total += ponto2;

            if (escolha1 == 3 || escolha2 == 3 || escolha3 == 3)
                total += ponto3;

            if (escolha1 == 4 || escolha2 == 4 || escolha3 == 4)
                total += ponto4;

            if (escolha1 == 5 || escolha2 == 5 || escolha3 == 5)
                total += ponto5;


            return total;

        }





        static void exibirEquipe(
            int escolha1, int escolha2, int escolha3,
            string nome1, string nome2, string nome3, string nome4, string nome5,
            string poder1, string poder2, string poder3, string poder4, string poder5,
            int ponto1, int ponto2, int ponto3, int ponto4, int ponto5)
        {


            Console.WriteLine("\nEquipe selecionada:");

            if (escolha1 == 1 || escolha2 == 1 || escolha3 == 1)
                Console.WriteLine($"{nome1} - {poder1} - {ponto1} pontos");


            if (escolha1 == 2 || escolha2 == 2 || escolha3 == 2)
                Console.WriteLine($"{nome2} - {poder2} - {ponto2} pontos");


            if (escolha1 == 3 || escolha2 == 3 || escolha3 == 3)
                Console.WriteLine($"{nome3} - {poder3} - {ponto3} pontos");


            if (escolha1 == 4 || escolha2 == 4 || escolha3 == 4)
                Console.WriteLine($"{nome4} - {poder4} - {ponto4} pontos");


            if (escolha1 == 5 || escolha2 == 5 || escolha3 == 5)
                Console.WriteLine($"{nome5} - {poder5} - {ponto5} pontos");


            int total = calcularPontuacaoTotal(
                escolha1, escolha2, escolha3,
                ponto1, ponto2, ponto3, ponto4, ponto5
            );


            Console.WriteLine($"\nPontuação total da equipe: {total}");

        }

    }
}