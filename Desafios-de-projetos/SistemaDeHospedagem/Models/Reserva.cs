namespace Desafios_de_projetos.SistemaDeHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes;
    public Suite Suite;
    public int DiasReservados;

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastraHospedes(List<Pessoa> hospedes)
    {
        Hospedes = new List<Pessoa>();
        if (!hospedes.Count.Equals(0))
        {
            Hospedes.AddRange(hospedes);
            Console.WriteLine("Hospedes cadastrado com sucesso bem vindos a night corps coporation");
        }
        else
            Console.WriteLine("Deve haver hospedes para se cadastrar na reserva");
    }

    public void CadastraSuite(Suite suite)
    {
        Suite = new Suite(suite.TipoDaSuite, suite.Capacidade, suite.ValorDaDiaria);
        Console.WriteLine("Suite cadastrata com sucesso!!!");
    }

    public int ObtemQuantidadeDeHospedes()
    {
        Console.WriteLine($"O numero cadastrado de hospedes no hotel é: {Hospedes.Count}");
        return Hospedes.Count;
    }

    public decimal CalculaValorDaReserva()
    {
        var desconto = (Suite.ValorDaDiaria * DiasReservados) * 0.1M;
        
        return DiasReservados >= 10 
            ? Suite.ValorDaDiaria * DiasReservados - desconto
            : Suite.ValorDaDiaria * DiasReservados;
    }
}