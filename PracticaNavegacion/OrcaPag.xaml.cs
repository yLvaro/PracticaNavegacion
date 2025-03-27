using PracticaNavegacion;

namespace PracticaNavegacion;

public partial class OrcaPag : ContentPage
{
    public OrcaPag()
    {
        InitializeComponent(); // Llama al método que inicializa los componentes visuales de la página.
    }
    /// <summary>
    /// Cuando se pulsa el botón "Detalles", se ejecuta este método. Este método crea un objeto de la clase "Animal" con información 
    /// sobre una orca y navega a la página "Detalles" pasando el objeto "orca" con toda su información.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DetallesBTN(object sender, EventArgs e)
    {
        //Creación de un objeto perteneciente a la clase "Animal", con información sobre una orca.
        var orca = new Animales
        {
            Nombre = "Orca", //Nombre del animal.
            Imagen = "orca.jpg", //Imagen del animal.
            Texto = "La orca es un mamífero marino. Es de los animales marinos más grandes", //Descripción del animal.
        };
        //Navega a la página "Detalles", pasando el objeto "orca" con toda su información.
        Navigation.PushAsync(new Detalles(orca));
    }
}