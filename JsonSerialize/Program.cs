using JsonSerialize.Models;
using Newtonsoft.Json;

//Serializacao do objeto
var dataAtual = DateTime.Now;
var vendasEletronicos = new List<Venda>()
{
    new Venda(1, "pc-gamer", 4.500M, dataAtual, 450.00M),
    new Venda(1, "teclado", 150.00M, dataAtual, null),
    new Venda(1, "mouse", 80.00M, dataAtual, null),
    new Venda(1, "Monitor", 1.299M, dataAtual, 129.99M)
};

var vendaSerializada = JsonConvert.SerializeObject(vendasEletronicos, Formatting.Indented);

File.WriteAllText("C:\\Users\\river\\RiderProjects\\JsonSerialize\\JsonSerialize\\Arquivos\\venda.json", vendaSerializada);
Console.WriteLine(vendaSerializada);

Console.WriteLine("---------------------Deserializacao do objeto--------------------");
Console.WriteLine();
//Deserializacao do objeto

var conteudoDoArquivo =
    File.ReadAllText("C:\\Users\\river\\RiderProjects\\JsonSerialize\\JsonSerialize\\Arquivos\\venda.json");
var vendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoDoArquivo);

foreach (var venda in vendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, " +
                      $"Data da venda: {venda.DataDaVenda.ToString("dd/MM/yyyy HH:mm")} " +
                      $"{(venda.Desconto.HasValue ? $"Desconto de : {venda.Desconto}" : "")}");
}
Console.WriteLine("---------------------Tipos anonimos--------------------");
Console.WriteLine();
//tipos anonimos em colecao
vendas
    .Select(vendaAnonima => new {vendaAnonima.Produto , vendaAnonima.Preco} )
    .ToList()
    .ForEach(it => Console.WriteLine($"Produto: {it.Produto}, Preço: {it.Preco}"));