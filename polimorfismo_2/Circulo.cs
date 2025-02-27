using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polimorfismo_2
{
    public class Circulo : Geometria
    {
        public override void CalcularArea()
        {
            //throw new System.NotImplementedException();

            Console.Write("\t Escriba el valor del radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            base.area = 2.0 * (System.Math.PI) * (System.Math.Pow(radio,2));


        }
    }
}