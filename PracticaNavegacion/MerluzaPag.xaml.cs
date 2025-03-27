using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class MerluzaPag : ContentPage
{
    public MerluzaPag()
    {
        InitializeComponent(); // Llama al método que inicializa los componentes visuales de la página.
    }
    /// <summary>
    /// Esta función controla el evento que se activa al pulsar el botón "Detalles".
    /// Cuando se pulsa el botón, crea un objeto "Animales", con la información de una merluza
    /// y lo envía a la página "Detalles".
    /// </summary>
    /// <param name="sender">Botón que activo el evento</param>
    /// <param name="e">Datos del evento</param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creación de un objeto perteneciente a la clase "Animal", con información sobre una merluza.
        var merluza = new Animales
        {
            Nombre = "Merluza", //Nombre del animal.
            Imagen = "Merluza.jpg", //Imagen del animal.
            Texto = "La merluza es un pez de mar. Es conocido por ser uno de los más comidos del mundo", //Descripción del animal.
        };
        //Navega a la página "Detalles", pasando el objeto "merluza" con toda su información.
        Navigation.PushAsync(new Detalles(merluza));
    }
}