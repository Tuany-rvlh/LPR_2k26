/*
 * Enunciado:
 *
 * Crie um programa que permita ao usuário cadastrar notas de alunos
 * em uma lista.
 *
 * O programa deverá:
 * - Solicitar ao usuário 5 notas;
 * - Armazenar as notas em uma lista;
 * - Exibir todas as notas cadastradas;
 * - Informar a maior nota;
 * - Informar a menor nota;
 * - Calcular a média das notas.
 */


#include <iostream> // biblioteca do sistema
#include <clocale>  // setlocale
#include <list>     // biblioteca para utilizar listas

using namespace std;


int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português


    // Lista para armazenar as notas
    list<float> notas;

    float nota;
    float soma = 0;


    // Cadastro das notas
    for (int i = 0; i < 5; i++)
    {
        cout << "Digite a nota " << i + 1 << ": ";
        cin >> nota;

        notas.push_back(nota);
    }

    // Inicializa maior e menor com a primeira nota da lista
    float maior = notas.front();
    float menor = notas.front();


    cout << "\nNotas cadastradas: ";

    // Percorre a lista para exibir e encontrar valores
    for (float numero : notas)
    {
        cout << numero << " ";

        if (numero > maior)
        {
            maior = numero;
        }

        if (numero < menor)
        {
            menor = numero;
        }

        soma += numero;
    }

    cout << "\n\nMaior nota: " << maior << endl;
    cout << "Menor nota: " << menor << endl;
    cout << "Média das notas: " << soma / notas.size() << endl;

}