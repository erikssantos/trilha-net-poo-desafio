using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Memoria { get; set; }
        public string SistemaOperacional { get; set; }

        // Construtor da classe Smartphone
        public Smartphone(string numero, string modelo, string memoria, string sistemaOperacional)
        {
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
            SistemaOperacional = sistemaOperacional;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que precisa ser implementado pelas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
