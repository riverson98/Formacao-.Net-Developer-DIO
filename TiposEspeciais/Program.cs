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