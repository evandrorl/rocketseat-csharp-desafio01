
namespace DesafioPratico;

class SolicitaData
{
    public static void SolicitarData()
    {
        DateTime data = DateTime.Now;
        Console.WriteLine("Digite a data de hoje nos seguintes formatos:");
        string dataCompleto = data.ToLongDateString();
        string dataFormatoData = data.ToShortDateString();
        string hora24Horas = DateTime.Now.ToString("HH:mm");
        string dataMesExtenso = data.ToString("dd MMMM yy");
        Console.WriteLine(dataCompleto);
        Console.WriteLine(dataFormatoData);
        Console.WriteLine(hora24Horas);
        Console.WriteLine(dataMesExtenso);       
       // Console.WriteLine();
    }
}
