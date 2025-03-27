using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class OrcaPag : ContentPage
{
    public OrcaPag()
    {
        InitializeComponent(); // Llama al m�todo que inicializa los componentes visuales de la p�gina.
    }
    /// <summary>
    /// Cuando se pulsa el bot�n "Detalles", se ejecuta este m�todo. Este m�todo crea un objeto de la clase "Animal" con informaci�n 
    /// sobre una orca y navega a la p�gina "Detalles" pasando el objeto "orca" con toda su informaci�n.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creaci�n de un objeto perteneciente a la clase "Animal", con informaci�n sobre una orca.
        var orca = new Animales
        {
            Nombre = "Orca", //Nombre del animal.
            Imagen = "orca.jpg", //Imagen del animal.
            Texto = "La orca es un mam�fero marino. Es de los animales marinos m�s grandes", //Descripci�n del animal.
        };
        //Navega a la p�gina "Detalles", pasando el objeto "orca" con toda su informaci�n.
        Navigation.PushAsync(new Detalles(orca));
    }
}