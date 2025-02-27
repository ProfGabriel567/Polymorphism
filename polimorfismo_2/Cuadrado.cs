using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polimorfismo_2
{
    public class Cuadrado : Geometria
    {
        public override void CalcularArea()
        {
            //throw new System.NotImplementedException();

            Console.Write("\t Escriba el valor de un lado del cuadrado:");
            double lado = Convert.ToDouble(Console.ReadLine());
            base.area = lado * lado;



        }//cierre método CalcularArea
    }//cierre clase cuadrado
}//cierre espacio de nombres