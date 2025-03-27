using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class TiburonPag : ContentPage
{
    public TiburonPag()
    {
        InitializeComponent(); // Llama al m�todo que inicializa los componentes visuales de la p�gina.
    }
    /// <summary>
    /// Cuando se pulsa el bot�n "Detalles", se ejecuta este m�todo. Este m�todo crea un objeto de la clase "Animal" con informaci�n 
    /// sobre un tibur�n y navega a la p�gina "Detalles" pasando el objeto "tibur�n" con toda su informaci�n.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creaci�n de un objeto perteneciente a la clase "Animal", con informaci�n sobre un tiburon.
        var tiburon = new Animales
        {
            Nombre = "tiburon", //Nombre del animal.
            Imagen = "tiburon.jpg", //Imagen del animal.
            Texto = "El tiburon es uno de los animales m�s temidos. Pese a esto, hay entre 80 y 100 ataques anuales en todo el mundo", //Descripci�n del animal.
        };
        //Navega a la p�gina "Detalles", pasando el objeto "tiburon" con toda su informaci�n.
        Navigation.PushAsync(new Detalles(tiburon));
    }
}