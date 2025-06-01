using System;
using System.Collections.Generic;
using System.Linq;

namespace Formas2D
{
    public class Diagrama
    {
        public List<Forma> Formas { get; set; }

        public Diagrama(List<Forma> formas)
        {
            Formas = formas;
        }

        // Constructor vacio para añadir formas más adelante
        public Diagrama()
        {
            Formas = new List<Forma>();
        }

        public void AñadirForma(Forma forma)
        {
            Formas.Add(forma);
        }

        public double CalcularAreaTotal()
        {
            return Formas.Sum(forma => forma.CalcularArea());
        }

        public double CalcularPerimetroTotal()
        {
            return Formas.Sum(forma => forma.CalcularPerimetro());
        }

        public void MostrarFormas()
        {
            if (Formas.Count == 0)
                Console.WriteLine("El diagrama no contiene formas.");
            else
            {
                Console.WriteLine("--- Formas en el Diagrama ---");
                foreach (Forma forma in Formas)
                    Console.WriteLine($"- {forma}, Área: {forma.CalcularArea():F2}, Perímetro: {forma.CalcularPerimetro():F2}");
                Console.WriteLine("--------------------------");
            }
        }
    }
}