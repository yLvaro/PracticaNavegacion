using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class MerluzaPag : ContentPage
{
    public MerluzaPag()
    {
        InitializeComponent(); // Llama al m�todo que inicializa los componentes visuales de la p�gina.
    }
    /// <summary>
    /// Cuando se pulsa el bot�n "Detalles", se ejecuta este m�todo. Este m�todo crea un objeto de la clase "Animal" con informaci�n 
    /// sobre una merluza y navega a la p�gina "Detalles" pasando el objeto "Merluza" con toda su informaci�n.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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