/*
 * Enunciado:
 * Desenvolva um programa que permita ao jogador escolher uma classe
 * de personagem de um jogo de RPG e, em seguida, exiba suas
 * habilidades especiais correspondentes.
 *
 * Classes disponíveis:
 *
 * 1 - Guerreira
 * Habilidades: Ataque Pesado, Defesa Total
 *
 * 2 - Mago
 * Habilidades: Bola de Fogo, Escudo de Gelo
 *
 * 3 - Arqueira
 * Habilidades: Flecha Precisa, Disparo Triplo
 */

// Bibliotecas utilizadas
#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    int classe = 0;

    // Exibe as opções de classes disponíveis
    cout << "1 - Guerreira" << endl;
    cout << "2 - Mago" << endl;
    cout << "3 - Arqueira" << endl;

    cout << "Escolha sua classe de personagem: ";
    cin >> classe;

    // Verifica se o valor digitado é válido
    if (cin.fail())
    {
        cout << "Valor inválido! Digite um número." << endl;
    }
    else
    {
        // Mostra as habilidades de acordo com a classe escolhida
        switch (classe)
        {
            case 1:
                cout << "Suas habilidades são: Ataque Pesado, Defesa Total" << endl;
                break;

            case 2:
                cout << "Suas habilidades são: Bola de Fogo, Escudo de Gelo" << endl;
                break;

            case 3:
                cout << "Suas habilidades são: Flecha Precisa, Disparo Triplo" << endl;
                break;

            default:
                cout << "Você digitou uma opção inválida!" << endl;
                break;
        }
    }

}