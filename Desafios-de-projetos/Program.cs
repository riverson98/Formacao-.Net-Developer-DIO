using Desafios_de_projetos.SistemaDeHospedagem.Models;

// Cria pessoas para cadastrar na lista
var hospedes = new List<Pessoa>()
{
    new Pessoa(nome: "Hospede 1"),
    new Pessoa(nome: "Hospede 2")
};
        
// Cria suite
var suite = new Suite(tipoDaSuite: "Premium", capacidade: 2, valorDaDiaria: 50);
        
// Cria uma nova reserva
var reserva = new Reserva(diasReservados: 5);
reserva.CadastraSuite(suite);
reserva.CadastraHospedes(hospedes);
        
Console.WriteLine($"Hóspedes: {reserva.ObtemQuantidadeDeHospedes()}");
Console.WriteLine($"Valor da reserva: {reserva.CalculaValorDaReserva()}");