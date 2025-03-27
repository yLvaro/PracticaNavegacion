using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class DelfinPag : ContentPage
{
    public DelfinPag()
    {
        InitializeComponent(); // Llama al m�todo que inicializa los componentes visuales de la p�gina.
    }
    /// <summary>
    /// Esta funci�n controla el evento que se activa al pulsar el bot�n "Detalles".
    /// Cuando se pulsa el bot�n, crea un objeto "Animales", con la informaci�n de un delf�n
    /// y lo env�a a la p�gina "Detalles".
    /// </summary>
    /// <param name="sender">Bot�n que activo el evento</param>
    /// <param name="e">Datos del evento</param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creaci�n de un objeto perteneciente a la clase "Animal", con informaci�n sobre una delf�n.
        var delfin = new Animales
        {
            Nombre = "Delfin", //Nombre del animal.
            Imagen = "delfin.jpg", //Imagen del animal.
            Texto = "El delf�n es un mam�fero acu�tico. Es conocido por su cercan�a con el ser humano", //Descripci�n del animal.
        };
        //Navega a la p�gina "Detalles", pasando el objeto "Perro" con toda su informaci�n.
        Navigation.PushAsync(new Detalles(delfin));
    }
}