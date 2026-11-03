
using System;
using System.Collections.Generic;

class Minerio
{
    public string nome;
    public string raridade;
    public double valor;
    public bool possuiPoder;
    public string tipoDePoder;
    public int bonusDano;
    public double bonusVelocidade;

    public Minerio(string nome, string raridade, double valor, bool possuiPoder, string tipoDePoder, int bonusDano, double bonusVelocidade)
    {
        this.nome = nome;
        this.raridade = raridade;
        this.valor = valor;
        this.possuiPoder = possuiPoder;
        this.tipoDePoder = tipoDePoder;
        this.bonusDano = bonusDano;
        this.bonusVelocidade = bonusVelocidade;
    }
}

class Arma
{
    public string nome;
    public string raridade;
    public double dano;
    public double velocidade;
    public int nivelMelhoria;
    public string poderes;

    public Arma(string nome, string raridade, double dano, double velocidade, string poderes)
    {
        this.nome = nome;
        this.raridade = raridade;
        this.dano = dano;
        this.velocidade = velocidade;
        this.nivelMelhoria = 0;
        this.poderes = poderes;
    }

    public void Melhorar(Random random)
    {
        int resultado = random.Next(1, 101);

        Console.WriteLine("\nTentando melhorar a arma...");

        if (resultado <= 60)
        {
            nivelMelhoria++;
            dano += 5;

            Console.WriteLine("Sucesso! A arma aumentou um nível.");
        }
        else if (resultado <= 90)
        {
            if (nivelMelhoria > 0)
            {
                nivelMelhoria--;
                dano -= 5;

                Console.WriteLine("Falha! A arma perdeu um nível.");
            }
            else
            {
                Console.WriteLine("Falha! A arma permaneceu no nível 0.");
            }
        }
        else
        {
            Console.WriteLine("A melhoria não teve efeito.");
        }

        Console.WriteLine("Nível atual: +" + nivelMelhoria);
        Console.WriteLine("Dano atual: " + dano);
    }

    public void MostrarAtributos()
    {
        Console.WriteLine("\n========== ARMA ==========");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Raridade: " + raridade);
        Console.WriteLine("Dano: " + dano);
        Console.WriteLine("Velocidade: " + velocidade);
        Console.WriteLine("Nível de melhoria: +" + nivelMelhoria);
        Console.WriteLine("Poderes: " + poderes);
    }
}

class Jogador
{
    public string nome;
    public string raca;
    public int nivel;
    public int experiencia;
    public double dinheiro;

    public List<Minerio> minerios = new List<Minerio>();
    public List<Arma> armas = new List<Arma>();

    public Jogador(string nome, string raca)
    {
        this.nome = nome;
        this.raca = raca;
        nivel = 1;
        experiencia = 0;
        dinheiro = 1000;
    }

    public void GanharExperiencia(int quantidade)
    {
        experiencia += quantidade;

        Console.WriteLine("\nVocê ganhou " + quantidade + " XP!");

        while (experiencia >= nivel * 100)
        {
            experiencia -= nivel * 100;
            nivel++;

            Console.WriteLine("\nPARABÉNS! Você alcançou o nível " + nivel + "!");
        }

        Console.WriteLine("Experiência: " + experiencia + "/" + (nivel * 100));
    }

    public void Minerar(Minerio minerio)
    {
        minerios.Add(minerio);

        Console.WriteLine("\nVocê encontrou: " + minerio.nome);
        Console.WriteLine("Raridade: " + minerio.raridade);

        if (minerio.possuiPoder)
        {
            Console.WriteLine("Poder especial: " + minerio.tipoDePoder);
        }
        else
        {
            Console.WriteLine("Esse minério não possui poder especial.");
        }

        GanharExperiencia(10);
    }

    public void VenderMinerio(int escolha)
    {
        if (escolha < 0 || escolha >= minerios.Count)
        {
            Console.WriteLine("Minério inválido.");
            return;
        }

        Minerio minerio = minerios[escolha];

        dinheiro += minerio.valor;
        minerios.RemoveAt(escolha);

        Console.WriteLine("\nMinério vendido com sucesso!");
        Console.WriteLine("Você recebeu: " + minerio.valor);
        Console.WriteLine("Dinheiro atual: " + dinheiro);

        GanharExperiencia(5);
    }

    public void MostrarStatus()
    {
        Console.WriteLine("\n========== STATUS ==========");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Raça: " + raca);
        Console.WriteLine("Nível: " + nivel);
        Console.WriteLine("Experiência: " + experiencia + "/" + (nivel * 100));
        Console.WriteLine("Dinheiro: " + dinheiro);
    }

    public void MostrarInventario()
    {
        Console.WriteLine("\n========== MINÉRIOS ==========");

        if (minerios.Count == 0)
        {
            Console.WriteLine("Nenhum minério encontrado.");
        }

        for (int i = 0; i < minerios.Count; i++)
        {
            Console.WriteLine(i + " - " + minerios[i].nome +
                              " (" + minerios[i].raridade + ")" +
                              " | Valor: " + minerios[i].valor);
        }

        Console.WriteLine("\n========== ARMAS ==========");

        if (armas.Count == 0)
        {
            Console.WriteLine("Nenhuma arma criada.");
        }

        for (int i = 0; i < armas.Count; i++)
        {
            Console.WriteLine(i + " - " + armas[i].nome +
                              " | Nível +" + armas[i].nivelMelhoria);
        }
    }
}

class Program
{
    static Random random = new Random();

    static int LerNumero(string mensagem)
    {
        int numero;

        Console.Write(mensagem);

        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Digite um número válido: ");
        }

