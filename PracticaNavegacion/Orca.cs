using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNavegacion
{
    public class Orca : Animales
    {
        public Orca()
        {
            Nombre = "Orca";
            Texto = " es uno de los más grandes del océano. Es un mamífero marino que se alimenta de peces y otros animales marinos.";
        }

        public override string Detalles()
        {
            string textoF = $"{base.Detalles()}{Texto}";
            return textoF;
        }
    }
}
