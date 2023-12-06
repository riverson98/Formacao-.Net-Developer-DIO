namespace Desafios_de_projetos.SistemaDeHospedagem.Models;

public class Pessoa
{
    public string Nome;
    public string? Sobrenome;

    public Pessoa(string nome, string? sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
    
    public Pessoa(string nome)
    {
        Nome = nome;
    }
}