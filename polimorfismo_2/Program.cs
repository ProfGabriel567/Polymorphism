using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado();
            Rectangulo r = new Rectangulo();
            Rombo rb = new Rombo();
            Circulo circ = new Circulo();
            c.CalcularArea();
            Console.WriteLine("\t Area del Cuadrado es:" + c.area);
            Console.WriteLine();
            r.CalcularArea();
            Console.WriteLine("\t Area del Rectangulo es:" + r.area);
            Console.WriteLine();
            rb.CalcularArea();
            Console.WriteLine("\t Area del Rombo es:" + rb.area);
            Console.WriteLine();
            
            circ.CalcularArea();
            Console.WriteLine("\t Area del Circulo es:" + circ.area);
            Console.WriteLine();
            Console.ReadLine();

        }//cierre método main
    }//cierre class program
}//espacio de nombres polimorfismo
