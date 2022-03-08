using System;

namespace Exercicio9
{
    class MediaHarmonica
    {
        float[] valores;
        float soma, media;
        public MediaHarmonica(float[] valores)
        {
            soma = 0;
            this.valores = valores;
        }
        public void calculaMedia()
        {
            foreach(float f in valores)
            {
                soma += 1 / f;
            }
            media = valores.Length / soma;
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
            MediaHarmonica mh = new MediaHarmonica(new float[]{1, 4, 5, 6, 9});
            mh.calculaMedia();
            Console.WriteLine(mh.getMedia());
        }
    }
}
