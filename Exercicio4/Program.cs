using System;

namespace Exercicio4
{
    class Consumo
    {
        public int kmInicial, kmFinal;
        private int kmTotal;
        private float litrosPorKm;
        public float gasolina;
        public Consumo(int inicio, int fim, float gasolina)
        {
            kmInicial = inicio;
            kmFinal = fim;
            this.gasolina = gasolina;
        }
        public void calculaGasolina()
        {
            litrosPorKm = (kmTotal - kmInicial) / gasolina;
        }
        public float getGasolina()
        {
            return litrosPorKm;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Consumo c = new Consumo(23543, 23756, 22.9f);
            c.calculaGasolina();
            Console.WriteLine(c.getGasolina());
        }
    }
}
