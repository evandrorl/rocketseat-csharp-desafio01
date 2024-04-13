
using System.Runtime.CompilerServices;

namespace DesafioPratico;

class ValidaPlaca
{
    public static void Validar()
    {
        bool entrar = true;

        while (entrar) 
        {
            Console.WriteLine("Informe a placa do veículo");

            string placa = Console.ReadLine().ToUpper();

            bool placaValida = false;

            if (placa.Length == 7)
            {
                if (char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]))
                {
                    if (char.IsDigit(placa[3]) && char.IsDigit(placa[4]) && char.IsDigit(placa[5]) && char.IsDigit(placa[6]))
                    {
                        placaValida |= true;
                    }
                }
            }
            if (placaValida) {
                Console.WriteLine("A placa é válida");
            }
            else
            {
                Console.WriteLine("A placa não é válida");
            }
            Console.WriteLine("Se quiser sair digite SAIR, para ler outra placa tecle enter.");
            if (Console.ReadLine().ToUpper().Equals("SAIR")){
                entrar = false;
            }
          
        }
    }
}
