using System;


namespace Clases
{
    public class Rectangulo
    {
        public int Base {get; set; }
        public int Altura { get; set; }

        public int Area()
        {
            return Base * Altura;
        }
        public int Perimetro()
        {
            return 2*(Base + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Base * Base + Altura * Altura);
        }
    }
}
