/*
 * Enunciado:
 * Desenvolva um programa que leia o valor do raio de um círculo e calcule
 * a sua área utilizando a fórmula:
 *
 *      área = π × raio²
 *
 * Considere o valor de π = 3.14159 e apresente o resultado da área
 * com quatro casas decimais.
 */

// Bibliotecas
#include <iostream>
#include <iomanip>
#include <clocale>

using namespace std;

int main(){

    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    const double pi = 3.14159; // variável constante para armazenar o valor de pi
    double raio = 0; // variável para o valor do raio
    double area = 0; // variável para o valor da área

    // Entrada do valor do raio
    cout << "Digite o raio do círculo: "; 
    cin >> raio;

    // Cálculo da área do círculo
    area = pi * (raio * raio); 

    // Saída do valor da área com quatro casas decimais
    cout << fixed << setprecision(4);
    cout << "A área deste círculo é: " << area << " m²" << endl; 

}