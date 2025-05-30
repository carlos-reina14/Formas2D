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
    }
}
