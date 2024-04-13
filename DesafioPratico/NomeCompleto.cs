
namespace DesafioPratico;

class NomeCompleto
{
    public static void JuntarNomes()
    {
        Console.WriteLine("Informe o seu nome");
        string nome  = Console.ReadLine();
        Console.WriteLine("Informe o seu sobrenome");
        string sobreNome = Console.ReadLine();
        string nomeCompleto = $"{nome} {sobreNome}";
        Console.WriteLine(String.Format("Seu nome completo é: {0}", nomeCompleto));
    }
}
