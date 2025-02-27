using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polimorfismo_2
{
    public class Geometria
    {
        public double area;

        public virtual void CalcularArea()
        {
            //throw new System.NotImplementedException();

            Console.WriteLine("El área es:" + area);

        }//cierre del método CalcularArea
    }//cierre de la clase Geometria
}//cierre del espacio de nombres