/*
 * Enunciado:
 * Desenvolva um programa em C++ que simule um sistema de seleção
 * de heróis da Marvel para uma equipe.
 *
 * O programa deve permitir:
 * - Cadastro de até 5 heróis;
 * - Seleção de 3 heróis para uma equipe;
 * - Cálculo da pontuação total;
 * - Exibição da equipe selecionada.
 *
 * Não utilizar classes, vetores ou listas.
 */


// Bibliotecas utilizadas
#include <iostream>
#include <clocale>
#include <string>

using namespace std;


// Exibe o menu principal
void menuPrincipal(int &opcao)
{
    cout << endl;
    cout << "==============================" << endl;
    cout << "       MENU PRINCIPAL" << endl;
    cout << "==============================" << endl;

    cout << "1 - Cadastrar herói" << endl;
    cout << "2 - Selecionar equipe" << endl;
    cout << "3 - Calcular pontuação da equipe" << endl;
    cout << "4 - Exibir equipe" << endl;
    cout << "5 - Sair" << endl;

    cout << "\nEscolha uma opção: ";
    cin >> opcao;
}



// Cadastra os heróis
void cadastrarHeroi(
    int &quantidade,
    string &nome1, string &nome2, string &nome3, string &nome4, string &nome5,
    string &poder1, string &poder2, string &poder3, string &poder4, string &poder5,
    int &ponto1, int &ponto2, int &ponto3, int &ponto4, int &ponto5)
{

    if (quantidade >= 5)
    {
        cout << "Limite máximo de heróis atingido!" << endl;
        return;
    }


    string nome;
    string poder;
    int ponto;


    cout << "\nDigite o nome do herói: ";
    cin.ignore();
    getline(cin, nome);


    cout << "Digite o poder do herói: ";
    getline(cin, poder);


    cout << "Digite a pontuação do herói: ";
    cin >> ponto;



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

    cout << "Herói cadastrado com sucesso!" << endl;

}



// Seleciona os heróis da equipe
void selecionarEquipe(
    int quantidade,
    int &escolha1, int &escolha2, int &escolha3,
    string nome1, string nome2, string nome3, string nome4, string nome5,
    string poder1, string poder2, string poder3, string poder4, string poder5,
    int ponto1, int ponto2, int ponto3, int ponto4, int ponto5)
{

    if (quantidade < 3)
    {
        cout << "Cadastre pelo menos 3 heróis antes!" << endl;
        return;
    }


    cout << "\nHeróis disponíveis:" << endl;

    cout << "1 - " << nome1 << " | Poder: " << poder1 << " | Pontos: " << ponto1 << endl;
    cout << "2 - " << nome2 << " | Poder: " << poder2 << " | Pontos: " << ponto2 << endl;
    cout << "3 - " << nome3 << " | Poder: " << poder3 << " | Pontos: " << ponto3 << endl;
    cout << "4 - " << nome4 << " | Poder: " << poder4 << " | Pontos: " << ponto4 << endl;
    cout << "5 - " << nome5 << " | Poder: " << poder5 << " | Pontos: " << ponto5 << endl;


    cout << "\nEscolha o primeiro herói: ";
    cin >> escolha1;

    cout << "Escolha o segundo herói: ";
    cin >> escolha2;

    cout << "Escolha o terceiro herói: ";
    cin >> escolha3;


    cout << "Equipe selecionada!" << endl;

}



// Calcula a pontuação total da equipe
int calcularPontuacaoTotal(
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



// Exibe a equipe selecionada
void exibirEquipe(
    int escolha1, int escolha2, int escolha3,
    string nome1, string nome2, string nome3, string nome4, string nome5,
    string poder1, string poder2, string poder3, string poder4, string poder5,
    int ponto1, int ponto2, int ponto3, int ponto4, int ponto5)
{

    cout << "\nEquipe selecionada:" << endl;


    if (escolha1 == 1 || escolha2 == 1 || escolha3 == 1)
        cout << nome1 << " - " << poder1 << " - " << ponto1 << " pontos" << endl;


    if (escolha1 == 2 || escolha2 == 2 || escolha3 == 2)
        cout << nome2 << " - " << poder2 << " - " << ponto2 << " pontos" << endl;


    if (escolha1 == 3 || escolha2 == 3 || escolha3 == 3)
        cout << nome3 << " - " << poder3 << " - " << ponto3 << " pontos" << endl;


    if (escolha1 == 4 || escolha2 == 4 || escolha3 == 4)
        cout << nome4 << " - " << poder4 << " - " << ponto4 << " pontos" << endl;


    if (escolha1 == 5 || escolha2 == 5 || escolha3 == 5)
        cout << nome5 << " - " << poder5 << " - " << ponto5 << " pontos" << endl;

}



// Programa principal
int main()
{

    setlocale(LC_ALL, "pt_BR.UTF-8");


    int opcao = 0;
    int quantidade = 0;


    int escolha1 = 0;
    int escolha2 = 0;
    int escolha3 = 0;


    string nome1 = "", nome2 = "", nome3 = "", nome4 = "", nome5 = "";

    string poder1 = "", poder2 = "", poder3 = "", poder4 = "", poder5 = "";


    int ponto1 = 0, ponto2 = 0, ponto3 = 0, ponto4 = 0, ponto5 = 0;



    do
    {

        menuPrincipal(opcao);


        switch(opcao)
        {

            case 1:

                cadastrarHeroi(
                    quantidade,
                    nome1, nome2, nome3, nome4, nome5,
                    poder1, poder2, poder3, poder4, poder5,
                    ponto1, ponto2, ponto3, ponto4, ponto5
                );

                break;



            case 2:

                selecionarEquipe(
                    quantidade,
                    escolha1, escolha2, escolha3,
                    nome1, nome2, nome3, nome4, nome5,
                    poder1, poder2, poder3, poder4, poder5,
                    ponto1, ponto2, ponto3, ponto4, ponto5
                );

                break;



            case 3:

                cout << "Pontuação total: "
                     << calcularPontuacaoTotal(
                        escolha1, escolha2, escolha3,
                        ponto1, ponto2, ponto3, ponto4, ponto5
                     )
                     << endl;

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

                cout << "Encerrando programa..." << endl;

                break;



            default:

                cout << "Opção inválida!" << endl;

        }


    } while(opcao != 5);

}