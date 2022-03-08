using System;

namespace Exercicio7
{
    class Salario
    {
        public float vendas, salario, comissao;
        private float salariofinal;
        public Salario(float vendas, float salario, float comissao)
        {
            this.vendas = vendas;
            this.salario = salario;
            this.comissao = comissao;
        }
        public void calculaSalario()
        {
            salariofinal = vendas * 0.1f * comissao + salario;
        }
        public float getSalarioFinal()
        {
            return salariofinal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario sal = new Salario(859.13f, 2250.59f, 11);
            sal.calculaSalario();
            Console.WriteLine(sal.getSalarioFinal());
        }
    }
}
