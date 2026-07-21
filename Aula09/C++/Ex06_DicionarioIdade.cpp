#include <iostream>
#include <map>
#include <string>

using namespace std;

int main(){

    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    map<string,int> pessoasIdade;

    int pares = 0; float soma = 0;
    string chave = "";
    cout << "Digite o número de pares chave-valor: " ;

    for(int i = 0; i < pares; i++){

        cout << "Nome da pessoa: ";
        getline(cin, chave);
        cout << "Digite o gênero desse jogo: ";
        cin >> pessoasIdade[chave];
        cout << "" << endl;
    }

    for(auto idade : pessoasIdade){
        soma += idade.second;
    }

    float media



}