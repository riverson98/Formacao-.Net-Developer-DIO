// tipos nullable
bool? desejaReceberEmail  = true;

var mensagem = desejaReceberEmail.HasValue && desejaReceberEmail.Value 
    ? "O usuario optou por receber e-mail" 
    : "O usuario não respondeu ou optou por não receber e-mail";
    
Console.WriteLine(mensagem);

//tipos anonimos

var tipoAnonimo = new { Nome = "Wei", Sobrenome = "Cheng", Altura = 1.68 };
Console .WriteLine($"Nome: {tipoAnonimo.Nome}, Sobrenome: {tipoAnonimo.Sobrenome}, Altura: {tipoAnonimo.Altura}");