
#include <iostream>
#include <string>
#include <vector>
#include <cstdlib>
#include <ctime>
#include <algorithm>

using namespace std;

class Minerio
{
public:
    string nome;
    string raridade;
    double valor;
    bool possuiPoder;
    string tipoDePoder;
    int bonusDano;
    double bonusVelocidade;

    Minerio(string nome, string raridade, double valor, bool possuiPoder, string tipoDePoder, int bonusDano, double bonusVelocidade)
    {
        this->nome = nome;
        this->raridade = raridade;
        this->valor = valor;
        this->possuiPoder = possuiPoder;
        this->tipoDePoder = tipoDePoder;
        this->bonusDano = bonusDano;
        this->bonusVelocidade = bonusVelocidade;
    }
};

class Arma
{
public:
    string nome;
    string raridade;
    double dano;
    double velocidade;
    int nivelMelhoria;
    string poderes;

    Arma(string nome, string raridade, double dano, double velocidade, string poderes)
    {
        this->nome = nome;
        this->raridade = raridade;
        this->dano = dano;
        this->velocidade = velocidade;
        this->nivelMelhoria = 0;
        this->poderes = poderes;
    }

    void Melhorar()
    {
        int resultado = rand() % 100 + 1;

        cout << "\nTentando melhorar a arma..." << endl;

        if (resultado <= 60)
        {
            nivelMelhoria++;
            dano += 5;

            cout << "Sucesso! A arma aumentou um nivel." << endl;
        }
        else if (resultado <= 90)
        {
            if (nivelMelhoria > 0)
            {
                nivelMelhoria--;
                dano -= 5;

                cout << "Falha! A arma perdeu um nivel." << endl;
            }
            else
            {
                cout << "Falha! A arma permaneceu no nivel 0." << endl;
            }
        }
        else
        {
            cout << "A melhoria nao teve efeito." << endl;
        }

        cout << "Nivel atual: +" << nivelMelhoria << endl;
        cout << "Dano atual: " << dano << endl;
    }

    void MostrarAtributos()
    {
        cout << "\n========== ARMA ==========" << endl;
        cout << "Nome: " << nome << endl;
        cout << "Raridade: " << raridade << endl;
        cout << "Dano: " << dano << endl;
        cout << "Velocidade: " << velocidade << endl;
        cout << "Nivel de melhoria: +" << nivelMelhoria << endl;
        cout << "Poderes: " << poderes << endl;
    }
};

class Jogador
{
public:
    string nome;
    string raca;
    int nivel;
    int experiencia;
    double dinheiro;

    vector<Minerio> minerios;
    vector<Arma> armas;

    Jogador(string nome, string raca)
    {
        this->nome = nome;
        this->raca = raca;
        nivel = 1;
        experiencia = 0;
        dinheiro = 1000;
    }

    void GanharExperiencia(int quantidade)
    {
        experiencia += quantidade;

        cout << "\nVoce ganhou " << quantidade << " XP!" << endl;

        while (experiencia >= nivel * 100)
        {
            experiencia -= nivel * 100;
            nivel++;

            cout << "\nPARABENS! Voce alcancou o nivel " << nivel << "!" << endl;
        }

        cout << "Experiencia: " << experiencia << "/" << nivel * 100 << endl;
    }

    void Minerar(Minerio minerio)
    {
        minerios.push_back(minerio);

        cout << "\nVoce encontrou: " << minerio.nome << endl;
        cout << "Raridade: " << minerio.raridade << endl;

        if (minerio.possuiPoder)
        {
            cout << "Poder especial: " << minerio.tipoDePoder << endl;
        }
        else
        {
            cout << "Esse minerio nao possui poder especial." << endl;
        }

        GanharExperiencia(10);
    }

    void VenderMinerio(int escolha)
    {
        if (escolha < 0 || escolha >= minerios.size())
        {
            cout << "Minerio invalido." << endl;
            return;
        }

        Minerio minerio = minerios[escolha];

        dinheiro += minerio.valor;
        minerios.erase(minerios.begin() + escolha);

        cout << "\nMinerio vendido com sucesso!" << endl;
        cout << "Voce recebeu: " << minerio.valor << endl;
        cout << "Dinheiro atual: " << dinheiro << endl;

        GanharExperiencia(5);
    }

