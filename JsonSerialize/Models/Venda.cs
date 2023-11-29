using Newtonsoft.Json;

namespace JsonSerialize.Models;

public class Venda
{
    public int Id { get; set; }
    [JsonProperty("Nome_Produto")]
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataDaVenda { get; set; }
    public decimal? Desconto { get; set; }

    public Venda(int id, string produto, decimal preco, DateTime dataDaVenda, decimal? desconto)
    {
        Id = id;
        Produto = produto;
        Preco = preco;
        DataDaVenda = dataDaVenda;
        Desconto = desconto;
    }
}