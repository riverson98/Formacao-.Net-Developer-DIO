namespace Desafios_de_projetos.SistemaDeHospedagem.Models;

public class Suite
{
    public string TipoDaSuite;
    public int Capacidade;
    public decimal ValorDaDiaria;

    public Suite(string tipoDaSuite, int capacidade, decimal valorDaDiaria)
    {
        TipoDaSuite = tipoDaSuite;
        Capacidade = capacidade;
        ValorDaDiaria = valorDaDiaria;
    }
}