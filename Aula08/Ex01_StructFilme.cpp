//bibliotecas incluídas
#include <iostream> // cin e cout
#include <string> // permite string
#include <array> //para o array
#include <clocale> //setlocale

using namespace std; //Não é necessário colocar std:: quando utlizado esse using

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

    //Definindo um array que armazena 3 elementos do tipo filme
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
   int indiceMaisAntigo = 0;

    for (int i = 1; i < 3; i++) {
        if (DadosFilme[i].AnoLancamento < DadosFilme[indiceMaisAntigo].AnoLancamento) {
            indiceMaisAntigo = i;
        }
    }

    cout << "O filme mais antigo é o " << DadosFilme[indiceMaisAntigo].Titulo << endl;

}