/*
 * Enunciado:
 * Um cinema possui uma sala com 6 linhas e 8 colunas.
 * Cada posição da matriz representa uma cadeira:
 *
 * 0 = Livre
 * 1 = Ocupada
 *
 * Inicialmente todas as cadeiras devem estar livres.
 *
 * Crie um sistema com menu repetitivo:
 *
 * 1 - Reservar assento
 * 2 - Cancelar reserva
 * 3 - Consultar assento
 * 4 - Mostrar mapa da sala
 * 5 - Encerrar
 *
 * Utilize uma função chamada VerificarAssento().
 * A função deve retornar "Livre" ou "Ocupado".
 */


#include <iostream>
#include <locale.h>
#include <string>

using namespace std;


// Matriz que representa as cadeiras da sala
int SalaCadeira[6][8];


// Função do menu
void Menu(int &opcao)
{
    cout << "\nMenu de opções:" << endl;
    cout << "1 - Reservar assento;" << endl;
    cout << "2 - Cancelar reserva;" << endl;
    cout << "3 - Consultar assento;" << endl;
    cout << "4 - Mostrar mapa da sala;" << endl;
    cout << "5 - Encerrar." << endl;


    cout << "\nDigite o número da opção desejada: ";
    cin >> opcao;
}


// Função para reservar cadeira
void ReservarAssento()
{
    int linha, coluna;

    cout << "\nDigite a linha do assento (0 a 5): ";
    cin >> linha;

    cout << "Digite a coluna do assento (0 a 7): ";
    cin >> coluna;


    if(linha < 0 || linha > 5 || coluna < 0 || coluna > 7)
    {
        cout << "Assento inválido!" << endl;
    }
    else if(SalaCadeira[linha][coluna] == 1)
    {
        cout << "Esse assento já está ocupado!" << endl;
    }
    else
    {
        SalaCadeira[linha][coluna] = 1;
        cout << "Assento reservado com sucesso!" << endl;
    }
}


// Função para cancelar reserva
void CancelarReserva()
{
    int linha, coluna;

    cout << "\nDigite a linha do assento (0 a 5): ";
    cin >> linha;

    cout << "Digite a coluna do assento (0 a 7): ";
    cin >> coluna;


    if(linha < 0 || linha > 5 || coluna < 0 || coluna > 7)
    {
        cout << "Assento inválido!" << endl;
    }
    else if(SalaCadeira[linha][coluna] == 0)
    {
        cout << "Esse assento já está livre!" << endl;
    }
    else
    {
        SalaCadeira[linha][coluna] = 0;
        cout << "Reserva cancelada com sucesso!" << endl;
    }
}


// Função que verifica o estado do assento
string VerificarAssento(int linha, int coluna)
{
    if(SalaCadeira[linha][coluna] == 0)
    {
        return "Livre";
    }
    else
    {
        return "Ocupado";
    }
}


// Função para consultar assento
void ConsultarAssento()
{
    int linha, coluna;

    cout << "\nDigite a linha do assento (0 a 5): ";
    cin >> linha;

    cout << "Digite a coluna do assento (0 a 7): ";
    cin >> coluna;


    if(linha < 0 || linha > 5 || coluna < 0 || coluna > 7)
    {
        cout << "Assento inválido!" << endl;
    }
    else
    {
        cout << "O assento [" << linha << "][" << coluna << "] está "
             << VerificarAssento(linha, coluna) << "." << endl;
    }
}


// Função para mostrar mapa da sala
void MostrarMapa()
{
    cout << "\nMapa da sala:" << endl;


    for(int i = 0; i < 6; i++)
    {
        for(int j = 0; j < 8; j++)
        {
            cout << SalaCadeira[i][j] << " ";
        }

        cout << endl;
    }
}


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");


    int opcao = 0;


    cout << "\nBem-vindo ao sistema de reservas do cinema!" << endl;


    do
    {
        cout << "\n==========================================================================";

        Menu(opcao);

        cout << "==========================================================================\n";


        switch(opcao)
        {
            case 1:
                ReservarAssento();
                break;


            case 2:
                CancelarReserva();
                break;


            case 3:
                ConsultarAssento();
                break;


            case 4:
                MostrarMapa();
                break;


            case 5:
                cout << "Obrigado por utilizar o sistema do cinema!" << endl;
                break;


            default:
                cout << "Opção inválida! Escolha uma opção válida." << endl;
                break;
        }


    } while(opcao != 5);


    return 0;
}