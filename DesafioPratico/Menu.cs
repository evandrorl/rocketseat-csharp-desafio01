
using System.Reflection.Emit;
namespace DesafioPratico;
class Menu
{
    public static void EscolherMenu()
    {
        bool continuar = true;
        while (continuar) {
            Console.Clear();
            Dictionary<string,string> opcoes = new Dictionary<string,string>();
            opcoes.Add("0", "Escolha qual exercício você quer acessar, para isso digite o nome correspondente - para sair digite 0");
            opcoes.Add("1", "Para acessar Saudaçao digite:                 1");
            opcoes.Add("2", "Para nome completo digite:                    2");
            opcoes.Add("3", "Para acessar o cálculo de números:            3");
            opcoes.Add("4", "Para acessar o contador de caracteres digite: 4");
            opcoes.Add("5", "Para acessar o validador de placas digite:    5");
            opcoes.Add("6", "Para acessar a solicitação de datas:          6");

            foreach (var item in opcoes)
            {
                Console.WriteLine(item.Value.ToString());
            }
            string valorDigitado = Console.ReadLine().ToString();


            if (valorDigitado is null || !opcoes.ContainsKey(valorDigitado))
            {
                Console.WriteLine("Você deve digitar números de 1 a 5");
            }
            else
            {
               switch(valorDigitado)
                {
                    case "1":
                        Console.Clear();
                        Saudacao.Saudar();
                        Pausa();
                        break;
                    case "2":
                        Console.Clear();
                        NomeCompleto.JuntarNomes();
                        Pausa();
                        break;
                    case "3":
                        Console.Clear();
                        DoisNumeros.Calcular();
                        Pausa();
                        break;
                    case "4":
                        Console.Clear();
                        AnalisaPalavras.ContarCaracteres();
                        Pausa();
                        break;  
                    case "5":
                        Console.Clear();
                        ValidaPlaca.Validar();
                        Pausa();
                        break;  
                    case "6":
                        Console.Clear();
                        SolicitaData.SolicitarData();
                        Pausa();
                        break;
              }
            }
            if (valorDigitado == "0")
            {
                continuar = false;
            }
           
        }
        return;       
    }
    private static void Pausa()
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
