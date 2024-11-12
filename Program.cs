using DesafioPOO.Models;

public class Program
{
    public static void Main(string[] args)
    {
        // Criando um iPhone
        Iphone iphone = new Iphone("123456789", "iPhone 13", "128GB", "iOS");
        
        // Testando o iPhone
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");
        
        Console.WriteLine();

        // Criando um Nokia
        Nokia nokia = new Nokia("987654321", "Nokia 3310", "16MB", "Nokia OS");
        
        // Testando o Nokia
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");
    }
}
