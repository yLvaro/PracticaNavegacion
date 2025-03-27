namespace PracticaNavegacion;

public partial class Detalles : ContentPage
{
    /// <summary>
    /// Constructor de la página "Detalles"
    /// Recibe un objeto "Animales" con la información seleccionada.
    /// </summary>
    /// <param name="animal">Objeto de la clase "Animal", contenedor de los datos.</param>
    public Detalles(Animales animal)
    {
        InitializeComponent();

        //Establece el "BindingContent" de la página con el objeto "animal"
        //Esto permite que los elementos de la interfaz de usuario como las etiquetas, imagenes o botones
        //Se enlacen automáticamente a las propiedades del objeto animal.
        BindingContext = animal;
    }


}