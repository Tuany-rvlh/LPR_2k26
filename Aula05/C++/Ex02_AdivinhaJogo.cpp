/*
 * Enunciado:
 * Desenvolva um algoritmo de adivinhação de números.
 *
 * O programa deve gerar um número aleatório entre 1 e 100.
 * O usuário deverá informar tentativas até acertar o número secreto.
 *
 * A cada tentativa, o programa deve informar se o usuário:
 * - chutou alto;
 * - chutou baixo;
 * - acertou.
 *
 * Ao final, deve informar a quantidade de tentativas utilizadas.
 */

// Bibliotecas utilizadas
#include <iostream>
#include <random>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    // Gera um número aleatório entre 1 e 100
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);

    int valorSecreto = distribuicao(numAleatorio);

    // Variáveis para armazenar a tentativa e contar os chutes
    int tentativa = 0;
    int cont = 0;

    cout << "=== JOGO DE ADIVINHAÇÃO ===" << endl;
    cout << "Tente adivinhar um número entre 1 e 100!" << endl;

    // O jogo continua até o usuário acertar o número secreto
    do
    {
        cout << "Digite sua tentativa: ";
        cin >> tentativa;

        // Verifica se ocorreu algum erro na entrada
        if (cin.fail())
        {
            cout << "Entrada inválida! Digite um número inteiro." << endl;

            cin.clear(); // Limpa o erro do cin
            cin.ignore(1000, '\n'); // Remove o valor inválido digitado
        }
        else
        {
            cont++;

            // Compara a tentativa com o número secreto
            if (tentativa > valorSecreto)
            {
                cout << "Chutou alto!" << endl;
            }
            else if (tentativa < valorSecreto)
            {
                cout << "Chutou baixo!" << endl;
            }
            else
            {
                cout << "Acertou!" << endl;
                cout << "Você usou " << cont << " tentativas." << endl;
            }
        }

    } while (tentativa != valorSecreto);

}