using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNavegacion
{
    public class Animales
    {
        public string Nombre { get; protected set; }
        public string Texto { get; protected set; }

        public Animales(string nombre)
        {
            Nombre = nombre;
        }

        public virtual string Detalles()
        {
            return $"Este animal {this.Texto}";
        }

        public async System.Threading.Tasks.Task NavigateToDetails(INavigation navigation, string animalNombre)
        {
            await navigation.PushAsync(new Animales(animalNombre));
        }
    }

    public class Merluza : Animales
    {
        public Merluza() : base("Merluza")
        {
            Texto = " es un pez de agua salada. Suelen ser pescados para el consumo humano";
        }

        public override string Detalles()
        {
            string textoF = $"{base.Detalles()}{this.Texto}";
            return textoF;
        }
    }

    public class Orca : Animales
    {
        public Orca() : base("Orca")
        {
            Texto = " es uno de los más grandes del océano. Es un mamífero marino que se alimenta de peces y otros animales marinos.";
        }

        public override string Detalles()
        {
            string textoF = $"{base.Detalles()}{Texto}";
            return textoF;
        }
    }

    public class Delfin : Animales
    {
        public Delfin() : base("Delfin")
        {
            Texto = " es un mamífero marino. Suelen tener buenas relaciones con el ser humano";
        }

        public override string Detalles()
        {
            string textoF = $"{base.Detalles()}{Texto}";
            return textoF;
        }
    }

    public class Tiburon : Animales
    {
        public Tiburon() : base("Tiburon")
        {
            Texto = " es un pez depredador. Suelen ser temidos por el ser humano";
        }

        public override string Detalles()
        {
            string textoF = $"{base.Detalles()}{Texto}";
            return textoF;
        }
    }
}