    void MostrarStatus()
    {
        cout << "\n========== STATUS ==========" << endl;
        cout << "Nome: " << nome << endl;
        cout << "Raca: " << raca << endl;
        cout << "Nivel: " << nivel << endl;
        cout << "Experiencia: " << experiencia << "/" << nivel * 100 << endl;
        cout << "Dinheiro: " << dinheiro << endl;
    }

    void MostrarInventario()
    {
        cout << "\n========== MINERIOS ==========" << endl;

        if (minerios.size() == 0)
        {
            cout << "Nenhum minerio encontrado." << endl;
        }

        for (int i = 0; i < minerios.size(); i++)
        {
            cout << i << " - " << minerios[i].nome
                 << " (" << minerios[i].raridade << ")"
                 << " | Valor: " << minerios[i].valor << endl;
        }

        cout << "\n========== ARMAS ==========" << endl;

        if (armas.size() == 0)
        {
            cout << "Nenhuma arma criada." << endl;
        }

        for (int i = 0; i < armas.size(); i++)
        {
            cout << i << " - " << armas[i].nome
                 << " | Nivel +" << armas[i].nivelMelhoria << endl;
        }
    }
};

int LerNumero(string mensagem)
{
    int numero;

    cout << mensagem;

    while (!(cin >> numero))
    {
        cout << "Digite um numero valido: ";
        cin.clear();
        cin.ignore(1000, '\n');
    }

    return numero;
}

vector<Minerio> CriarMinerios()
{
    vector<Minerio> lista =
    {
        Minerio("Ferro", "Comum", 50, false, "Nenhum", 3, 0.1),
        Minerio("Ouro", "Incomum", 100, false, "Nenhum", 5, 0.2),
        Minerio("Cristal Arcano", "Raro", 250, true, "Magia", 10, 0.3),
        Minerio("Nucleo Flamejante", "Epico", 500, true, "Fogo", 15, 0.1),
        Minerio("Fragmento Sombrio", "Lendario", 1000, true, "Trevas", 25, 0.4)
    };

    return lista;
}

string DefinirRaridade(Minerio primeiro, Minerio segundo)
{
    vector<string> raridades =
    {
        "Comum", "Incomum", "Raro", "Epico", "Lendario"
    };

    int posicao1 = find(raridades.begin(), raridades.end(), primeiro.raridade) - raridades.begin();
    int posicao2 = find(raridades.begin(), raridades.end(), segundo.raridade) - raridades.begin();

    return raridades[max(posicao1, posicao2)];
}

void Minerar(Jogador &jogador, vector<Minerio> minerios)
{
    Minerio encontrado = minerios[rand() % minerios.size()];

    Minerio novoMinerio(
        encontrado.nome,
        encontrado.raridade,
        encontrado.valor,
        encontrado.possuiPoder,
        encontrado.tipoDePoder,
        encontrado.bonusDano,
        encontrado.bonusVelocidade
    );

    jogador.Minerar(novoMinerio);
}

void VenderMinerio(Jogador &jogador)
{
    if (jogador.minerios.size() == 0)
    {
        cout << "Voce nao possui minerios para vender." << endl;
        return;
    }

    cout << "\n========== VENDER MINERIO ==========" << endl;

    for (int i = 0; i < jogador.minerios.size(); i++)
    {
        cout << i << " - " << jogador.minerios[i].nome
             << " | Valor: " << jogador.minerios[i].valor << endl;
    }

    int escolha = LerNumero("Escolha o minerio que deseja vender: ");

    jogador.VenderMinerio(escolha);
}

