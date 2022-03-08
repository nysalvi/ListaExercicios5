using System;

namespace Exercicio5
{
    class Esfera
    {
        private double pi = Math.PI;
        public double raio, volume;
        
        public Esfera(double raio)
        {
            this.raio = raio;
        }
        public void calculaVolume()
        {
            volume = 4 * pi * Math.Pow(raio, 3) / 3;
        }
        public double getVolume()
        {
            return volume;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera es = new Esfera(2.34);
            es.calculaVolume();
            Console.WriteLine(es.getVolume());
        }
    }
}
