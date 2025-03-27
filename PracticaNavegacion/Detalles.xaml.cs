namespace PracticaNavegacion;

public partial class Detalles : ContentPage
{
    /// <summary>
    /// Constructor de la p�gina "Detalles"
    /// Recibe un objeto "Animales" con la informaci�n seleccionada.
    /// </summary>
    /// <param name="animal">Objeto de la clase "Animal", contenedor de los datos.</param>
    public Detalles(Animales animal)
    {
        InitializeComponent();

        //Establece el "BindingContent" de la p�gina con el objeto "animal"
        //Esto permite que los elementos de la interfaz de usuario como las etiquetas, imagenes o botones
        //Se enlacen autom�ticamente a las propiedades del objeto animal.
        BindingContext = animal;
    }


}