bool? desejaReceberEmail  = true;

var mensagem = desejaReceberEmail.HasValue && desejaReceberEmail.Value 
    ? "O usuario optou por receber e-mail" 
    : "O usuario não respondeu ou optou por não receber e-mail";
    
Console.WriteLine(mensagem);