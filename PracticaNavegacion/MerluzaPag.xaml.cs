using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class MerluzaPag : ContentPage
{
    public MerluzaPag()
    {
        InitializeComponent(); // Llama al m�todo que inicializa los componentes visuales de la p�gina.
    }
    /// <summary>
    /// Esta funci�n controla el evento que se activa al pulsar el bot�n "Detalles".
    /// Cuando se pulsa el bot�n, crea un objeto "Animales", con la informaci�n de una merluza
    /// y lo env�a a la p�gina "Detalles".
    /// </summary>
    /// <param name="sender">Bot�n que activo el evento</param>
    /// <param name="e">Datos del evento</param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creaci�n de un objeto perteneciente a la clase "Animal", con informaci�n sobre una merluza.
        var merluza = new Animales
        {
            Nombre = "Merluza", //Nombre del animal.
            Imagen = "Merluza.jpg", //Imagen del animal.
            Texto = "La merluza es un pez de mar. Es conocido por ser uno de los m�s comidos del mundo", //Descripci�n del animal.
        };
        //Navega a la p�gina "Detalles", pasando el objeto "merluza" con toda su informaci�n.
        Navigation.PushAsync(new Detalles(merluza));
    }
}