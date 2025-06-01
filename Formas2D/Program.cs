using System;
using System.Collections.Generic;

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
            PruebaDiagrama();
            PruebaDiagramaVacio();
        }

        private static void PruebaElipse()
        {
            Elipse elipse = new Elipse(5, 3);
            Console.WriteLine($"Creacion {elipse}");
            Console.WriteLine($"Área de la elipse: {elipse.CalcularArea():F2}");
            Console.WriteLine($"Perímetro de la elipse: {elipse.CalcularPerimetro():F2}");
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaCirculo()
        {
            Circulo circulo = new Circulo(5);
            Console.WriteLine($"Creacion {circulo}");
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro():F2}");
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaRectangulo()
        {
            Rectangulo rectangulo = new Rectangulo(4, 6);
            Console.WriteLine($"Creacion {rectangulo}");
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro():F2}");
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaCuadrado()
        {
            Cuadrado cuadrado = new Cuadrado(7);
            Console.WriteLine($"Creacion {cuadrado}");
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro():F2}");
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaTrianguloLados()
        {
            Triangulo triangulo = new Triangulo(3, 4, 5);
            Console.WriteLine($"Creacion {triangulo}");
            Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del triángulo: {triangulo.CalcularPerimetro():F2}");
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaTrianguloBaseAltura()
        {
            Triangulo triangulo = new Triangulo(4, 3);
            Console.WriteLine($"Creacion {triangulo}");
            Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del triángulo: {triangulo.CalcularPerimetro():F2}");
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PruebaDiagrama()
        {
            Diagrama diagrama = new Diagrama(CrearListaFormas());
            Console.WriteLine("Creación de diagrama con diferentes formas");
            diagrama.MostrarFormas();

            Console.WriteLine("\nPulsa Enter para calcular el perímetro y el área totales del diagrama...");
            Console.ReadLine();

            Console.WriteLine($"Área Total del Diagrama: {diagrama.CalcularAreaTotal():F2}");
            Console.WriteLine($"Perímetro Total del Diagrama: {diagrama.CalcularPerimetroTotal():F2}");

            Console.WriteLine("\nPulsa Enter para añadir un nuevo triángulo base 8 altura 5 al diagrama...");
            Console.ReadLine();
            Triangulo otroTriangulo = new Triangulo(8, 5);
            diagrama.AñadirForma(otroTriangulo);
            diagrama.MostrarFormas();

            Console.WriteLine("\nPulsa Enter para realizar los cálculos nuevamente...");
            Console.ReadLine();

            Console.WriteLine($"Nueva Área Total del Diagrama: {diagrama.CalcularAreaTotal():F2}");
            Console.WriteLine($"Nuevo Perímetro Total del Diagrama: {diagrama.CalcularPerimetroTotal():F2}");
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static List<Forma> CrearListaFormas()
        {
            Circulo circulo = new Circulo(8);
            Rectangulo rectangulo = new Rectangulo(8, 16);
            Cuadrado cuadrado = new Cuadrado(9);
            Elipse elipse = new Elipse(10, 5);
            Triangulo triangulo = new Triangulo(4, 7, 6);
            List<Forma> formas = new List<Forma>
            {
                circulo, rectangulo, cuadrado, elipse, triangulo
            };
            return formas;
        }

        private static void PruebaDiagramaVacio()
        {
            Diagrama diagrama = new Diagrama();
            Console.WriteLine("Creación de diagrama vacío");
            diagrama.MostrarFormas();

            Console.WriteLine("\nPulsa Enter para añadir un cuadrado base 12...");
            Console.ReadLine();

            diagrama.AñadirForma(new Cuadrado(12));
            diagrama.MostrarFormas();

            Console.WriteLine("\nPulsa Enter para añadir un rectángulo 14 x 22...");
            Console.ReadLine();

            diagrama.AñadirForma(new Rectangulo(14, 22));
            diagrama.MostrarFormas();

            Console.WriteLine("\nPulsa Enter para añadir un círculo radio 15...");
            Console.ReadLine();

            diagrama.AñadirForma(new Circulo(15));
            diagrama.MostrarFormas();

            Console.WriteLine("\nPulsa Enter para calcular el perímetro y el área totales del diagrama...");
            Console.ReadLine();

            Console.WriteLine($"Área Total del Diagrama: {diagrama.CalcularAreaTotal():F2}");
            Console.WriteLine($"Perímetro Total del Diagrama: {diagrama.CalcularPerimetroTotal():F2}");

            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}