using System;

namespace Exercicio6
{
    class ConversorCParaF
    {
        private float temperaturaF;
        public float temperaturaC;

        public void converteParaF()
        {
            temperaturaF = temperaturaC * 1.8f + 32;
        }
        public ConversorCParaF(float c)
        {
            temperaturaC = c;
        }
        public float getFahrenheit()
        {
            return temperaturaF;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorCParaF c = new ConversorCParaF(18.5f);
            c.converteParaF();
            Console.WriteLine(c.getFahrenheit());
        }
    }
}
