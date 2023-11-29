using JsonSerialize.Models;
using Newtonsoft.Json;

//Deserializacao do objeto

var conteudoDoArquivo =
    File.ReadAllText("C:\\Users\\river\\RiderProjects\\JsonSerialize\\JsonSerialize\\Arquivos\\venda.json");
var vendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoDoArquivo);

foreach (var venda in vendas)
{
    Console.WriteLine($"Id:{venda.Id}");
    Console.WriteLine($"Produto:{venda.Produto}");
    Console.WriteLine($"Preço:{venda.Preco}");
    Console.WriteLine($"Data da venda:{venda.DataDaVenda}");
}

//Serializacao do objeto
var dataAtual = DateTime.Now;
var vendasEletronicos = new List<Venda>()
{
    new Venda(1, "pc-gamer", 4.500M, dataAtual),
    new Venda(1, "teclado", 150.00M, dataAtual),
    new Venda(1, "mouse", 80.00M, dataAtual),
    new Venda(1, "Monitor", 1.299M, dataAtual)
};

var vendaSerializada = JsonConvert.SerializeObject(vendasEletronicos, Formatting.Indented);

File.WriteAllText("C:\\Users\\river\\RiderProjects\\JsonSerialize\\JsonSerialize\\Arquivos\\venda.json", vendaSerializada);
Console.WriteLine(vendaSerializada);