
# Desafio Target Sistemas

Projeto Console em C# que será utilizado como forma de avaliação no processo seletivo na Target Sistemas na vaga de Estágio em Desenvolvimento.

## Como executar o projeto?

**1. Clone o repositório** 

```
git clone https://github.com/jacks0nsilva/DesafioTarget.git
```

**2. Navegue até o diretório do projeto**

```
cd DesafioTarget
```

**3.Compile o código usando o compilador C#**
```
dotnet build
```

**4. Execute o programa**

```
dotnet run
```

**5. Siga as instruções no console**

```
• Digite um texto e pressione Enter para ver o texto invertido

• Responda 'S' se deseja executar novamente ou 'N' para sair do programa
```

## Explicando o loop for no método Reverse

O loop foi utilizado para inverter a ordem da string.
A variável ***temporario*** armazena o caractere que será trocado de posição.
O loop se encerra caso ***i*** seja maior que a metade do tamanho de array de caracteres.

***Exemplo***

    public static string Reverse(string phrase)
    {
        char[] caracteres = phrase.ToCharArray();

        for (int i = 0; i < caracteres.Length / 2; i++)
        {
            char temporario = caracteres[i];
            caracteres[i] = caracteres[caracteres.Length - i - 1];
            caracteres[caracteres.Length - i - 1] = temporario;
        }
        return new string(caracteres);
    }





**char temporario = caracteres[i];**

 _Armazena temporariamente o caractere na posição i do array de caracteres em uma variável temporária chamada temporario._


**caracteres[i] = caracteres[caracteres.Length - i - 1];**

_Substitui o caractere na posição **i** pelo caractere na posição oposta no array. Basicamente o primeiro caractere é trocado com o último, o segundo com o penúltimo, e assim por diante._

**caracteres[caracteres.Length - i - 1] = temporario;**

_A posição oposta do array (calculada como caracteres.Length - i - 1) recebe o valor armazenado na variável temporária. Isso completa a troca dos caracteres._

Para evitar trocas duplicadas, o loop encerra quando i for maior que a metade do comprimento do array de caracteres.  Após o término do loop, o método retorna uma nova string criada com os caracteres invertidos.
