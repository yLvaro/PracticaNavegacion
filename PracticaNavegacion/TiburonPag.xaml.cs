using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class TiburonPag : ContentPage
{
    public TiburonPag()
    {
        InitializeComponent(); // Llama al método que inicializa los componentes visuales de la página.
    }
    /// <summary>
    /// Cuando se pulsa el botón "Detalles", se ejecuta este método. Este método crea un objeto de la clase "Animal" con información 
    /// sobre un tiburón y navega a la página "Detalles" pasando el objeto "tiburón" con toda su información.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creación de un objeto perteneciente a la clase "Animal", con información sobre un tiburon.
        var tiburon = new Animales
        {
            Nombre = "tiburon", //Nombre del animal.
            Imagen = "tiburon.jpg", //Imagen del animal.
            Texto = "El tiburon es uno de los animales más temidos. Pese a esto, hay entre 80 y 100 ataques anuales en todo el mundo", //Descripción del animal.
        };
        //Navega a la página "Detalles", pasando el objeto "tiburon" con toda su información.
        Navigation.PushAsync(new Detalles(tiburon));
    }
}