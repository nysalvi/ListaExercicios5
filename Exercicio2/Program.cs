using System;

namespace Exercicio2
{
    class ConversorFparaC
    {
        public float temperaturaF;
        private float temperaturaC;
        public void converteParaC()
        {
            temperaturaC = (temperaturaF - 32) / 1.8f;
            Console.WriteLine(temperaturaC);
        }
        public ConversorFparaC(float f)
            {temperaturaF = f;}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorFparaC c = new ConversorFparaC(18.5f); 
            c.converteParaC();
        }
    }
}
