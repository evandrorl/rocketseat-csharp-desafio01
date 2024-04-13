namespace DesafioPratico;

class Saudacao
{
    public static void Saudar()
    {
        Console.WriteLine("Digite o seu Nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Olá " + nome + "! Seja muito-bemvindo!");
    }
}
