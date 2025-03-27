namespace PracticaNavegacion;

public partial class AnimalesDetalles : ContentPage
{
    public AnimalesDetalles(string nombreAnimal, string texto)
    {
        InitializeComponent();
        // Aquí puedes usar el nombreAnimal para cargar o mostrar los detalles.
        // Por ejemplo, podrías tener un Label llamado DetallesLabel:
        Animales.Text = $"Detalles sobre: {nombreAnimal}";
    }

    /*public DetallesAnimalPage()
    {
        InitializeComponent();
        // Este constructor vacío es necesario si navegas sin pasar parámetros.
    }*/
}