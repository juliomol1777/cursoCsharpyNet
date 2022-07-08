namespace Ejercicio16
{
    public abstract class Cuadrilatero
    {
        public double[] Lados { get; set; }
        
        private double[] CoordenadaX;
        private double[] CoordenadaY;

        public Cuadrilatero(double[] lados)
        {
            Lados = lados;
        }

        public abstract double Area(double[] lados);
    }
}