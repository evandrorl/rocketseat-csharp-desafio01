

namespace DesafioPratico;
class AnalisaPalavras
{
    public static void ContarCaracteres()
    {
        Console.WriteLine("Digite uma palavra");
        string texto = Console.ReadLine();

        while (string.IsNullOrEmpty(texto)){
            Console.WriteLine("Você deve digitar ao menos um carcter");
            texto = Console.ReadLine();
        }
        string textoSemEspacos = texto.Trim();

        String[] verificaPalavras = textoSemEspacos.Split(" ");

        foreach (var item in verificaPalavras)
        {
            Console.WriteLine("A palavra " + item + " tem " + item.Length + " letras.");
        }
    }
}
