namespace Formas2D
{
    public class Cuadrado : Rectangulo
    {
        // En un cuadrado, todos los lados son iguales, por lo que solo necesitamos un lado
        public Cuadrado(double lado) : base(lado, lado) { }

        public override string ToString()
        {
            // Reutiliza 'Base' de Rectangulo
            return $"Cuadrado (Lado: {Base:F2})";
        }
    }
}