void CriarArma(Jogador &jogador)
{
    if (jogador.minerios.size() < 2)
    {
        cout << "Voce precisa de pelo menos dois minerios para criar uma arma." << endl;
        return;
    }

    cout << "\n========== CRIAR ARMA ==========" << endl;

    for (int i = 0; i < jogador.minerios.size(); i++)
    {
        cout << i << " - " << jogador.minerios[i].nome
             << " (" << jogador.minerios[i].raridade << ")" << endl;
    }

    int escolha1 = LerNumero("Escolha o primeiro minerio: ");

    if (escolha1 < 0 || escolha1 >= jogador.minerios.size())
    {
        cout << "Opcao invalida." << endl;
        return;
    }

    int escolha2 = LerNumero("Escolha o segundo minerio: ");

    if (escolha2 < 0 || escolha2 >= jogador.minerios.size() || escolha1 == escolha2)
    {
        cout << "Escolha invalida. Selecione dois minerios diferentes." << endl;
        return;
    }

    Minerio primeiro = jogador.minerios[escolha1];
    Minerio segundo = jogador.minerios[escolha2];

    string nomeArma = primeiro.nome + " + " + segundo.nome;
    string raridade = DefinirRaridade(primeiro, segundo);

    double dano = 10 + primeiro.bonusDano + segundo.bonusDano;
    double velocidade = 1 + primeiro.bonusVelocidade + segundo.bonusVelocidade;

    string poderes = "Nenhum";

    if (primeiro.possuiPoder && segundo.possuiPoder)
    {
        poderes = primeiro.tipoDePoder + " e " + segundo.tipoDePoder;
    }
    else if (primeiro.possuiPoder)
    {
        poderes = primeiro.tipoDePoder;
    }
    else if (segundo.possuiPoder)
    {
        poderes = segundo.tipoDePoder;
    }

    Arma arma(nomeArma, raridade, dano, velocidade, poderes);

    jogador.armas.push_back(arma);

    if (escolha1 > escolha2)
    {
        jogador.minerios.erase(jogador.minerios.begin() + escolha1);
        jogador.minerios.erase(jogador.minerios.begin() + escolha2);
    }
    else
    {
        jogador.minerios.erase(jogador.minerios.begin() + escolha2);
        jogador.minerios.erase(jogador.minerios.begin() + escolha1);
    }

    cout << "\nArma criada com sucesso!" << endl;

    arma.MostrarAtributos();

    jogador.GanharExperiencia(25);
}

void MelhorarArma(Jogador &jogador)
{
    if (jogador.armas.size() == 0)
    {
        cout << "Voce nao possui armas." << endl;
        return;
    }

    MostrarArmas(jogador);

    int escolha = LerNumero("Escolha a arma que deseja melhorar: ");

    if (escolha < 0 || escolha >= jogador.armas.size())
    {
        cout << "Opcao invalida." << endl;
        return;
    }

    jogador.armas[escolha].Melhorar();

    jogador.GanharExperiencia(15);
}

void MostrarArmas(Jogador &jogador)
{
    cout << "\n========== SUAS ARMAS ==========" << endl;

    if (jogador.armas.size() == 0)
    {
        cout << "Nenhuma arma encontrada." << endl;
        return;
    }

    for (int i = 0; i < jogador.armas.size(); i++)
    {
        cout << "\n" << i << " - " << jogador.armas[i].nome << endl;
        jogador.armas[i].MostrarAtributos();
    }
}

int main()
{
    srand(time(0));

    vector<Minerio> minerios = CriarMinerios();

    cout << "========== THE FORGE ==========" << endl;

    cout << "Digite o nome do jogador: ";
    string nome;
    cin.ignore();
    getline(cin, nome);

    if (nome.empty())
    {
        nome = "Jogador";
    }

    cout << "\nEscolha sua raca:" << endl;
    cout << "1 - Humano" << endl;
    cout << "2 - Elfo" << endl;
    cout << "3 - Anao" << endl;
    cout << "4 - Orc" << endl;

    int escolhaRaca = LerNumero("Opcao: ");

    vector<string> racas = { "Humano", "Elfo", "Anao", "Orc" };

    if (escolhaRaca < 1 || escolhaRaca > 4)
    {
        escolhaRaca = 1;
    }

    Jogador jogador(nome, racas[escolhaRaca - 1]);

    int opcao = -1;

    while (opcao != 0)
    {
        cout << "\n========== MENU PRINCIPAL ==========" << endl;
        cout << "1 - Ver status" << endl;
        cout << "2 - Minerar" << endl;
        cout << "3 - Ver inventario" << endl;
        cout << "4 - Criar arma" << endl;
        cout << "5 - Melhorar arma" << endl;
        cout << "6 - Mostrar armas" << endl;
        cout << "7 - Vender minerio" << endl;
        cout << "0 - Sair" << endl;

        opcao = LerNumero("Escolha uma opcao: ");

        switch (opcao)
        {
            case 1:
                jogador.MostrarStatus();
                break;

            case 2:
                Minerar(jogador, minerios);
                break;

            case 3:
                jogador.MostrarInventario();
                break;

            case 4:
                CriarArma(jogador);
                break;

            case 5:
                MelhorarArma(jogador);
                break;

            case 6:
                MostrarArmas(jogador);
                break;

            case 7:
                VenderMinerio(jogador);
                break;

            case 0:
                cout << "Obrigado por jogar The Forge!" << endl;
                break;

            default:
                cout << "Opcao invalida." << endl;
                break;
        }
    }
}
