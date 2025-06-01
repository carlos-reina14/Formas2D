namespace Formas2D
{
    public class Rectangulo : Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        // Un rectangulo siempre tiene 4 lados, por eso se llama al constructor base con 4
        public Rectangulo(double baseRectangulo, double alturaRectangulo) : base(4)
        {
            Base = baseRectangulo;
            Altura = alturaRectangulo;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }

        public override string ToString()
        {
            return $"Rectángulo (Base: {Base:F2}, Altura: {Altura:F2})";
        }
    }
}