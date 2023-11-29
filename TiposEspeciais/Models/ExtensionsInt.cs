namespace TiposEspeciais.Models;

public static class ExtensionsInt
{
    public static bool EhPar(this int numero)
    {
        return numero % 2 == 0;
    }
}