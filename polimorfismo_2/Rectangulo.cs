using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polimorfismo_2
{
    public class Rectangulo : Geometria
    {
        public override void CalcularArea()
        {
            //throw new System.NotImplementedException();
            Console.Write("\tEscriba el valor de la base del rectangulo:");
            double Base = Convert.ToDouble(Console.ReadLine());

            Console.Write("\tEscriba el valor de la altura del rectangulo:");
            double Altura = Convert.ToDouble(Console.ReadLine());
            base.area = Base * Altura;
        }//cierre método calcularArea
    }//cierre  clase rectangulo
}//cierre espacio de nombres