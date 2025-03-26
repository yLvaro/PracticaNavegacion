using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNavegacion
{
    public class Tiburon : Animales
    {
        public Tiburon()
        {
            Nombre = "Tiburon";
            Texto = " es un pez depredador. Suelen ser temidos por el ser humano";
        }

        public override string Detalles()
        {
            string textoF = $"{base.Detalles()}{Texto}";
            return textoF;
        }
    }
}
