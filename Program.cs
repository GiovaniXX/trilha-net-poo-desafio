using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("123456", "ModeloNokia", "IMEI123", 64);
        Iphone iphone = new Iphone("7891011", "ModeloIphone", "IMEI456", 128);

        Console.WriteLine($"Nokia - Número: {nokia.Numero}");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine($"iPhone - Número: {iphone.Numero}");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
