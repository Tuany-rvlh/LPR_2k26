#include <iostream>
#include <locale.h>

using namespace std;

int main(){

    setlocale(LC_ALL, "pt_BR.UTF-8");

    float horas;
    float semana;

    cout << "Insira o número de horas de treinamento por dia: ";
    cin >> horas;

    semana = 5 * horas;


}