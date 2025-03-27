using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class DelfinPag : ContentPage
{
    /// <summary>
    /// Constructor de la clase "DelfinPag".
    /// </summary>
    public DelfinPag()
    {
        InitializeComponent(); // Llama al método que inicializa los componentes visuales de la página.
    }
    /// <summary>
    /// Cuando se pulsa el botón "Detalles", se ejecuta este método. Este método crea un objeto de la clase "Animal" con información 
    /// sobre un delfín y navega a la página "Detalles" pasando el objeto "Delfin" con toda su información.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creación de un objeto perteneciente a la clase "Animales", con información sobre un delfín.
        var delfin = new Animales
        {
            Nombre = "Delfin", //Nombre del animal.
            Imagen = "delfin.jpg", //Imagen del animal.
            Texto = "El delfín es un mamífero acuático. Es conocido por su cercanía con el ser humano", //Descripción del animal.
        };
        //Navega a la página "Detalles", pasando el objeto "Delfín" con toda su información.
        Navigation.PushAsync(new Detalles(delfin));
    }
}