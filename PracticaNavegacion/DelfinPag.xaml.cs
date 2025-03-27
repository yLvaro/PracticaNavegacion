using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class DelfinPag : ContentPage
{
    public DelfinPag()
    {
        InitializeComponent(); // Llama al método que inicializa los componentes visuales de la página.
    }
    /// <summary>
    /// Esta función controla el evento que se activa al pulsar el botón "Detalles".
    /// Cuando se pulsa el botón, crea un objeto "Animales", con la información de un delfín
    /// y lo envía a la página "Detalles".
    /// </summary>
    /// <param name="sender">Botón que activo el evento</param>
    /// <param name="e">Datos del evento</param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creación de un objeto perteneciente a la clase "Animal", con información sobre una delfín.
        var delfin = new Animales
        {
            Nombre = "Delfin", //Nombre del animal.
            Imagen = "delfin.jpg", //Imagen del animal.
            Texto = "El delfín es un mamífero acuático. Es conocido por su cercanía con el ser humano", //Descripción del animal.
        };
        //Navega a la página "Detalles", pasando el objeto "Perro" con toda su información.
        Navigation.PushAsync(new Detalles(delfin));
    }
}