using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNavegacion
{
    public class Merluza : Animales
    {
        public Merluza()
        {
            Nombre = "Merluza";
            Texto = " es un pez de agua salada. Suelen ser pescados para el consumo humano";
        }

        public override string Detalles()
        {
            string textoF = $"{base.Detalles()}{Texto}";
            return textoF;
        }
    }
}
