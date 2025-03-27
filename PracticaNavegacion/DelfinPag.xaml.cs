using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class DelfinPag : ContentPage
{
    /// <summary>
    /// Constructor de la clase "DelfinPag".
    /// </summary>
    public DelfinPag()
    {
        InitializeComponent(); // Llama al m�todo que inicializa los componentes visuales de la p�gina.
    }
    /// <summary>
    /// Cuando se pulsa el bot�n "Detalles", se ejecuta este m�todo. Este m�todo crea un objeto de la clase "Animal" con informaci�n 
    /// sobre un delf�n y navega a la p�gina "Detalles" pasando el objeto "Delfin" con toda su informaci�n.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creaci�n de un objeto perteneciente a la clase "Animales", con informaci�n sobre un delf�n.
        var delfin = new Animales
        {
            Nombre = "Delfin", //Nombre del animal.
            Imagen = "delfin.jpg", //Imagen del animal.
            Texto = "El delf�n es un mam�fero acu�tico. Es conocido por su cercan�a con el ser humano", //Descripci�n del animal.
        };
        //Navega a la p�gina "Detalles", pasando el objeto "Delf�n" con toda su informaci�n.
        Navigation.PushAsync(new Detalles(delfin));
    }
}