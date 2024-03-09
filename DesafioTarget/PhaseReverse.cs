namespace DesafioTarget;

public static class PhaseReverse
{
    public static string Reverse(string phrase)
    {
        // converte a string em um array de caracteres
        char[] caracteres = phrase.ToCharArray();

        for (int i = 0; i < caracteres.Length / 2; i++)
        {
           // variavel temporaria recebe o caractere na posição i
            char temporario = caracteres[i];

            // o caractere na posição i recebe o caractere na posição caracteres.Length - i - 1
            caracteres[i] = caracteres[caracteres.Length - i - 1];

            // o caractere na posição caracteres.Length - i - 1 recebe o caractere na posição i
            caracteres[caracteres.Length - i - 1] = temporario;
        }

        // converte o array de caracteres de volta para uma string
        return new string(caracteres);
    }
}
