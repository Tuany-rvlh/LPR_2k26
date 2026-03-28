#include <iostream>
#include <locale.h>
#include <iomanip>

using namespace std;

int main(){

    setlocale(LC_ALL, "pt_BR.UTF-8");

    float horas_dia;
    float horas_semana;
    float total_horas = 0;
    int semanas = 0;

    cout << "Insira o número de horas de treinamento por dia: ";
    cin >> horas_dia;

    horas_semana = 5 * horas_dia;

    while(total_horas < 1000){
        total_horas += horas_semana;
        semanas++;
}
    cout << fixed << setprecision(2);
    
    cout << "Número de semanas para atingir 1000 horas: " << semanas << endl;
    cout << "Número de dias para atingir 1000 horas: " << semanas * 5 << endl;
    cout << "Número de meses para atingir 1000 horas: " << semanas / 4.5 << endl;

}