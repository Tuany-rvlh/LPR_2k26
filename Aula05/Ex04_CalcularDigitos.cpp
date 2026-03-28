#include <iostream>
#include <locale.h>

using namespace std;

int main(){

    setlocale(LC_ALL, "pt_BR.UTF-8");
    
    int num;
    int contador = 0;
    int soma = 0;

    cout << "Digite um número: ";
    cin >> num;

    int quadrado = num * num;
    contador = quadrado;

    while(contador > 0){
        soma+= contador % 10;
        contador = contador / 10;
    }

    cout << "Soma dos dígitos do quadrado é: " << soma << endl;

}