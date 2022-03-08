using System;

namespace Exercicio8
{
    class Lata
    {
        double raio, altura, volume, pi = Math.PI;
        public Lata(double raio,double altura)
        {
            this.raio = raio;
            this.altura = altura;
        }
        public void calculaVolume()
        {
            volume = raio * raio * pi * altura; 
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
            Lata lata = new Lata(2.3, 3.9);
            lata.calculaVolume();
            Console.WriteLine(lata.getVolume());
        }
    }
}
