/*
 * Enunciado:
 * Desenvolva um programa em C++ que simule um sistema de seleção de heróis da Marvel.
 * O programa deve permitir o cadastro de até cinco heróis, armazenando em um STRUCT
 * o nome, o poder e a pontuação de cada um. Em seguida, o usuário poderá selecionar
 * três heróis para formar uma equipe.
 *
 * O sistema deverá calcular a pontuação total da equipe somando a pontuação dos
 * heróis escolhidos e exibir as informações da equipe formada, incluindo o nome,
 * poder de cada integrante e a pontuação total.
 *
 * Requisitos:
 * - Utilizar STRUCTS para armazenar os dados dos heróis e da equipe.
 * - Não utilizar classes ou listas.
 * - É permitido utilizar vetores.
 */

#include <iostream>
#include <string>

using namespace std;


// Struct com as características do herói
struct Heroi
{
    string Nome;
    string Poder;
    int Pontuacao;
};


// Struct com as características da equipe
struct Equipe
{
    Heroi Integrantes[3];
    int PontuacaoTotal;
};


// Função para exibir o menu principal
void menuPrincipal()
{
    cout << "=== Sistema de Seleção de Heróis da Marvel ===" << endl;
    cout << "1. Cadastrar Herói" << endl;
    cout << "2. Selecionar Equipe" << endl;
    cout << "3. Pontuação Total da Equipe" << endl;
    cout << "4. Exibir Equipe" << endl;
    cout << "5. Sair" << endl;
    cout << "===============================================" << endl;
    cout << endl;
}


// Função para cadastrar heróis
void CadastrarHeroi(Heroi herois[], int &i)
{
    // Verifica se o limite de heróis cadastrados foi atingido
    if (i >= 5)
    {
        cout << "Limite de heróis cadastrados atingido." << endl;
        return;
    }

    char resposta;

    do
    {
        cout << "Digite o nome do herói " << i + 1 << ": ";
        cin.ignore();
        getline(cin, herois[i].Nome);


        cout << "Digite o poder do herói " << i + 1 << ": ";
        getline(cin, herois[i].Poder);


        cout << "Digite a pontuação do herói " << i + 1 << ": ";
        cin >> herois[i].Pontuacao;


        cout << "Herói " << i + 1 << " cadastrado com sucesso!" << endl;
        cout << endl;

        i++;


        cout << "Deseja cadastrar outro herói? (s/n): ";
        cin >> resposta;


    } while (resposta == 's' && i < 5);

}


// Função para selecionar a equipe de heróis
void SelecionarEquipe(Heroi herois[], Equipe &equipeMarvel, int i)
{
    // Verifica se há heróis cadastrados
    if (i == 0)
    {
        cout << "Nenhum herói cadastrado. Cadastre heróis antes de selecionar a equipe." << endl;
        return;
    }


    cout << "Selecione 3 heróis para formar a equipe:" << endl;
    cout << "Suas opções são:" << endl;


    // Mostra os heróis cadastrados
    for (int j = 0; j < i; j++)
    {
        cout << j + 1 << " - " << herois[j].Nome << endl;
    }


    int count = 0;


    while (count < 3)
    {
        int escolha;

        cout << "Digite o número do herói " << count + 1 << ": ";
        cin >> escolha;


        if (escolha >= 1 && escolha <= i)
        {
            bool jaSelecionado = false;


            // Verifica se o herói já foi escolhido
            for (int j = 0; j < count; j++)
            {
                if (equipeMarvel.Integrantes[j].Nome == herois[escolha - 1].Nome)
                {
                    jaSelecionado = true;
                }
            }


            if (jaSelecionado)
            {
                cout << "Você já selecionou esse herói. Escolha outro." << endl;
            }
            else
            {
                // Armazena o herói escolhido na equipe
                equipeMarvel.Integrantes[count] = herois[escolha - 1];

                count++;

                cout << "Herói adicionado à equipe!" << endl;
            }
        }
        else
        {
            cout << "Opção inválida! Tente novamente." << endl;
        }
    }


    cout << "Equipe formada com sucesso!" << endl;
}


// Função para calcular a pontuação total da equipe
int CalcularPontuacaoTotal(Equipe &equipeMarvel)
{
    equipeMarvel.PontuacaoTotal = 0;


    for (int i = 0; i < 3; i++)
    {
        equipeMarvel.PontuacaoTotal += equipeMarvel.Integrantes[i].Pontuacao;
    }


    return equipeMarvel.PontuacaoTotal;
}


// Função para exibir a equipe selecionada
void ExibirEquipe(Equipe equipeMarvel)
{
    cout << "Equipe selecionada:" << endl;
    cout << endl;


    for (int i = 0; i < 3; i++)
    {
        cout << "Herói " << i + 1 << ":" << endl;
        cout << "Nome: " << equipeMarvel.Integrantes[i].Nome << endl;
        cout << "Poder: " << equipeMarvel.Integrantes[i].Poder << endl;
        cout << "Pontuação: " << equipeMarvel.Integrantes[i].Pontuacao << endl;
        cout << endl;
    }


    cout << "Pontuação total da equipe: "
         << equipeMarvel.PontuacaoTotal << endl;
}



int main()
{
    // Vetor para armazenar os heróis cadastrados
    Heroi herois[5];


    // Variável para controlar o índice do vetor
    int i = 0;


    // Variável para armazenar a opção do menu
    string opcao;


    // Struct para armazenar a equipe
    Equipe equipeMarvel;

    equipeMarvel.PontuacaoTotal = 0;



    do
    {
        menuPrincipal();


        cout << "Digite a opção desejada: ";
        cin >> opcao;


        switch(opcao[0])
        {
            case '1':
                CadastrarHeroi(herois, i);
                break;


            case '2':
                SelecionarEquipe(herois, equipeMarvel, i);
                break;


            case '3':
            {
                int pontuacaoTotal = CalcularPontuacaoTotal(equipeMarvel);

                cout << "Pontuação total da equipe: "
                     << pontuacaoTotal << endl;

                break;
            }


            case '4':
                ExibirEquipe(equipeMarvel);
                break;


            case '5':
                cout << "Encerrando o programa..." << endl;
                break;


            default:
                cout << "Opção inválida. Tente novamente." << endl;
        }


    } while(opcao != "5");

}