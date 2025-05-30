using System;

namespace Formas2D
{
    public class Triangulo : Poligono
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public double? BaseTriangulo { get; set; }
        public double? AlturaTriangulo { get; set; }

        // Un triángulo siempre tiene 3 lados, por eso se llama al constructor base con 3
        public Triangulo(double ladoA, double ladoB, double ladoC) : base(3)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        // Constructor alternativo para triángulos con base y altura, sin lados especificados
        // De esta forma solo se podrá calcular el área, no el perímetro
        public Triangulo(double baseTriangulo, double alturaTriangulo) : base(3)
        {
            BaseTriangulo = baseTriangulo;
            AlturaTriangulo = alturaTriangulo;
            LadoA = 0;
            LadoB = 0;
            LadoC = 0;
        }

        public override double CalcularArea()
        {
            // Si se especificaron la base y la altura, se puede calcular el área directamente
            if (BaseTriangulo.HasValue && AlturaTriangulo.HasValue)
                return 0.5 * BaseTriangulo.Value * AlturaTriangulo.Value;
            else
            {
                // Usando la fórmula de Herón para calcular el área, donde s es el semiperímetro
                double s = (LadoA + LadoB + LadoC) / 2;
                return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
            }
        }

        public override double CalcularPerimetro()
        {
            // Si no se especificaron los tres lados no se puede calcular el perímetro
            if (LadoA > 0 && LadoB > 0 && LadoC > 0)
                return LadoA + LadoB + LadoC;
            else
                return 0;
        }
    }
}
