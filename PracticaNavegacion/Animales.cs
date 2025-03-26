using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNavegacion
{
    public class Animales
    {
        public string Nombre { get; set; }  
        public string Texto { get; set; }

        public virtual string Detalles()
        {
            return $"Este animal {this.Texto}";
        }

        public void Navegacion()
        {
        }
    }

    
}
