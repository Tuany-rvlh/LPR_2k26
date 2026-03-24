#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int main(){

    SetConsoleOutputCP(CP_UTF8);

    int A = 0;
    int B = 0;

    cout << "Digite um valor: ";
    cin >> A;

    cout << "Digite um outro valor: ";
    cin >> B;

    if (A >= B){
        if(A % B == 0){
            cout << "Esses números são MÚLTIPLOS!";
        }
        else{
            cout << "Esses números NÃO são MÚLTIPLOS!";

        }
    }
    else {
        if(B % A == 0){
            cout << "Esses números são MÚLTIPLOS!";
        }
        else{
            cout << "Esses números NÃO são MÚLTIPLOS!";

        }
    }
}