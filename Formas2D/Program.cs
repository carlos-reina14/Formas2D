using System;

namespace Formas2D
{
    public class Program
    {
        static void Main()
        {
            InicioPruebas();
        }
        
        private static void InicioPruebas()
        {
            PruebaElipse();
            PruebaCirculo();
            PruebaRectangulo();
            PruebaCuadrado();
            PruebaTrianguloLados();
            PruebaTrianguloBaseAltura();
        }

        private static void PruebaElipse()
        {
            Elipse elipse = new Elipse(5, 3);
            Console.WriteLine("Creación elipse 5 x 3");
            Console.WriteLine($"Área de la elipse: {elipse.CalcularArea()}");
            Console.WriteLine($"Perímetro de la elipse: {elipse.CalcularPerimetro()}");
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaCirculo()
        {
            Circulo circulo = new Circulo(5);
            Console.WriteLine("Creación círculo con radio 5");
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaRectangulo()
        {
            Rectangulo rectangulo = new Rectangulo(4, 6);
            Console.WriteLine("Creación rectángulo 4 x 6");
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro()}");
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaCuadrado()
        {
            Cuadrado cuadrado = new Cuadrado(7);
            Console.WriteLine("Creación cuadrado 7x7x7x7");
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro()}");
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaTrianguloLados()
        {
            Triangulo triangulo = new Triangulo(3, 4, 5);
            Console.WriteLine("Creación triángulo con lados 3, 4 y 5");
            Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del triángulo: {triangulo.CalcularPerimetro()}");
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaTrianguloBaseAltura()
        {
            Triangulo triangulo = new Triangulo(4, 3);
            Console.WriteLine("Creación triángulo con base 4 y altura 3");
            Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del triángulo: {triangulo.CalcularPerimetro()}");
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaDiagrama()
        {
            // Añadir pruebas con diagrama
        }
    }
}
