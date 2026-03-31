#include <iostream>
#include <locale.h>

using namespace std; 

int num;
int num_reverso;

int reverter(int num){

    int resto; 

    while (num != 0){
        resto = num % 10;
        num_reverso = num_reverso * 10 + resto;
        num /= 10;

    }

    return num_reverso;
}

int main(){
    
    setlocale(LC_ALL, "pt_BR.UTF-8");

    cout << "Digite o número que será invertido: ";
    cin >> num;
    
    num_reverso = reverter(num);
    
    cout << "O inverso desse número é: " << num_reverso << endl;
}
