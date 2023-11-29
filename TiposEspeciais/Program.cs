using TiposEspeciais.Models;

// tipos nullable
bool? desejaReceberEmail  = true;

var mensagem = desejaReceberEmail.HasValue && desejaReceberEmail.Value 
    ? "O usuario optou por receber e-mail" 
    : "O usuario não respondeu ou optou por não receber e-mail";
Console.WriteLine("----------------------------Tipo nullable-----------------------------");    
Console.WriteLine(mensagem);
Console.WriteLine();

//tipos anonimos

var tipoAnonimo = new { Nome = "Wei", Sobrenome = "Cheng", Altura = 1.68 };
Console.WriteLine("----------------------------Tipo anonimo-----------------------------");   
Console .WriteLine($"Nome: {tipoAnonimo.Nome}, Sobrenome: {tipoAnonimo.Sobrenome}, Altura: {tipoAnonimo.Altura}");
Console.WriteLine();

// tipos dinamicos
dynamic variavelDinamica = 4;

Console.WriteLine("----------------------------Tipo dinamico-----------------------------");   
Console.WriteLine($"Tipo da variavel {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "texto";   
Console.WriteLine($"Tipo da variavel {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = true;   
Console.WriteLine($"Tipo da variavel {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
Console.WriteLine();

// tipo generico
MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoNoArray(30);
Console.WriteLine("----------------------------Tipo generico-----------------------------"); 
Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarElementoNoArray("teste");
Console.WriteLine(arrayString[0]);
Console.WriteLine();

// metodos de extensoes
var numero = 15;
var par = false;

par = numero.EhPar();

var parOuImpar = $"O número {numero} é {(par ? "par" : "ímpar")}";
Console.WriteLine("----------------------------Metodos de extensoes-----------------------------"); 
Console.WriteLine(parOuImpar);

