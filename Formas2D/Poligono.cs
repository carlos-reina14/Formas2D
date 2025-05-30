namespace Formas2D
{
    public abstract class Poligono : Forma
    {
        public int NumeroLados { get; protected set; }

        public Poligono(int numeroLados)
        {
            NumeroLados = numeroLados;
        }

        public abstract override double CalcularArea();

        public abstract override double CalcularPerimetro();
    }
}
