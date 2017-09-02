using System;


namespace Clases
{
    /// <summary>
    /// Clases
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo();
            rect.Base = 10;
            rect.Altura = 5;

            int area = rect.Area();
            int per = rect.Perimetro();
            double diag = rect.Diagonal();
            Console.WriteLine("rect: {0} x {1} su area es {2}", rect.Base, rect.Altura, area);
            Console.WriteLine("rect: {0} x {1} su perimetro es {2}", rect.Base, rect.Altura, per);
            Console.WriteLine("rect: {0} x {1} su diagonal es {2}", rect.Base, rect.Altura, diag);
            Console.ReadKey();


        }
    }
}
