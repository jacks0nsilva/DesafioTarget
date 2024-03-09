using DesafioTarget;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.Yellow;
bool executarNovamente = true;

while (executarNovamente)
{
    Console.WriteLine("\nOlá! Seja bem-vindo ao programa phrase reverse, conseguimos inverter qualquer frase que você deseja");
    Console.Write("\nDigite a frase que deseja inverter: ");

    string dadosDeEntrada = Console.ReadLine();
    string dadosDeSaida = PhaseReverse.Reverse(dadosDeEntrada);


    Console.WriteLine($"\nSua frase invertida é: {dadosDeSaida}");

    Console.Write("Deseja executar novamente? (S/N): ");
    char resposta = char.ToUpper(Console.ReadKey().KeyChar);
    Console.WriteLine();
    executarNovamente = (resposta == 'S');
}

Console.WriteLine("Obrigado por utilizar o programa phrase reverse! Volte sempre! :)");

