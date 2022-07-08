using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Trapecio: Cuadrilatero
    {
        public double[] Lados { get; set; }
        //private double[] CoordenadaX = new double[4];
        //private double[] CoordenadaY = new double[4];
        
        public Trapecio(double[] lados): base(lados)
        {
            Lados = lados;
            //CoordenadaX = coordenadaX;
            //CoordenadaY = coordenadaY;
            
        }

        public override double Area(double[] lado)
        {
            double lado1 = lado[0];
            double lado2 = lado[1];
            double altura = lado[2];
            double area = altura * (lado1 + lado2)/2;
            
            return area;
        }

        
    }
}
