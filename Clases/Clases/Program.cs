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
            

            Rectangulo r2 = new Rectangulo {Base=3, Altura=8 };

            int a2 = r2.Area();
            int p2 = r2.Perimetro();
            double d2 = r2.Diagonal();
            Console.WriteLine("r2: {0} x {1} su area es {2}", r2.Base, r2.Altura, a2);
            Console.WriteLine("r2: {0} x {1} su perimetro es {2}", r2.Base, r2.Altura, p2);
            Console.WriteLine("r2: {0} x {1} su diagonal es {2}", r2.Base, r2.Altura, d2);

            Console.ReadKey();

        }
    }
}
