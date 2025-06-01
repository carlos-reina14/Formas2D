namespace Formas2D
{
    public class Circulo : Elipse
    {
        public double Radio
        {
            // Se podria usa SemiEjeMayor o SemiEjeMenor, ya que en un círculo son iguales
            get { return SemiEjeMayor; }
            set
            {
                SemiEjeMayor = value;
                SemiEjeMenor = value;
            }
        }

        public Circulo(double radio) : base(radio, radio) { }

        public override string ToString()
        {
            return $"Círculo (Radio: {Radio:F2})";
        }
    }
}