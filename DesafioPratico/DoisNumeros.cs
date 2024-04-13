namespace DesafioPratico;

class DoisNumeros
{
    public static void Calcular()
    {
        Console.WriteLine("Você deve informar dois números");
        Console.WriteLine("Informe o primeiro número");
        double numero1;
        double numero2;

        while (!double.TryParse(Console.ReadLine(), out numero1))
            Console.WriteLine("Numero inválido, Digite novamente");
        Console.WriteLine("Informe o segundo número");
        while (!double.TryParse(Console.ReadLine(), out numero2))
            Console.WriteLine("Numer inválido, Digite novamente");

        Console.WriteLine(String.Format("A soma dos dois numeros é igual a: {0}", numero1 + numero2));
        Console.WriteLine(String.Format("A subtração dos dois numeros é igual a: {0}", numero1 - numero2));
        Console.WriteLine(String.Format("A multiplicação entre os dois numeros é igual a: {0}", numero1 * numero2));    
        Console.WriteLine(String.Format("A divisão entre os dois numeros é igual a: {0}", numero2 != 0 ?  numero1 / numero2 : "Não é possível dividir por zero"));
        Console.WriteLine(String.Format("A média dos dois numeros é igual a: {0}", (numero1 + numero2)/2));


    }
}
