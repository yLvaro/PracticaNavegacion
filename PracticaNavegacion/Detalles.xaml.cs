namespace PracticaNavegacion;

public partial class Detalles : ContentPage
{
    /// <summary>
    /// Constructor de la página "Detalles"
    /// Recibe un objeto "Animales" con la información seleccionada.
    /// </summary>
    /// <param name="animal">Objeto de la clase "Animales", contenedor de los datos.</param>
    public Detalles(Animales animal)
    {
        InitializeComponent();

        //Asigna el objeto "animal" al contexto de enlace de la página. Recoge los elementos de la página y los asocia con los datos del objeto "animal".
        BindingContext = animal;
    }
}