        return numero;
    }

    static Minerio[] CriarMinerios()
    {
        Minerio[] lista =
        {
            new Minerio("Ferro", "Comum", 50, false, "Nenhum", 3, 0.1),
            new Minerio("Ouro", "Incomum", 100, false, "Nenhum", 5, 0.2),
            new Minerio("Cristal Arcano", "Raro", 250, true, "Magia", 10, 0.3),
            new Minerio("Núcleo Flamejante", "Épico", 500, true, "Fogo", 15, 0.1),
            new Minerio("Fragmento Sombrio", "Lendário", 1000, true, "Trevas", 25, 0.4)
        };

        return lista;
    }

    static string DefinirRaridade(Minerio primeiro, Minerio segundo)
    {
        string[] raridades = { "Comum", "Incomum", "Raro", "Épico", "Lendário" };

        int posicao1 = Array.IndexOf(raridades, primeiro.raridade);
        int posicao2 = Array.IndexOf(raridades, segundo.raridade);

        return raridades[Math.Max(posicao1, posicao2)];
    }

    static void Minerar(Jogador jogador, Minerio[] minerios)
    {
        Minerio encontrado = minerios[random.Next(minerios.Length)];

        Minerio novoMinerio = new Minerio(
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

    static void VenderMinerio(Jogador jogador)
    {
        if (jogador.minerios.Count == 0)
        {
            Console.WriteLine("Você não possui minérios para vender.");
            return;
        }

        Console.WriteLine("\n========== VENDER MINÉRIO ==========");

        for (int i = 0; i < jogador.minerios.Count; i++)
        {
            Console.WriteLine(i + " - " + jogador.minerios[i].nome +
                              " | Valor: " + jogador.minerios[i].valor);
        }

        int escolha = LerNumero("Escolha o minério que deseja vender: ");

        jogador.VenderMinerio(escolha);
    }

    static void CriarArma(Jogador jogador)
    {
        if (jogador.minerios.Count < 2)
        {
            Console.WriteLine("Você precisa de pelo menos dois minérios para criar uma arma.");
            return;
        }

        Console.WriteLine("\n========== CRIAR ARMA ==========");

        for (int i = 0; i < jogador.minerios.Count; i++)
        {
            Console.WriteLine(i + " - " + jogador.minerios[i].nome +
                              " (" + jogador.minerios[i].raridade + ")");
        }

        int escolha1 = LerNumero("Escolha o primeiro minério: ");

        if (escolha1 < 0 || escolha1 >= jogador.minerios.Count)
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        int escolha2 = LerNumero("Escolha o segundo minério: ");

        if (escolha2 < 0 || escolha2 >= jogador.minerios.Count || escolha1 == escolha2)
        {
            Console.WriteLine("Escolha inválida. Selecione dois minérios diferentes.");
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

        Arma arma = new Arma(nomeArma, raridade, dano, velocidade, poderes);

        jogador.armas.Add(arma);

        if (escolha1 > escolha2)
        {
            jogador.minerios.RemoveAt(escolha1);
            jogador.minerios.RemoveAt(escolha2);
        }
        else
        {
            jogador.minerios.RemoveAt(escolha2);
            jogador.minerios.RemoveAt(escolha1);
        }

        Console.WriteLine("\nArma criada com sucesso!");

        arma.MostrarAtributos();

        jogador.GanharExperiencia(25);
    }

    static void MelhorarArma(Jogador jogador)
    {
        if (jogador.armas.Count == 0)
        {
            Console.WriteLine("Você não possui armas.");
            return;
        }

        MostrarArmas(jogador);

        int escolha = LerNumero("Escolha a arma que deseja melhorar: ");

        if (escolha < 0 || escolha >= jogador.armas.Count)
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        jogador.armas[escolha].Melhorar(random);

        jogador.GanharExperiencia(15);
    }

    static void MostrarArmas(Jogador jogador)
    {
        Console.WriteLine("\n========== SUAS ARMAS ==========");

        if (jogador.armas.Count == 0)
        {
            Console.WriteLine("Nenhuma arma encontrada.");
            return;
        }

        for (int i = 0; i < jogador.armas.Count; i++)
        {
            Console.WriteLine("\n" + i + " - " + jogador.armas[i].nome);
            jogador.armas[i].MostrarAtributos();
        }
    }

    static void Main()
    {
        Minerio[] minerios = CriarMinerios();

        Console.WriteLine("========== THE FORGE ==========");

        Console.Write("Digite o nome do jogador: ");
        string nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            nome = "Jogador";
        }

        Console.WriteLine("\nEscolha sua raça:");
        Console.WriteLine("1 - Humano");
        Console.WriteLine("2 - Elfo");
        Console.WriteLine("3 - Anão");
        Console.WriteLine("4 - Orc");

        int escolhaRaca = LerNumero("Opção: ");

        string[] racas = { "Humano", "Elfo", "Anão", "Orc" };

        if (escolhaRaca < 1 || escolhaRaca > 4)
        {
            escolhaRaca = 1;
        }

        Jogador jogador = new Jogador(nome, racas[escolhaRaca - 1]);

        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("\n========== MENU PRINCIPAL ==========");
            Console.WriteLine("1 - Ver status");
            Console.WriteLine("2 - Minerar");
            Console.WriteLine("3 - Ver inventário");
            Console.WriteLine("4 - Criar arma");
            Console.WriteLine("5 - Melhorar arma");
            Console.WriteLine("6 - Mostrar armas");
            Console.WriteLine("7 - Vender minério");
            Console.WriteLine("0 - Sair");

            opcao = LerNumero("Escolha uma opção: ");

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
                    Console.WriteLine("Obrigado por jogar The Forge!");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
