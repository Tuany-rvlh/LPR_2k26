#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int main(){
    
    cout << string(30, '=') << endl;
    SetConsoleOutputCP(CP_UTF8);

    const float pi = 3.14159f;
    float raio = 0;
    float area = 0;

    cout << "Digite o raio do círculo: ";
    cin >> raio;

    area = pi * (raio * raio);
    
    cout << fixed << setprecision(2);
    cout << "A área deste círculo é: " << area << " m²" << endl;
    cout << string(30, '=') << endl;

}