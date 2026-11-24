
using System;
using System.Collections.Generic;

class Cliente
{
    public string nome;
    public List<Reserva> reservas;

    public Cliente(string nome)
    {
        this.nome = nome;
        reservas = new List<Reserva>();
    }

    public void AdicionarReserva(Reserva reserva)
    {
        reservas.Add(reserva);
    }

    public void ListarReservas()
    {
        Console.WriteLine("Reservas de " + nome);

        for (int i = 0; i < reservas.Count; i++)
        {
            Console.WriteLine("Reserva: " + reservas[i].descricao);
        }
    }
}

class Reserva
{
    public string descricao;
    public Cliente cliente;

    public Reserva(string descricao, Cliente cliente)
    {
        this.descricao = descricao;
        this.cliente = cliente;
    }
}

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Tuany");

        Reserva reserva1 = new Reserva("Quarto 101", cliente);
        Reserva reserva2 = new Reserva("Quarto 202", cliente);

        cliente.AdicionarReserva(reserva1);
        cliente.AdicionarReserva(reserva2);

        cliente.ListarReservas();
    }
}
