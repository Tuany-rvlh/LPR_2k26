#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main(){

    setlocale(LC_ALL, "pt_BR.UTF-8"); //Permite caracteres como acentuação

    vector<int>numeros(10); //Vetor com 10 elementos;
    int numProcurado = 0;

    for(int i = 0; i < 10; i++)
    {
        cout<<"Insira o número"<< i + 1<<": "<<endl;
        cin>>numeros[i];
    }

    cout<<"Digite o número que deseja buscar no array: "<<endl;
    cin>>numProcurado;

    if(binary_search(numeros.begin(), numeros.end(),numProcurado)){
        cout<<"Número encontrado!"<<endl;
    }
    else{
        cout<<"Número não encontrado!"<<endl;
    }


}