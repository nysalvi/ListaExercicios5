using System;

namespace Exercicio10
{
    class MediaPonderada
    {
        float peso1, peso2, nota1, nota2, media;

        public MediaPonderada(float peso1, float peso2, float nota1, float nota2)
        {
            this.peso1 = peso1;
            this.peso2 = peso2;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
        public void calculaMedia()
        {
            media = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        }
        public float getMedia()
        {
            return media;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada md = new MediaPonderada(2.5f, 3, 7, 9.5f);
            md.calculaMedia();
            Console.WriteLine(md.getMedia());
        }
    }
}
