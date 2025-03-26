using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNavegacion
{
    public class Delfin : Animales
    {
        public Delfin()
        {
            Nombre = "Delfin";
            Texto = " es un mamífero marino. Suelen tener buenas relaciones con el ser humano";
        }

        public override string Detalles()
        {
            string textoF = $"{base.Detalles()}{Texto}";
            return textoF;
        }
    }
}
