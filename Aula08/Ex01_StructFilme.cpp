#include <iostream>
#include <iomanip>
#include <string>
#include <array>
using namespace std;


//Struct criada para os elementos do filme
struct Filme{
    string Titulo;
    string Diretor;
    int AnoLancamento;
    int DuracaoMinutos;
};

int main(){

    //Variável para ver o filme mais antigo
    string antigo;

    //Definindo um vetor para armazenar os dados dos 3 filmes
    array<Filme,3>DadosFilme;

    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    //For para inicializar os dados
    for(int i = 0; i < 3; i++){
        cout << "Digite o título do filme: ";
        getline(cin, DadosFilme[i].Titulo);
        cout << "Digite o diretor do filme: ";
        getline(cin, DadosFilme[i].Diretor);
        cout << "Digite o ano de lançamento do filme: "; 
        cin >> DadosFilme[i].AnoLancamento;
        cout << "Digite a duração em minutos do filme: ";
        cin >> DadosFilme[i].DuracaoMinutos;
        cout << "" << endl;
        cin.ignore();
    }
 
    //for para mostrar os filmes
    for(int texto = 0; texto < 3; texto++){
        cout << "Filme " << texto+1 << ": " << endl;
        cout << "Título: " << DadosFilme[texto].Titulo << endl;
        cout << "Diretor: " << DadosFilme[texto].Diretor << endl;
        cout << "Ano de lançamento: " << DadosFilme[texto].AnoLancamento << endl;
        cout << "Duração em minutos: " << DadosFilme[texto].DuracaoMinutos << endl;
        cout << "" << endl;
    }


    //Verificaçõ do ano menor
    if(DadosFilme[0].AnoLancamento == DadosFilme[1].AnoLancamento && 
        DadosFilme[0].AnoLancamento == DadosFilme[2].AnoLancamento && 
        DadosFilme[1].AnoLancamento == DadosFilme[2].AnoLancamento){
            cout << "Não há um filme mais antigo, todos foram lançados no mesmo ano. " << endl;
        }
    else if(DadosFilme[0].AnoLancamento < DadosFilme[1].AnoLancamento && 
        DadosFilme[0].AnoLancamento < DadosFilme[2].AnoLancamento){
            cout << "O filme mais antigo é o " << DadosFilme[0].Titulo << endl;
    }
    else if(DadosFilme[1].AnoLancamento < DadosFilme[0].AnoLancamento && 
        DadosFilme[1].AnoLancamento < DadosFilme[2].AnoLancamento){
            cout << "O filme mais antigo é o " << DadosFilme[1].Titulo << endl;
    }
    else{
        cout << "O filme mais antigo é o " << DadosFilme[2].Titulo << endl;
    }

}