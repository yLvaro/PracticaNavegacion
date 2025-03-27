namespace PracticaNavegacion;

public partial class Detalles : ContentPage
{
    /// <summary>
    /// Constructor de la p�gina "Detalles"
    /// Recibe un objeto "Animales" con la informaci�n seleccionada.
    /// </summary>
    /// <param name="animal">Objeto de la clase "Animales", contenedor de los datos.</param>
    public Detalles(Animales animal)
    {
        InitializeComponent();

        //Asigna el objeto "animal" al contexto de enlace de la p�gina. Recoge los elementos de la p�gina y los asocia con los datos del objeto "animal".
        BindingContext = animal;
    }
}