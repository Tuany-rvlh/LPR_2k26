#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

main(){

    SetConsoleOutputCP(CP_UTF8);

    int num_funcionario = 0;
    int horas = 0;
    float valor_hora = 0;
    float salario = 0;

    cout << "Digite o seu número de trabalhador: ";
    cin >> num_funcionario;

    cout << "Digite a quantia de horas trabalhadas: ";
    cin >> horas;

    cout << "Digite o valor da hora: ";
    cin >> valor_hora;

    salario = horas * valor_hora;
    
    cout << string(30, '=') << endl;
    cout << "Número do funcionário: " << num_funcionario << endl;
    cout << fixed << setprecision(2);
    cout << "Salário " << salario << endl;

}