using System;

namespace Exercicio3
{
    class Cilindro
    {
        public float raio;
        public float altura;
        private double volume;
        private double pi = Math.PI;
        public void calculaAltura()
        {
            volume = raio * raio * pi * altura;
        }
        public Cilindro(float raio, float altura)
        {
            this.raio = raio;
            this.altura = altura;
        }
        public double getVolume()
            {return volume;}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro c = new Cilindro(2.3f, 3.13f);
            c.calculaAltura();
            Console.WriteLine(c.getVolume());
        }
    }
}
