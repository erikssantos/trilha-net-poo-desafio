namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string memoria, string sistemaOperacional)
            : base(numero, modelo, memoria, sistemaOperacional)
        {
        }

        // Sobrescrevendo o método abstrato "InstalarAplicativo" para o Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na Loja Nokia...");
        }
    }
}
