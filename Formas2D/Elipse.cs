using System;

namespace Formas2D
{
    public class Elipse : Forma
    {
        public double SemiEjeMayor { get; set; }
        public double SemiEjeMenor { get; set; }

        public Elipse(double semiEjeMayor, double semiEjeMenor)
        {
            SemiEjeMayor = semiEjeMayor;
            SemiEjeMenor = semiEjeMenor;
        }

        public override double CalcularArea()
        {
            return Math.PI * SemiEjeMayor * SemiEjeMenor;
        }

        public override double CalcularPerimetro()
        {
            // Aproximación de Ramanujan para el perímetro de una elipse
            return Math.PI * (3 * (SemiEjeMayor + SemiEjeMenor) -
                Math.Sqrt((3 * SemiEjeMayor + SemiEjeMenor) *
                (SemiEjeMayor + 3 * SemiEjeMenor)));
        }

        public override string ToString()
        {
            return $"Elipse (Semieje Mayor: {SemiEjeMayor:F2}, Semieje Menor: {SemiEjeMenor:F2})";
        }
    }
}