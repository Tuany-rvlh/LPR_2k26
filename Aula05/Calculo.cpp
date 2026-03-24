#include <iostream>
#include <locale.h>

using namespace std;

int main(){

    setlocale(LC_ALL, "pt_BR.UTF-8");
    
    int num;
    int quadrado;

    cout << "Digite um número: ";
    cin >> num;

    quadrado = num * num;



}