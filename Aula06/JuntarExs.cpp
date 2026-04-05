#include <iostream>
#include <locale>
#include <iomanip>

using namespace std;

void menu() {
    cout << "Escolha uma opção:" << endl;
    cout << "1 - A média aritmética de um conjunto de números pares" << endl;
    cout << "2 - A soma de todos os números ímpares múltiplos de 3 entre 50 e 500" << endl;
    cout << "3 - A soma dos dígitos do quadrado de um número" << endl;
    cout << "4 - Sair" << endl;
}

void MediaPar(){
    cout << "A opção 1 foi selecionada!" << endl;

    double contPares = 0;
    double acumulador = 0;
    int quantia = 0;
    cout << "Digite a quantidade de números que vai inserir: " << endl;
    cin >> quantia;

    while(quantia > 0){
        int num; 
        cout << "Digite um número: " << endl;
        cin >> num;

        if (num % 2 == 0){
            acumulador += num;
            contPares++;
        }
        quantia--;
    }
    cout << fixed << setprecision(2);

    if(contPares == 0){
        cout << "Não há números pares para calcular a média." << endl;
    } else{
        cout << "A média aritmética dos números pares desse conjunto é: " << acumulador / contPares << endl;
    }
}

void SomaIM3(){
    cout << "A opção 2 foi selecionada!" << endl;

    int soma = 0;

    for (int i = 51; i <= 500; i+= 3) {
    if (i % 2 == 1)
    {
       soma+=i;
    }
}
    cout << "A soma de todos os números ímpares múltiplos de 3 entre 50 e 500 é: " << soma << endl;
}

void SomaDigQuadrado(){

    cout << "A opção 3 foi selecionada!" << endl;

    int digito = 0;
    int soma = 0;
    int num = 0;
    cout << "Digite um número: " << endl;
    cin >> num;
    int quadrado = num * num;

    while (quadrado > 0){
        digito = quadrado % 10;
        soma += digito;
        quadrado /= 10;
    }
    cout << "A soma dos dígitos do quadrado de " << num << " é: " << soma << endl;
}

int main() {
    
    setlocale(LC_ALL, "pt_BR.UTF-8");
    int opcao = 0;

    do{
        menu();

        cout << "Digite a opção desejada: " << endl;
        cin >> opcao;

        switch (opcao){
            case 1:
                MediaPar();
                break;
            case 2:
                SomaIM3(); 
                break;
            case 3:
                SomaDigQuadrado();
                break;
            case 4:
                cout << "Saindo do programa..." << endl;
                break;
            default:
                cout << "Opção inválida! Tente novamente..." << endl;
        }
    }while (opcao != 4);
}
