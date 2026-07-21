#include <iostream>
#include <map> // biblioteca necessária para usar dicionário
#include <string> // permite string

using namespace std;

int main(){

    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    map<string,string>  jogos;

    string chave = "";
    string procura = "";

    for(int i = 0; i < 5; i++){

        cout << "Digite o nome do jogo: ";
        getline(cin, chave);
        cout << "Digite o gênero desse jogo: ";
        getline(cin, jogos[chave]);
        cout << "" << endl;
    }

    cout << "Digite o nome de um dos jogos cadastrados: ";
    getline(cin, procura);

    if(jogos.find(procura) != jogos.end()){
        cout << "O gênero do seu jogo é " << jogos[procura] << endl;
    }
    else{
        cout << "Não foi possível encontrar o jogo informado" << endl;
    }

}