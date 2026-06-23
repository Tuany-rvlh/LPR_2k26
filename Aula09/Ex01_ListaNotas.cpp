#include <iostream> // biblioteca do sistema
#include <clocale> // setlocale
#include <list> // usar listas 

using namespace std; //não será precio mais o uso do std em todas as linhas de código

main(){

    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    //Variavéis para guardar o valor da nota e ela ficar na lista
    list<float>notas;
    float nota = 0, menor = 10, maior = 0, soma = 0;
    
    for(int i = 0; i < 5; i++){

        cout << "Digite sua nota: ";
        cin >> nota;

        notas.push_front(nota);
    }

    cout << "As notas são: " << endl;
    
    for(int numero : notas){   
        cout << numero;

        if(numero > maior){
            maior = numero;
        }

        soma += numero;
    }

    cout << "A média das notas é" << soma/notas.size()
}