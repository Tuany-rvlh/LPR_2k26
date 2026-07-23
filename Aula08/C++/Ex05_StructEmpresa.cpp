/*
 * Enunciado:
 * Desenvolva um programa que simule um sistema de controle de chamados
 * de uma empresa.
 *
 * O programa deve permitir o cadastro de até dez chamados, armazenando em uma
 * STRUCT as informações de cada chamado, como número, solicitante, setor,
 * prioridade, status e descrição.
 *
 * Ao cadastrar um chamado, o status inicial deve ser definido automaticamente
 * como "Aberto". O usuário poderá listar todos os chamados cadastrados, atualizar
 * o status de um chamado específico e visualizar estatísticas sobre a quantidade
 * de chamados em cada situação.
 *
 * O programa deve possuir um menu interativo com as opções de cadastrar chamados,
 * listar chamados, atualizar status, classificar prioridade e exibir estatísticas,
 * permanecendo em execução até que o usuário escolha sair.
 *
 * Requisitos:
 * - Utilizar STRUCTS para armazenar os dados dos chamados.
 * - Não utilizar classes ou listas.
 * - É permitido utilizar vetores.
 */

 #include <iostream>
#include <string>

using namespace std;


// Struct com as características do chamado
struct Chamado
{
    int Numero;
    string Solicitante;
    string Setor;
    int Prioridade;
    string Status;
    string Descricao;
};


// Função para exibir o menu principal
void menuPrincipal()
{
    cout << "=== Sistema de Controle de Chamados ===" << endl;
    cout << "1. Cadastrar Chamado" << endl;
    cout << "2. Listar Chamados" << endl;
    cout << "3. Atualizar Status" << endl;
    cout << "4. Classificar Prioridade" << endl;
    cout << "5. Exibir Estatisticas" << endl;
    cout << "6. Sair" << endl;
    cout << "=======================================" << endl;
    cout << endl;
}


// Função para cadastrar chamados
void cadastrarChamado(Chamado chamados[], int &i)
{
    // Verifica se o limite de chamados foi atingido
    if (i >= 10)
    {
        cout << "Limite de chamados cadastrados atingido." << endl;
        return;
    }


    cout << "Digite o numero do chamado: ";
    cin >> chamados[i].Numero;

    cin.ignore();

    cout << "Digite o solicitante: ";
    getline(cin, chamados[i].Solicitante);

    cout << "Digite o setor: ";
    getline(cin, chamados[i].Setor);

    cout << "Digite a prioridade (1 - Baixa, 2 - Media, 3 - Alta): ";
    cin >> chamados[i].Prioridade;

    cin.ignore();

    cout << "Digite a descricao: ";
    getline(cin, chamados[i].Descricao);


    // Todo chamado começa como aberto
    chamados[i].Status = "Aberto";


    cout << "Chamado cadastrado com sucesso!" << endl;
    cout << endl;


    i++;
}


// Função para listar todos os chamados
void listarChamados(Chamado chamados[], int quantidade)
{
    if (quantidade == 0)
    {
        cout << "Nenhum chamado cadastrado." << endl;
        return;
    }


    cout << "=== Chamados Cadastrados ===" << endl;


    for (int i = 0; i < quantidade; i++)
    {
        cout << "Chamado " << i + 1 << endl;
        cout << "Numero: " << chamados[i].Numero << endl;
        cout << "Solicitante: " << chamados[i].Solicitante << endl;
        cout << "Setor: " << chamados[i].Setor << endl;
        cout << "Prioridade: " << chamados[i].Prioridade << endl;
        cout << "Status: " << chamados[i].Status << endl;
        cout << "Descricao: " << chamados[i].Descricao << endl;
        cout << endl;
    }
}


// Função para atualizar o status do chamado
void atualizarStatus(Chamado chamados[], int quantidade)
{
    int numero;

    cout << "Digite o numero do chamado: ";
    cin >> numero;


    for (int i = 0; i < quantidade; i++)
    {
        if (chamados[i].Numero == numero)
        {
            int opcao;


            cout << "Escolha o novo status:" << endl;
            cout << "1. Em andamento" << endl;
            cout << "2. Resolvido" << endl;
            cout << "3. Cancelado" << endl;
            cout << "Opcao: ";

            cin >> opcao;


            switch(opcao)
            {
                case 1:
                    chamados[i].Status = "Em andamento";
                    break;

                case 2:
                    chamados[i].Status = "Resolvido";
                    break;

                case 3:
                    chamados[i].Status = "Cancelado";
                    break;

                default:
                    cout << "Opcao invalida." << endl;
                    return;
            }


            cout << "Status atualizado com sucesso!" << endl;
            return;
        }
    }


    cout << "Chamado nao encontrado." << endl;
}


// Função para classificar prioridade
string classificarPrioridade(int prioridade)
{
    if (prioridade == 1)
    {
        return "Baixa";
    }
    else if (prioridade == 2)
    {
        return "Media";
    }
    else if (prioridade == 3)
    {
        return "Alta";
    }
    else
    {
        return "Invalida";
    }
}


// Função para exibir estatísticas dos chamados
void estatisticas(Chamado chamados[], int quantidade)
{
    int abertos = 0;
    int andamento = 0;
    int resolvidos = 0;
    int cancelados = 0;


    for (int i = 0; i < quantidade; i++)
    {
        if (chamados[i].Status == "Aberto")
        {
            abertos++;
        }
        else if (chamados[i].Status == "Em andamento")
        {
            andamento++;
        }
        else if (chamados[i].Status == "Resolvido")
        {
            resolvidos++;
        }
        else if (chamados[i].Status == "Cancelado")
        {
            cancelados++;
        }
    }


    cout << "=== Estatisticas ===" << endl;
    cout << "Chamados abertos: " << abertos << endl;
    cout << "Chamados em andamento: " << andamento << endl;
    cout << "Chamados resolvidos: " << resolvidos << endl;
    cout << "Chamados cancelados: " << cancelados << endl;
}


// Função principal
int main()
{
    // Vetor para armazenar os chamados
    Chamado chamados[10];


    // Variável para controlar quantidade de chamados
    int quantidade = 0;


    string opcao;


    do
    {
        menuPrincipal();


        cout << "Digite a opcao desejada: ";
        cin >> opcao;


        switch(opcao[0])
        {
            case '1':
                cadastrarChamado(chamados, quantidade);
                break;


            case '2':
                listarChamados(chamados, quantidade);
                break;


            case '3':
                atualizarStatus(chamados, quantidade);
                break;


            case '4':
            {
                int prioridade;

                cout << "Digite a prioridade (1 a 3): ";
                cin >> prioridade;

                cout << "Prioridade: "
                     << classificarPrioridade(prioridade)
                     << endl;

                break;
            }


            case '5':
                estatisticas(chamados, quantidade);
                break;


            case '6':
                cout << "Encerrando o programa..." << endl;
                break;


            default:
                cout << "Opcao invalida." << endl;
        }


    } while(opcao != "6");

}