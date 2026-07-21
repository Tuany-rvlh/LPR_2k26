/*
 * Enunciado:
 *
 * Crie uma struct chamada Piloto contendo:
 * Nome, Equipe e Pontuação.
 *
 * O programa deverá utilizar uma lista para armazenar os competidores.
 *
 * Implemente as seguintes funções:
 * - CadastrarPiloto();
 * - ExibirRanking();
 * - CalcularPontuacaoMedia();
 * - ExibirMelhorEquipe();
 *
 * O programa deve:
 * - Cadastrar 10 pilotos;
 * - Exibir um ranking em ordem decrescente de pontuação;
 * - Calcular a média de pontos do campeonato;
 * - Exibir quantos pilotos ficaram acima da média;
 * - Determinar qual equipe possui a maior soma de pontos.
 */


#include <iostream> // Biblioteca para entrada e saída
#include <list>     // Biblioteca para utilizar listas
#include <string>   // Biblioteca para utilizar strings
#include <algorithm> // Biblioteca para ordenação
#include <map>      // Biblioteca para armazenar equipes
#include <clocale>  // Biblioteca para setlocale

using namespace std;


// Struct criada para armazenar as características do piloto
struct Piloto
{
    string Nome;
    string Equipe;
    double Pontuacao;
};


// Lista para armazenar os pilotos cadastrados
list<Piloto> Cadastro10;



// Função para cadastrar os pilotos
void CadastrarPiloto()
{
    for (int i = 0; i < 10; i++)
    {
        cout << "\nCadastro do Piloto " << i + 1 << endl;

        Piloto piloto;

        cout << "Digite o nome do piloto: ";
        getline(cin, piloto.Nome);

        cout << "Digite a equipe do piloto: ";
        getline(cin, piloto.Equipe);

        cout << "Digite a pontuação do piloto: ";
        cin >> piloto.Pontuacao;

        cin.ignore();

        Cadastro10.push_back(piloto);
    }
}

// Função para exibir o ranking
void ExibirRanking()
{
    // Ordena a lista pela pontuação em ordem decrescente
    Cadastro10.sort([](Piloto a, Piloto b)
    {
        return a.Pontuacao > b.Pontuacao;
    });

    cout << "\n===== RANKING =====" << endl;

    int posicao = 1;

    for (Piloto piloto : Cadastro10)
    {
        cout << posicao << "º - "
             << piloto.Nome << " | "
             << piloto.Equipe << " | "
             << piloto.Pontuacao << " pontos"
             << endl;

        posicao++;
    }
}

// Função para calcular a média de pontuação
void CalcularPontuacaoMedia()
{
    double soma = 0;

    for (Piloto piloto : Cadastro10)
    {
        soma += piloto.Pontuacao;
    }

    double media = soma / Cadastro10.size();
    int acimaMedia = 0;

    for (Piloto piloto : Cadastro10)
    {
        if (piloto.Pontuacao > media)
        {
            acimaMedia++;
        }
    }

    cout << "\nMédia de pontos do campeonato: "
         << media << endl;

    cout << "Pilotos acima da média: "
         << acimaMedia << endl;
}

// Função para encontrar a equipe com maior pontuação
void ExibirMelhorEquipe()
{
    map<string, double> equipes;

    for (Piloto piloto : Cadastro10)
    {
        equipes[piloto.Equipe] += piloto.Pontuacao;
    }

    string melhorEquipe;
    double maiorPontuacao = 0;

    for (auto equipe : equipes)
    {
        if (equipe.second > maiorPontuacao)
        {
            maiorPontuacao = equipe.second;
            melhorEquipe = equipe.first;
        }
    }

    cout << "\n===== MELHOR EQUIPE =====" << endl;
    cout << "Equipe: " << melhorEquipe << endl;
    cout << "Pontuação total: " << maiorPontuacao << endl;
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Permite acentuação em português

    CadastrarPiloto();
    ExibirRanking();
    CalcularPontuacaoMedia();
    ExibirMelhorEquipe();


}