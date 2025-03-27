using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class MerluzaPag : ContentPage
{
    public MerluzaPag()
    {
        InitializeComponent(); // Llama al método que inicializa los componentes visuales de la página.
    }
    /// <summary>
    /// Cuando se pulsa el botón "Detalles", se ejecuta este método. Este método crea un objeto de la clase "Animal" con información 
    /// sobre una merluza y navega a la página "Detalles" pasando el objeto "Merluza" con toda su información.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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