namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string memoria, string sistemaOperacional)
            : base(numero, modelo, memoria, sistemaOperacional)
        {
        }

        // Sobrescrevendo o método abstrato "InstalarAplicativo" para o Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na App Store do iPhone...");
        }
    }
}
