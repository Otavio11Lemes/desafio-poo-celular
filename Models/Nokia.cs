using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public string Numero { get; set; }

        // As propriedades abaixo não possuem o método set pois não podem ser alteradas
        public string Modelo { get; }
        public string IMEI { get; }
        public int Memoria { get; }

        //O método base() é usado para chamar o construtor da classe base (superclasse) a partir de uma classe derivada (subclasse)
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}
