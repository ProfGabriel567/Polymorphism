using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polimorfismo_2
{
    public class Rombo : Geometria
    {
        public override void CalcularArea()
        {
            Console.Write("\tEscriba el valor de la diagonal mayor del rombo:");
            double diagonalMayor = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tEscriba el valor d ela diagonal menor del rombo:");
            double diagonalMenor = Convert.ToDouble(Console.ReadLine());
            base.area = diagonalMayor * diagonalMenor / 2;


        }//cierre método CalcularArea

    }//cierre de la clase
}//cierre del espacio de nombres