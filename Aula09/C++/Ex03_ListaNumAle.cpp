/*
 * Enunciado:
 *
 * Construa uma lista de 100 números aleatórios.
 *
 * O programa deverá:
 * - Colocar os números em ordem crescente e imprimir a lista;
 * - Remover todos os números pares e imprimir a lista novamente;
 * - Informar quais números se repetem e se existe algum número repetido.
 */


#include <iostream> // Biblioteca de entrada e saída
#include <list>     // Biblioteca para utilizar listas
#include <algorithm> // Biblioteca para ordenar e buscar elementos
#include <cstdlib>  // Biblioteca para números aleatórios
#include <ctime>    // Biblioteca para configurar a semente aleatória
#include <clocale>  // Biblioteca para setlocale


using namespace std;



// Função para mostrar os números da lista
void MostrarNumeros(list<int> numeros)
{
    for (int numero : numeros)
    {
        cout << numero << " ";
    }
}



// Função para verificar números repetidos
void VerificarRepetidos(list<int> numeros)
{
    list<int> repetidos;


    for (int numero : numeros)
    {
        int quantidade = count(numeros.begin(), numeros.end(), numero);


        if (quantidade > 1 && find(repetidos.begin(), repetidos.end(), numero) == repetidos.end())
        {
            repetidos.push_back(numero);
        }
    }


    if (repetidos.size() > 0)
    {
        cout << "\n\nNúmeros repetidos: ";

        for (int numero : repetidos)
        {
            cout << numero << " ";
        }
    }
    else
    {
        cout << "\n\nNão existem números repetidos.";
    }
}



int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    // Lista para armazenar os números
    list<int> numeros100;

    srand(time(NULL));

    // Adiciona 100 números aleatórios na lista
    for (int i = 0; i < 100; i++)
    {
        int numeroAleatorio = rand() % 101;

        numeros100.push_back(numeroAleatorio);
    }

    // Ordena a lista em ordem crescente
    numeros100.sort();

    cout << "Lista ordenada:" << endl;
    MostrarNumeros(numeros100);

    // Verifica os números repetidos
    VerificarRepetidos(numeros100);

    // Remove todos os números pares
    numeros100.remove_if([](int numero)
    {
        return numero % 2 == 0;
    });

    cout << "\n\nLista sem os números pares:" << endl;
    MostrarNumeros(numeros100);


}